using PlantAppMAUI.ViewModels;

namespace PlantAppMAUI.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginVM lvm)
	{
		InitializeComponent();
		this.BindingContext = lvm;
	}
}