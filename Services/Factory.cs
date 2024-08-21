﻿using Kalendarzyk.Data;
using Kalendarzyk.Models.EventModels;
using Kalendarzyk.Models.EventTypesModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheKalendarzyk.Services
{
    class Factory
    {
        // Event Repository Singleton Pattern
        private static IEventRepository _eventRepository;

        public static IEventRepository GetEventRepository => _eventRepository;
        
        public static async Task<IEventRepository> InitializeEventRepository()  // TODO xxx USE IT SOMEWHERE AT STARTUP
        {
            if (_eventRepository == null)
                _eventRepository = await SQLiteRepository.CreateAsync();
            return _eventRepository;
        }
        public static ObservableCollection<MeasurementUnitItem> PopulateMeasurementCollection()
        {
            var descriptions = new Dictionary<MeasurementUnit, string>();
            var currencySymbol = CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;

            foreach (MeasurementUnit unit in Enum.GetValues(typeof(MeasurementUnit)))
            {
                descriptions[unit] = unit == MeasurementUnit.Money ? currencySymbol : unit.GetDescription();
            }

            var measurementUnitItems = new List<MeasurementUnitItem>(descriptions.Count);

            foreach (var unit in descriptions)
            {
                measurementUnitItems.Add(new MeasurementUnitItem(unit.Key)
                {
                    DisplayName = unit.Value
                });
            }

            return new ObservableCollection<MeasurementUnitItem>(measurementUnitItems);
        }
    }
}
