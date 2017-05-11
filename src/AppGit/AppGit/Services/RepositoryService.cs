using AppGit.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppGit.Services
{
    public class RepositoryService : ServiceBase<IGitRepositoryService>
    {
        public async Task<List<Repository>> GetRepositories()
        {
            // return await Client.ObterRepositorios(); ret
            return null;
        }
    }
}
