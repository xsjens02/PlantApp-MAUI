using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Storage;
using System.Diagnostics;

namespace PlantAppMAUI.ViewModels
{
    public partial class PlantCreateVM : ObservableObject
    {
        public PlantCreateVM()
        {
            
        }

        [RelayCommand]
        private async Task GoToHome() => await Shell.Current.GoToAsync("//HomePage");

        [RelayCommand]
        private async Task PickImageFile()
        {
            try
            {
                var selectedFile = await FilePicker.Default.PickAsync(new PickOptions
                {
                    FileTypes = FilePickerFileType.Images,
                });

                if (selectedFile != null)
                {
                    var filePath = selectedFile.FullPath;
                    Debug.WriteLine($"Choosen file: {filePath}");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error: {e}");
            }
        }
    }
}
