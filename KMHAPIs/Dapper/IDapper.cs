﻿using Dapper;
using System.Data.Common;
using System.Data;

namespace KMHAPIs.Dapper
{
    public interface IDapper : IDisposable
    {
        DbConnection GetDbconnection();
        Task<T> Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        Task<IEnumerable<T>> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        //SqlMapper.GridReader GetMultiple(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure, object obj);
        int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        T Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        void Insert(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);

        T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);



        Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>> GetMultipleObjects<T1, T2, T3, T4, T5, T6>(string sql, object parameters,
                                        Func<SqlMapper.GridReader, IEnumerable<T1>> func1,
                                        Func<SqlMapper.GridReader, IEnumerable<T2>> func2,
                                        Func<SqlMapper.GridReader, IEnumerable<T3>> func3,
                                        Func<SqlMapper.GridReader, IEnumerable<T4>> func4,
                                        Func<SqlMapper.GridReader, IEnumerable<T5>> func5,
                                        Func<SqlMapper.GridReader, IEnumerable<T6>> func6);
        Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>> GetMultipleObjects<T1, T2, T3, T4, T5, T6, T7>(string sql, object parameters,
                                        Func<SqlMapper.GridReader, IEnumerable<T1>> func1,
                                        Func<SqlMapper.GridReader, IEnumerable<T2>> func2,
                                        Func<SqlMapper.GridReader, IEnumerable<T3>> func3,
                                        Func<SqlMapper.GridReader, IEnumerable<T4>> func4,
                                        Func<SqlMapper.GridReader, IEnumerable<T5>> func5,
                                        Func<SqlMapper.GridReader, IEnumerable<T6>> func6,
                                        Func<SqlMapper.GridReader, IEnumerable<T7>> func7);


        Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, Tuple<IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>>> GetMultipleObjects<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string sql, object parameters,
                                        Func<SqlMapper.GridReader, IEnumerable<T1>> func1,
                                        Func<SqlMapper.GridReader, IEnumerable<T2>> func2,
                                        Func<SqlMapper.GridReader, IEnumerable<T3>> func3,
                                        Func<SqlMapper.GridReader, IEnumerable<T4>> func4,
                                        Func<SqlMapper.GridReader, IEnumerable<T5>> func5,
                                        Func<SqlMapper.GridReader, IEnumerable<T6>> func6,
                                        Func<SqlMapper.GridReader, IEnumerable<T7>> func7,
                                        Func<SqlMapper.GridReader, IEnumerable<T8>> func8,
                                        Func<SqlMapper.GridReader, IEnumerable<T9>> func9);
        Tuple<IEnumerable<T1>, IEnumerable<T2>> GetMultipleObjects<T1, T2>(string sql, object parameters,
                                        Func<SqlMapper.GridReader, IEnumerable<T1>> func1,
                                        Func<SqlMapper.GridReader, IEnumerable<T2>> func2
                                      );



        Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>> GetMultipleObjects<T1, T2, T3>(string sql, object parameters,
                                        Func<SqlMapper.GridReader, IEnumerable<T1>> func1,
                                        Func<SqlMapper.GridReader, IEnumerable<T2>> func2,
                                        Func<SqlMapper.GridReader, IEnumerable<T3>> func3
                                      );
        Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>> GetMultipleObjects<T1, T2, T3, T4>(string sql, object parameters,
                                        Func<SqlMapper.GridReader, IEnumerable<T1>> func1,
                                        Func<SqlMapper.GridReader, IEnumerable<T2>> func2,
                                        Func<SqlMapper.GridReader, IEnumerable<T3>> func3,
                                        Func<SqlMapper.GridReader, IEnumerable<T4>> func4
                                      );
        Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>> GetMultipleObjects<T1, T2, T3, T4, T5>(string sql, object parameters,
                                        Func<SqlMapper.GridReader, IEnumerable<T1>> func1,
                                        Func<SqlMapper.GridReader, IEnumerable<T2>> func2,
                                        Func<SqlMapper.GridReader, IEnumerable<T3>> func3,
                                        Func<SqlMapper.GridReader, IEnumerable<T4>> func4,
                                        Func<SqlMapper.GridReader, IEnumerable<T5>> func5);


    }
}
