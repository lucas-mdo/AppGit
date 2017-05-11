using System.Collections.Generic;
using System.Threading.Tasks;
using AppGit.Model;

namespace AppGit.Services
{
    public interface IGitRepositoryService : IServiceBase
    {       
        Task<List<Repository>> GetRepositories();
    }
}
