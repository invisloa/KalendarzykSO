﻿using AsyncAwaitBestPractices;
using Kalendarzyk.Data;
using Kalendarzyk.Models.EventModels;
using Kalendarzyk.Models.EventTypesModels;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace TheKalendarzyk.Services
{
    public class EventsService : IEventsService
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
            await Factory.InitializeEventRepository().ConfigureAwait(false);
            var events = await _eventRepository.GetEventsListAsync().ConfigureAwait(false);
            AllEventsOC = new ObservableCollection<EventModel>(events.ToList());

            var eventTypes = await _eventRepository.GetEventTypesListAsync().ConfigureAwait(false);
            AllEventTypesOC = new ObservableCollection<EventTypeModel>(eventTypes.ToList());

            var eventGroups = await _eventRepository.GetEventGroupsListAsync().ConfigureAwait(false);
            AllEventGroupsOC = new ObservableCollection<EventGroupModel>(eventGroups.ToList());
        }

        public async Task DeleteEventGroupAsync(EventGroupModel groupToDelete)
        {
            // Delete all events that belong to the event group
            var eventsToDelete = AllEventsOC
                .Where(e => e.EventType.EventGroup.Equals(groupToDelete))
                .ToList();

            foreach (var eventModel in eventsToDelete)
            {
                AllEventsOC.Remove(eventModel);
                await _eventRepository.DeleteEventAsync(eventModel);
            }

            // Delete all event types that belong to the event group
            var eventTypesToDelete = AllEventTypesOC
                .Where(et => et.EventGroup.Equals(groupToDelete))
                .ToList();

            foreach (var eventType in eventTypesToDelete)
            {
                AllEventTypesOC.Remove(eventType);
                await _eventRepository.DeleteEventTypeAsync(eventType);
            }

            // Finally, delete the event group itself
            AllEventGroupsOC.Remove(groupToDelete);
            await _eventRepository.DeleteEventGroupAsync(groupToDelete);
        }
    }
}
