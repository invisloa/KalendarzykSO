using Kalendarzyk.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace KalendarzykSO.ViewModels.CustomControls
{
    public interface IColorButtonsSelectorHelperClass
	{
		ObservableCollection<SelectableButtonViewModel> ColorButtons { get; set; }
		ICommand SelectedButtonCommand { get; }
		Color SelectedColor { get; set; }
	}
}