using System.Collections.ObjectModel;
using AppGit.Model;
using Xamarin.Forms;

namespace AppGit.ViewModel
{
    public class RepositoriesViewModel : BaseViewModel
    {
        public RepositoriesViewModel()
        {
            RepositoriesCollection = new ObservableCollection<Repository>();
        }       

        public ObservableCollection<Repository> RepositoriesCollection;

    }
}
