using Kalendarzyk.Models.EventTypesModels;
using Kalendarzyk.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKalendarzyk.ViewModels.Events;

namespace KalendarzykSO.ViewModels
{
    internal class AddNewEventGroupViewModel : BaseViewModel
    {

        private EventGroupViewModel _eventGroup;

        // ctor
        //crate mode
        public AddNewEventGroupViewModel()
        {
            
        }
        //edit mode
        public AddNewEventGroupViewModel(EventGroupViewModel eventGroup)
        {
            _eventGroup = eventGroup;
        }
    }
}
