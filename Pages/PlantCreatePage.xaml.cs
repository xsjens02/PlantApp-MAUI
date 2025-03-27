using PlantAppMAUI.ViewModels;

namespace PlantAppMAUI.Pages;

public partial class PlantCreatePage : ContentPage
{
	public PlantCreatePage(PlantCreateVM pcvm)
	{
		InitializeComponent();
		this.BindingContext = pcvm;
	}
}