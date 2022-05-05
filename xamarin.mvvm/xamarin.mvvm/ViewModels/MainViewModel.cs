using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using xamarin.mvvm.Annotations;
using xamarin.mvvm.Pages;

namespace xamarin.mvvm.ViewModels {
    public class MainViewModel : INotifyPropertyChanged {
        public ICommand LoginCommand { get; set; }

        private string _userName;
        private string firstName = "Qenia";
        private string lastName = "Albares";

        private INavigation _navigation;

        public string UserName {
            get { return _userName; }
            set {
                //_userName = value;
                _userName = firstName +" "+ lastName;
                //OnPropertyChanged("UserName");
            }
        }

        public MainViewModel(INavigation navigation) {
            LoginCommand = new Command(Login);
            _navigation = navigation;
        }

        private void Login() {
            //Application.Current.MainPage.DisplayAlert("Hola Titulo", _userName, "AOK","Cancel");
            _navigation.PushAsync(new Page1(_userName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
