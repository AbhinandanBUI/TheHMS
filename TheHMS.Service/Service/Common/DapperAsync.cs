using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using TheHMS.IService.IService.Common;

namespace TheHMS.Service.Service.Common
{
    public class DapperAsync : IDapperAsync
    {
        private readonly IConfiguration _config;
        private string Connectionstring = "DefaultConnection";

        public DapperAsync(IConfiguration config)
        {
            _config = config;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<int> Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            throw new NotImplementedException();
        }


        public async Task<T> Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.Text)
        {
            try
            {
                using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
                var result = await db.QueryAsync<T>(sp, parms, commandType: commandType);
                return result.FirstOrDefault()!;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<List<T>> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            try
            {
                using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
                var result = await db.QueryAsync<T>(sp, parms, commandType: commandType);
                return result.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        public async Task<List<T>> GetAllPagination<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));

            var result = await db.QueryAsync<T>(sp, parms, commandType: commandType);
            return result.ToList();
        }



        public DbConnection GetDbconnection()
        {
            return new SqlConnection(_config.GetConnectionString(Connectionstring));
        }


        public async Task<T> Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    var result = await db.QueryFirstOrDefaultAsync<T>(sp, parms, commandType: commandType, transaction: tran);
                    tran.Commit();
                    return result!;
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
            catch
            {
                throw;
            }
        }




        public async Task<T> Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    result = await db.QueryFirstOrDefaultAsync<T>(sp, parms, commandType: commandType, transaction: tran);
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return result!;
        }
    }
}