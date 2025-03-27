using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PlantAppMAUI.ViewModels
{
    public partial class HomeVM : ObservableObject
    {
        public HomeVM()
        {
            
        }

        [RelayCommand]
        private async Task GoToHomeSettings() => await Shell.Current.GoToAsync("//HomeSettingsPage");
        [RelayCommand]
        private async Task GoToPlantDisplay() => await Shell.Current.GoToAsync("//PlantDisplayPage");
        [RelayCommand]
        private async Task GoToPlantCreate() => await Shell.Current.GoToAsync("//PlantCreatePage");
    }
}
