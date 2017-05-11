using System;

namespace AppGit.Services
{
    public abstract class ServiceBase<T> where T : IServiceBase
    {
        private const string BASE_URL = "https://api.github.com";

        protected HttpClient Client
        {
            get;
            private set;
        }

        public ServiceBase()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(BASE_URL);
        }

    }
}
