using TheHMS.Model.Model.Common;
using TheHMS.Model.Model.UserManagement;

namespace TheHMS.IService.IService.UserManagement
{
    public interface IUserManagement
    {
        Task<Response> CreateUser(UserManagementDTO user);

        Task<Response> GetAllUsers();
    }
}
