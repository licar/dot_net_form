using System.Collections.Generic;
using System.Threading.Tasks;
using TestServer.Core.Models;

namespace TestServer.Services
{
    public interface IFormService
    {
        Task<IEnumerable<FormModel>> Get();
        Task Add();
    }
}