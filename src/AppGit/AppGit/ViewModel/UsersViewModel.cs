using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGit.Model;

namespace AppGit.ViewModel
{
    public class UsersViewModel : BaseViewModel
    {
        public UsersViewModel(Repository repo)
        {
            AvatarUrl = repo.Owner.AvatarUrl;
            Login = repo.Owner.Login;
            Site = repo.Owner.HtmlUrl;
            IsForked = repo.IsForked;
            IsPrivate = repo.IsPrivate;
            Name = repo.Name;
            Description = repo.Description;
            RepoUrl = repo.HtmlUrl;
        }

        private string _avatarUrl;

        public string AvatarUrl
        {
            get { return _avatarUrl; }
            set { SetProperty(ref _avatarUrl, value); }
        }

        private string _login;

        public string Login
        {
            get { return _login; }
            set { SetProperty(ref _login, value); }
        }

        private string _site;

        public string Site
        {
            get { return _site; }
            set { SetProperty(ref _site, value); }
        }

        private bool _isForked;

        public bool IsForked
        {
            get { return _isForked; }
            set { SetProperty(ref _isForked, value); }
        }

        private bool _isPrivate;

        public bool IsPrivate
        {
            get { return _isPrivate; }
            set { SetProperty(ref _isPrivate, value); }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        private string _repoUrl;

        public string RepoUrl
        {
            get { return _repoUrl; }
            set { SetProperty(ref _repoUrl, value); }
        }


    }
}
