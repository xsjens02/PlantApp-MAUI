using PlantAppMAUI.ViewModels;

namespace PlantAppMAUI.Pages;

public partial class PlantDisplayPage : ContentPage
{
	public PlantDisplayPage(PlantDisplayVM pdvm)
	{
		InitializeComponent();
		this.BindingContext = pdvm;
	}
}