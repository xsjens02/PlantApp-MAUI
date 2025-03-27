
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PlantAppMAUI.ViewModels
{
    public partial class LoginVM : ObservableObject
    {
        public LoginVM()
        {
            
        }

        [RelayCommand]
        private async Task GoToHome() => await Shell.Current.GoToAsync("//HomePage");
    }
}
