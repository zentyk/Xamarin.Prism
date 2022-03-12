using Xamarin.Forms;
using xamarin.mvvm.ViewModels;

namespace xamarin.mvvm {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            BindingContext = new MainViewModel(Navigation);
        }
    }
}
