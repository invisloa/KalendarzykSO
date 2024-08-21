using Kalendarzyk.Models.EventModels;
using Kalendarzyk.Models.EventTypesModels;
using Kalendarzyk.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TheKalendarzyk.ViewModels.Events
{
    public class EventViewModel : BaseViewModel
    {
        private EventModel _eventModel;

        public event PropertyChangedEventHandler PropertyChanged;

        public EventViewModel(EventModel eventModel)
        {
            _eventModel = eventModel;
        }

        public int Id
        {
            get => _eventModel.Id;
            set
            {
                if (_eventModel.Id != value)
                {
                    _eventModel.Id = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Title
        {
            get => _eventModel.Title;
            set
            {
                if (_eventModel.Title != value)
                {
                    _eventModel.Title = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime StartDateTime
        {
            get => _eventModel.StartDateTime;
            set
            {
                if (_eventModel.StartDateTime != value)
                {
                    _eventModel.StartDateTime = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime EndDateTime
        {
            get => _eventModel.EndDateTime;
            set
            {
                if (_eventModel.EndDateTime != value)
                {
                    _eventModel.EndDateTime = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Description
        {
            get => _eventModel.Description;
            set
            {
                if (_eventModel.Description != value)
                {
                    _eventModel.Description = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool WasShown
        {
            get => _eventModel.WasShown;
            set
            {
                if (_eventModel.WasShown != value)
                {
                    _eventModel.WasShown = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsCompleted
        {
            get => _eventModel.IsCompleted;
            set
            {
                if (_eventModel.IsCompleted != value)
                {
                    _eventModel.IsCompleted = value;
                    OnPropertyChanged();
                }
            }
        }

        public int EventTypeId
        {
            get => _eventModel.EventTypeId;
            set
            {
                if (_eventModel.EventTypeId != value)
                {
                    _eventModel.EventTypeId = value;
                    OnPropertyChanged();
                }
            }
        }

        public EventTypeModel EventType
        {
            get => _eventModel.EventType;
            set
            {
                if (_eventModel.EventType != value)
                {
                    _eventModel.EventType = value;
                    OnPropertyChanged();
                }
            }
        }

        public TimeSpan ReminderTime
        {
            get => _eventModel.ReminderTime;
            set
            {
                if (_eventModel.ReminderTime != value)
                {
                    _eventModel.ReminderTime = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
