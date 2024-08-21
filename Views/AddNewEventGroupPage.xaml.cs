using Kalendarzyk.Models.EventTypesModels;
using Kalendarzyk.ViewModels;
using KalendarzykSO.ViewModels;
using TheKalendarzyk.ViewModels.Events;

namespace Kalendarzyk.Views;

public partial class AddNewMainTypePage : ContentPage
{
	public AddNewMainTypePage()
    {
        InitializeComponent();

        BindingContext = new AddNewEventGroupViewModel();
    }
	public AddNewMainTypePage(EventGroupViewModel eventGroup)
    {
        InitializeComponent();

        BindingContext = new AddNewEventGroupViewModel(eventGroup);
	}


}

