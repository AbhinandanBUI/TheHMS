using Microsoft.Extensions.Configuration;
using TheHMS.IService.IService.Auth;
using TheHMS.IService.IService.Common;
using TheHMS.Model.Model.Common;

namespace TheHMS.Service.Service.Auth
{
    public class Auth: IAuth
    {
        private readonly IDapperAsync _dapper;
        private readonly IConfiguration _config;
        Response? response = null;
        public Auth(IDapperAsync dapper, IConfiguration config)
        {
            _dapper = dapper;
            _config = config;
        }
        public async Task<Response> Login(string username , string password)
        {
            using (response = new Response())
            {
                try
                {

                    if (username == "A" && password == "B")
                    {
                        response.totalRecords = 1;
                        response.message = "logic success";
                        response.success = true;
                        response.responseData = "logic response";
                    }
                    else
                    {
                        response.message = "logic success";
                        response.success = false;
                        response.responseData = "logic response";
                    }
                }
                catch (Exception ex)
                {
                    response.totalRecords = -1;
                    response.message = ex.Message;
                    response.success = false;
                    response.responseData = ex.Message;
                }
            }

            return response;
        }

    }

}
