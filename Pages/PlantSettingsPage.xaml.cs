using PlantAppMAUI.ViewModels;

namespace PlantAppMAUI.Pages;

public partial class PlantSettingsPage : ContentPage
{
	public PlantSettingsPage(PlantSettingsVM psvm)
	{
		InitializeComponent();
		this.BindingContext = psvm;
	}
}