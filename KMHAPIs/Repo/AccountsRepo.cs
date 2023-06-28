using KMHAPIs.Dapper;
using KMHAPIs.IRepo;
using KMHAPIs.Models.RequestModel;
using KMHAPIs.Models.ResponseModel;
using KMHAPIs.Models.SpResponseModel;
using Dapper;
using System.Web;
using System.Web.Configuration;
using System.Configuration.Provider;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace KMHAPIs.Repo
{
    public class AccountsRepo : IAccountsRepo
    {
        private readonly IConfiguration _configuration;

        private readonly IDapper db;
        GenericResponseModel response;
        private string machineKey;
        public AccountsRepo(IConfiguration configuration, IDapper db, GenericResponseModel response)
        {
            _configuration = configuration;
            this.db = db;
            this.response = response;
        }
        private byte[] HexToByte(string hexString)
        {
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }
        public async Task<GenericResponseModel> Login(LoginRequestModel rm)
        {
            try
            {
                var procedureName = "sp_Login";
                var parameters = new DynamicParameters();
                parameters.Add("loginId", rm.userName, DbType.String, ParameterDirection.Input);
                //HMACSHA1 hash = new HMACSHA1();
                //hash.Key = HexToByte("A824CBB621ECE844049C3AECFC29D4787A3A885F967D869F583652354BC84E9D024D892095840E819C8C31DB958281C8BD06726AFF29F5DA570954569C967C7B");
                //string encodedPassword = Convert.ToBase64String(hash.ComputeHash(Encoding.Unicode.GetBytes(rm.password)));
                parameters.Add("password", rm.password, DbType.String, ParameterDirection.Input);
                
                
                //CustomMemebership custom = new CustomMemebership();
                //string enc = custom.EncryptedPassword(rm.password);
                //EncryptedPassword(rm.password);



                spLogin data = await db.Get<spLogin>(procedureName, parameters);
                var encodedtoken = "";
                if (!data.userName.IsNullOrEmpty())
                {
                    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("JWT:Secret").Value));
                    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                    var claims = new[]
                    {
                    new Claim(ClaimTypes.Role,data.roleName)
                };
                    var token = new JwtSecurityToken(
                        issuer: _configuration["JWT:Secret"],
                        audience: _configuration["JWT:Secret"],
                        claims,
                        expires: DateTime.Now.AddDays(1),
                        signingCredentials: credentials
                        );
                    encodedtoken = new JwtSecurityTokenHandler().WriteToken(token);
                }
                if (data.employeeId != null)
                {
                    response.data = new { data.userName,data.roleName, data.employeeId, token = encodedtoken};
                    response.status = true;
                    response.message = data.message;
                }
                else
                {
                    response.data = new { data.userName,data.roleName, data.employeeId, token = encodedtoken };
                    response.status = false;
                    response.message = data.message;
                }
                return response;
            }
            catch (Exception ex)
            {

                response.data = "";
                response.status = false;
                response.message = ex.Message;
                return response;
            }
        }

    }
}
