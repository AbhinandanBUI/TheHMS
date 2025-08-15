using TheHMS.Model.Model.Common;

namespace TheHMS.IService.IService.Auth
{
    public interface IAuth
    {
        Task<Response> Login(string userName, string password);
    }
}
