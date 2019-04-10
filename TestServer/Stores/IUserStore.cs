using System.Collections.Generic;
using System.Threading.Tasks;
using TestServer.Core.Models;

namespace TestServer.Stores
{
    public interface IUserStore
    {
        Task<IEnumerable<UserModel>> Get();
        Task Add(UserModel user);
    }
}