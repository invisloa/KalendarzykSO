using AsyncAwaitBestPractices;
using Kalendarzyk.Data;
using Kalendarzyk.Models.EventModels;
using Kalendarzyk.Models.EventTypesModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace TheKalendarzyk.Services
{
    public class EventsService
    {
        public ObservableCollection<EventModel> AllEventsOC { get; private set; }
        public ObservableCollection<EventTypeModel> AllEventTypesOC { get; private set; }
        public ObservableCollection<EventGroupModel> AllEventGroupsOC { get; private set; }

        private readonly IEventRepository _eventRepository;

        public EventsService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
            InitializeDataAsync().SafeFireAndForget();
        }

        private async Task InitializeDataAsync()
        {
            var events = await _eventRepository.GetEventsListAsync().ConfigureAwait(false);
            AllEventsOC = new ObservableCollection<EventModel>(events.ToList());

            var eventTypes = await _eventRepository.GetEventTypesListAsync().ConfigureAwait(false);
            AllEventTypesOC = new ObservableCollection<EventTypeModel>(eventTypes.ToList());

            var eventGroups = await _eventRepository.GetEventGroupsListAsync().ConfigureAwait(false);
            AllEventGroupsOC = new ObservableCollection<EventGroupModel>(eventGroups.ToList());
        }
    }
}
