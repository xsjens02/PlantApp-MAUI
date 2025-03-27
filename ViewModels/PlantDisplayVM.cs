using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PlantAppMAUI.ViewModels
{
    public partial class PlantDisplayVM : ObservableObject
    {
        public PlantDisplayVM()
        {
            
        }

        [RelayCommand]
        private async Task GoToHome() => await Shell.Current.GoToAsync("//HomePage");
        [RelayCommand]
        private async Task GoToPlantSettings() => await Shell.Current.GoToAsync("//PlantSettingsPage");
    }
}
