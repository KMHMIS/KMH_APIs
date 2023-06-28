using KMHAPIs.Dapper;
using KMHAPIs.IRepo;
using KMHAPIs.Models.ResponseModel;
using KMHAPIs.Repo;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IDapper, KMHAPIs.Dapper.Dapper>();

builder.Services.AddTransient<GenericResponseModel>();
builder.Services.AddTransient<IAccountsRepo, AccountsRepo>();
builder.Services.AddTransient<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddTransient<IUserRepo, UserRepo>();
builder.Services.AddTransient<IRolesRepo, RolesRepo>();
builder.Services.AddTransient<IActionRepo, ActionRepo>();
builder.Services.AddTransient<IDesignationRepo, DesignationRepo>();
builder.Services.AddTransient<IDeparmentRepo, DeparmentRepo>();
builder.Services.AddTransient<IAssignFormToRoleRepo, AssignFormToRoleRepo>();
builder.Services.AddTransient<IAssignRoleToUserRepo, AssignRoleToUserRepo>();
builder.Services.AddTransient<IFormRepo, FormRepo>();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var key = Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"].ToString());

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = false;
    x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false,
        ClockSkew = TimeSpan.Zero
    };
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x
             .AllowAnyMethod()
             .AllowAnyHeader()
             .SetIsOriginAllowed(origin => true) // allow any origin
             .AllowCredentials()); // allow credentials

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
