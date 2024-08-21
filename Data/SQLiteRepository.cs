using Kalendarzyk.Models;
using Kalendarzyk.Models.EventModels;
using Kalendarzyk.Models.EventTypesModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kalendarzyk.Data
{
    public class SQLiteRepository : IEventRepository
    {
        private readonly SQLiteAsyncConnection _database;

        // Private constructor to force use of the factory method
        private SQLiteRepository(SQLiteAsyncConnection database)
        {
            _database = database;
        }
        // Constructor

        public static async Task<SQLiteRepository> CreateAsync()
        {
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "KalendarzykEvents.db");
            var database = new SQLiteAsyncConnection(databasePath);
            var repository = new SQLiteRepository(database);
            await repository.InitializeDatabaseAsync();
            return repository;
        }

        private async Task InitializeDatabaseAsync()
        {
            try
            {
                await _database.CreateTableAsync<IconModel>();
                await _database.CreateTableAsync<EventGroupModel>();
                await _database.CreateTableAsync<EventTypeModel>();
                await _database.CreateTableAsync<EventModel>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating tables: {ex.Message}");
                throw;
            }
        }


        // Event Methods
        public async Task AddEventAsync(EventModel eventToAdd)
        {
            await _database.InsertAsync(eventToAdd);
        }

        public async Task<IEnumerable<EventModel>> GetEventsListAsync()
        {
            return await _database.Table<EventModel>().ToListAsync();
        }

        public async Task<EventModel> GetEventByIdAsync(int eventId)
        {
            return await _database.Table<EventModel>().FirstOrDefaultAsync(e => e.Id == eventId);
        }

        public async Task<EventModel> GetTypeByIdAsync(int typeId)
        {
            return await _database.Table<EventModel>().FirstOrDefaultAsync(e => e.Id == typeId);
        }

        public async Task<EventModel> GetGroupByIdAsync(int groupId)
        {
            return await _database.Table<EventModel>().FirstOrDefaultAsync(e => e.Id == groupId);
        }

        public async Task UpdateEventAsync(EventModel eventToUpdate)
        {
            await _database.UpdateAsync(eventToUpdate);
        }

        public async Task DeleteEventAsync(EventModel eventToDelete)
        {
            await _database.DeleteAsync(eventToDelete);
        }

        public async Task ClearAllEventsAsync()
        {
            await _database.DeleteAllAsync<EventModel>();
        }

        // Event Group Methods
        public async Task AddEventGroupAsync(EventGroupModel eventGroupToAdd)
        {
            await _database.InsertAsync(eventGroupToAdd);
        }

        public async Task<IEnumerable<EventGroupModel>> GetEventGroupsListAsync()
        {
            return await _database.Table<EventGroupModel>().ToListAsync();
        }

        public async Task UpdateEventGroupAsync(EventGroupModel eventGroupToUpdate)
        {
            await _database.UpdateAsync(eventGroupToUpdate);
        }

        public async Task DeleteEventGroupAsync(EventGroupModel eventGroupToDelete)
        {
            await _database.DeleteAsync(eventGroupToDelete);
        }

        public async Task ClearAllEventGroupsAsync()
        {
            await _database.DeleteAllAsync<EventGroupModel>();
        }

        // Event Type Methods
        public async Task AddEventTypeAsync(EventTypeModel eventTypeToAdd)
        {
            await _database.InsertAsync(eventTypeToAdd);
        }

        public async Task<IEnumerable<EventTypeModel>> GetEventTypesListAsync()
        {
            return await _database.Table<EventTypeModel>().ToListAsync();
        }

        public async Task UpdateEventTypeAsync(EventTypeModel eventTypeToUpdate)
        {
            await _database.UpdateAsync(eventTypeToUpdate);
        }

        public async Task DeleteEventTypesAsync(EventTypeModel eventTypeToDelete)
        {
            await _database.DeleteAsync(eventTypeToDelete);
        }

        public async Task ClearAllEventTypesAsync()
        {
            await _database.DeleteAllAsync<EventTypeModel>();
        }

        // File Operations
        public Task SaveEventsAndTypesToFile(IEnumerable<EventModel> eventsToSave = null)
        {
            // Implement saving to file logic
            // xxx
            throw new NotImplementedException();
        }

        public Task LoadEventsAndTypesFromFile()
        {
            // Implement loading from file logic
            // xxx
            throw new NotImplementedException();
        }
    }
}
