using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PlantAppMAUI.ViewModels
{
    public partial class HomeSettingsVM : ObservableObject
    {
        public HomeSettingsVM()
        {
            
        }

        [RelayCommand]
        private async Task GoToHome() => await Shell.Current.GoToAsync("//HomePage");
        [RelayCommand]
        private async Task GoToLogin() => await Shell.Current.GoToAsync("//LoginPage");
    }
}
