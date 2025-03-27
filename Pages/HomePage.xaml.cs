using PlantAppMAUI.ViewModels;

namespace PlantAppMAUI.Pages;

public partial class HomePage : ContentPage
{
	public HomePage(HomeVM hvm)
	{
		InitializeComponent();
		this.BindingContext = hvm;
	}
}