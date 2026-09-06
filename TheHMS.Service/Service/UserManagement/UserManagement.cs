using Dapper;
using TheHMS.IService.IService.Common;
using TheHMS.IService.IService.UserManagement;
using TheHMS.Model;
using TheHMS.Model.Model.Common;
using TheHMS.Model.Model.UserManagement;
using TheHMS.Service.Service.ApplicationContacts;

namespace TheHMS.Service.Service.UserManagement
{
    public class UserManagement : IUserManagement
    {
        private readonly IDapperAsync _dapperAsync;
        Response response = null;
        public UserManagement(IDapperAsync dapperAsync)
        {
            _dapperAsync = dapperAsync;
        }
        public async Task<Response> CreateUser(UserManagementDTO user)
        {
            using (response = new Response())
            {
                try
                {
                    var dbparams = new DynamicParameters();
                    dbparams.Add("@UserName", user.UserName);
                    dbparams.Add("@FirstName", user.FirstName);
                    dbparams.Add("@LastName", user.LastName);
                    dbparams.Add("@Phone", user.Phone);
                    dbparams.Add("@Email", user.Email);
                    dbparams.Add("@Password", user.Password);
                    dbparams.Add("@HashPassword", user.HashPassword);
                    dbparams.Add("@AddressId", user.AddressId);
                    dbparams.Add("@IsActive", user.IsActive);
                    dbparams.Add("@RoleId", user.RoleId);
                    dbparams.Add("RegistrationDate", user.RegistrationDate);
                    var result = await _dapperAsync.Insert<string>("sp_InsertUser", dbparams, commandType: System.Data.CommandType.StoredProcedure);
                    if (result != null && result != string.Empty)
                    {
                        response.statusCode = (int)ApiStatusCode.Created;
                        response.message = ApiMessagesContact.UserCreatedSuccessfully;
                        response.success = true;
                        response.responseData = result;
                    }
                    else
                    {
                        response.statusCode = (int)ApiStatusCode.BadRequest;
                        response.message = "Failed to create user.";
                        response.success = false;
                    }
                }
                catch (Exception ex)
                {
                    response.statusCode = (int)ApiStatusCode.InternalServerError;
                    response.message = "An error occurred while creating the user."+ ex.Message;
                    response.success = false;
                }
            }
            return response;
        }

        public async Task<Response> GetAllUsers()
        {
            using (response = new Response())
            {
                try
                {
                    var dbparams =new  DynamicParameters();
                    var result  = await _dapperAsync.GetAll<UserManagementDTO>("sp_GetAllUsers", dbparams, commandType: System.Data.CommandType.StoredProcedure);
                    if (result.Count > 0)
                    {
                        response.totalRecords = result.Count;
                        response.statusCode = (int)ApiStatusCode.OK;
                        response.message = "Users retrieved successfully.";
                        response.success = true;
                        response.responseData = result;
                    }
                    else
                    {
                        response.statusCode = (int)ApiStatusCode.NotFound;
                        response.message = "No users found.";
                        response.success = false;
                        response.responseData = null;
                        response.totalRecords = 0;
                    }
                }
                catch (Exception ex)
                {
                    response.statusCode = (int)ApiStatusCode.InternalServerError;
                    response.message = "An error occurred while retrieving users." + ex.Message;
                    response.success = false;
                    response.responseData = null;
                    response.totalRecords = 0;
                }
            }
            return response;
        }
    }
}
