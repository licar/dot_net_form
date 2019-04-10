using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestServer.Core.Models;
using TestServer.Stores;

namespace TestServer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserStore userStore;

        public UserService(IUserStore userStore)
        {
            this.userStore = userStore;
        }

        public async Task Add(UserModel user)
        {
            await userStore.Add(user);
        }

        public async Task<IEnumerable<UserModel>> Get()
        {
            return await userStore.Get();
        }
    }
}