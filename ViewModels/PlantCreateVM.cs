using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Storage;
using System.Diagnostics;

namespace PlantAppMAUI.ViewModels;

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
                PickerTitle = "Choose a file",
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

    [RelayCommand]
    private async Task TakePhoto()
    {
        if (MediaPicker.Default.IsCaptureSupported)
        {
            FileResult photo = await MediaPicker.Default.CapturePhotoAsync();
            if (photo != null)
            {
                string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);


                using Stream sourceStream = await photo.OpenReadAsync();
                using FileStream localFileStream = File.OpenRead(localFilePath);

                await sourceStream.CopyToAsync(localFileStream);
            }
        }
    }
}   
            
        

    


