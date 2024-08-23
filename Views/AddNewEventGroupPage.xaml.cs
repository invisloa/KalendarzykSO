using KalendarzykSO.ViewModels;

namespace KalendarzykSO.Views;

public partial class AddNewEventGroupPage : ContentPage
{
	public AddNewEventGroupPage()
	{
		AddNewEventGroupViewModel viewModel = new AddNewEventGroupViewModel();
		InitializeComponent();
		BindingContext = viewModel;
	}
}