using AppGit.Model;
using AppGit.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGit.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsersPage : ContentPage
    {
        public UsersPage(Repository repo)
        {
            InitializeComponent();
            BindingContext = new UsersViewModel(repo);
        }
    }
}
