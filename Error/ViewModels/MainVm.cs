using System.Windows.Input;

using Xamarin.Forms;

namespace Error.ViewModels {
    public class MainVm {

        public ICommand Nav { get; set; }

        public MainVm() {

            Nav = new Command(NavAsync);
        }

        private async void NavAsync() {
            await App.Current.MainPage.Navigation.PushAsync(new Page1());
        }
    }
}
