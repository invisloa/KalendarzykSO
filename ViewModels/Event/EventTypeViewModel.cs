using Kalendarzyk.Models.EventModels;
using Kalendarzyk.Models.EventTypesModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TheKalendarzyk.ViewModels.Events
{
    public class EventTypeViewModel : INotifyPropertyChanged
    {
        private EventTypeModel _eventTypeModel;

        public event PropertyChangedEventHandler PropertyChanged;

        public EventTypeViewModel(EventTypeModel eventTypeModel)
        {
            _eventTypeModel = eventTypeModel;
        }

        public int Id
        {
            get => _eventTypeModel.Id;
            set
            {
                if (_eventTypeModel.Id != value)
                {
                    _eventTypeModel.Id = value;
                    OnPropertyChanged();
                }
            }
        }

        public int EventGroupId
        {
            get => _eventTypeModel.EventGroupId;
            set
            {
                if (_eventTypeModel.EventGroupId != value)
                {
                    _eventTypeModel.EventGroupId = value;
                    OnPropertyChanged();
                }
            }
        }

        public string EventTypeName
        {
            get => _eventTypeModel.EventTypeName;
            set
            {
                if (_eventTypeModel.EventTypeName != value)
                {
                    _eventTypeModel.EventTypeName = value;
                    OnPropertyChanged();
                }
            }
        }

        public string EventTypeColorString
        {
            get => _eventTypeModel.EventTypeColorString;
            set
            {
                if (_eventTypeModel.EventTypeColorString != value)
                {
                    _eventTypeModel.EventTypeColorString = value;
                    OnPropertyChanged();
                }
            }
        }

        public TimeSpan DefaultEventTimeSpan
        {
            get => _eventTypeModel.DefaultEventTimeSpan;
            set
            {
                if (_eventTypeModel.DefaultEventTimeSpan != value)
                {
                    _eventTypeModel.DefaultEventTimeSpan = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsValueType
        {
            get => _eventTypeModel.IsValueType;
            set
            {
                if (_eventTypeModel.IsValueType != value)
                {
                    _eventTypeModel.IsValueType = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsMicroTaskType
        {
            get => _eventTypeModel.IsMicroTaskType;
            set
            {
                if (_eventTypeModel.IsMicroTaskType != value)
                {
                    _eventTypeModel.IsMicroTaskType = value;
                    OnPropertyChanged();
                }
            }
        }

        public int? QuantityId
        {
            get => _eventTypeModel.QuantityId;
            set
            {
                if (_eventTypeModel.QuantityId != value)
                {
                    _eventTypeModel.QuantityId = value;
                    OnPropertyChanged();
                }
            }
        }

        public QuantityModel QuantityAmount
        {
            get => _eventTypeModel.QuantityAmount;
            set
            {
                if (_eventTypeModel.QuantityAmount != value)
                {
                    _eventTypeModel.QuantityAmount = value;
                    OnPropertyChanged();
                }
            }
        }

        public EventGroupModel EventGroup
        {
            get => _eventTypeModel.EventGroup;
            set
            {
                if (_eventTypeModel.EventGroup != value)
                {
                    _eventTypeModel.EventGroup = value;
                    OnPropertyChanged();
                }
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var otherViewModel = (EventTypeViewModel)obj;
            return _eventTypeModel.Equals(otherViewModel._eventTypeModel);
        }


    }
}
