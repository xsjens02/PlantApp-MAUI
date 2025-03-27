using PlantAppMAUI.ViewModels;

namespace PlantAppMAUI.Pages;

public partial class HomeSettingsPage : ContentPage
{
	public HomeSettingsPage(HomeSettingsVM hsvm)
	{
		InitializeComponent();
		this.BindingContext = hsvm;
	}
}