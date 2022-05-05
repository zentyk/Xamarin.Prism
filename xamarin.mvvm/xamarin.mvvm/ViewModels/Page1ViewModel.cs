namespace xamarin.mvvm.ViewModels {
    public class Page1ViewModel {
        private string _loginUser;

        public string LoginUser {
            get { return _loginUser; }
            set { _loginUser = value; }
        }

        public Page1ViewModel(string username) {
            _loginUser = username;

        }
    }
}