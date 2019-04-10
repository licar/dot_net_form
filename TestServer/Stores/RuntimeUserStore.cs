using System.Collections.Generic;
using System.Threading.Tasks;
using TestServer.Core.Models;

namespace TestServer.Stores
{
    public class RuntimeUserStore : IUserStore
    {
        private ICollection<UserModel> users = new List<UserModel>();

        public async Task Add(UserModel user)
        {
            users.Add(user);
        }

        public async Task<IEnumerable<UserModel>> Get()
        {
            return users;
        }
    }
}