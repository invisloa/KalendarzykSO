using Kalendarzyk.Models.EventModels;
using Kalendarzyk.Models.EventTypesModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace TheKalendarzyk.Services
{
    public interface IEventsService
    {
        ObservableCollection<EventModel> AllEventsOC { get; }
        ObservableCollection<EventTypeModel> AllEventTypesOC { get; }
        ObservableCollection<EventGroupModel> AllEventGroupsOC { get; }

        Task DeleteEventGroupAsync(EventGroupModel groupToDelete);
    }
}
