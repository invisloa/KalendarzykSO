using Kalendarzyk.Models;
using Kalendarzyk.Models.EventTypesModels;
using Kalendarzyk.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TheKalendarzyk.ViewModels.Events
{
    public class EventGroupViewModel : BaseViewModel
    {
        private EventGroupModel _eventGroupModel;
        private bool _isSelected;


        public EventGroupViewModel(EventGroupModel eventGroupModel)
        {
            _eventGroupModel = eventGroupModel;
        }

        public int Id
        {
            get => _eventGroupModel.Id;
            set
            {
                if (_eventGroupModel.Id != value)
                {
                    _eventGroupModel.Id = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Title
        {
            get => _eventGroupModel.Title;
            set
            {
                if (_eventGroupModel.Title != value)
                {
                    _eventGroupModel.Title = value;
                    OnPropertyChanged();
                }
            }
        }

        public int IconModelId
        {
            get => _eventGroupModel.IconModelId;
            set
            {
                if (_eventGroupModel.IconModelId != value)
                {
                    _eventGroupModel.IconModelId = value;
                    OnPropertyChanged();
                }
            }
        }

        public IconModel SelectedVisualElement
        {
            get => _eventGroupModel.SelectedVisualElement;
            set
            {
                if (_eventGroupModel.SelectedVisualElement != value)
                {
                    _eventGroupModel.SelectedVisualElement = value;
                    OnPropertyChanged();
                }
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var otherViewModel = (EventGroupViewModel)obj;

            return Id == otherViewModel.Id;
        }
    }
}
