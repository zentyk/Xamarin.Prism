using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin.mvvm.ViewModels;

namespace xamarin.mvvm.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage {
        public Page1(string username) {
            InitializeComponent();
            BindingContext = new Page1ViewModel(username);
        }
    }
}