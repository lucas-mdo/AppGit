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
        public UsersViewModel()
        {
            UsersCollection = new ObservableCollection<User>();

            for (int i = 0; i < 10; i++)
            {
                UsersCollection.Add(new User(){ Login = $"Login {i}", Name = $"Name {i}", AvatarUrl = ":)"});
            }
        }

        public ObservableCollection<User> UsersCollection;

        /*private string _login;

        public string Login
        {
            get { return _login; }
            set { SetProperty(ref _login, value); }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _avatarUrl;

        public string AvatarUrl
        {
            get { return _avatarUrl; }
            set { SetProperty(ref _avatarUrl, value); }
        }*/

    }
}
