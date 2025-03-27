using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PlantAppMAUI.ViewModels
{
    public partial class PlantCreateVM : ObservableObject
    {
        public PlantCreateVM()
        {
            
        }

        [RelayCommand]
        private async Task GoToHome() => await Shell.Current.GoToAsync("//HomePage");
    }
}
