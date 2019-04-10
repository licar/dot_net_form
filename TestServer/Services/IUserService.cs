using System.Collections.Generic;
using System.Threading.Tasks;
using TestServer.Core.Models;

namespace TestServer.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserModel>> Get();
        Task Add(UserModel user);
    }
}