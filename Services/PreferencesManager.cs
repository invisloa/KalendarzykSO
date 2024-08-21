using Kalendarzyk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarzyk.Services
{
    public static class PreferencesManager
    {
        // Define keys as constants
        public const string QuickNotesGroupNameKey = "QuickNote";
        public const string QuickNotesTypeNameKey = "QuickNote";
        public const string SelectedLanguageKey = "SelectedLanguage";
        public const string EventTypeTimesDifferentKey = "EventTypeTimesDifferent";
        public const string EventGroupTimesDifferentKey = "EventGroupTimesDifferent";
        public const string WeeklyHoursSpanKey = "WeeklyHoursSpan";
        public const string HoursSpanFromKey = "HoursSpanFrom";
        public const string HoursSpanToKey = "HoursSpanTo";

        // Methods to manage preferences with the updated naming convention
        public static string GetQuickNotesGroupName() => Preferences.Get(QuickNotesGroupNameKey, "QNOTE");
        public static string GetQuickNotesTypeName() => Preferences.Get(QuickNotesTypeNameKey, "QNOTE");

        public static int GetSelectedLanguage() => Preferences.Get(SelectedLanguageKey, (int)Enums.LanguageEnum.English);
        public static void SetSelectedLanguage(int value) => Preferences.Set(SelectedLanguageKey, value);

        public static bool GetEventTypeTimesDifferent() => Preferences.Get(EventTypeTimesDifferentKey, false);
        public static void SetEventTypeTimesDifferent(bool value) => Preferences.Set(EventTypeTimesDifferentKey, value);

        public static bool GetEventGroupTimesDifferent() => Preferences.Get(EventGroupTimesDifferentKey, false);
        public static void SetEventGroupTimesDifferent(bool value) => Preferences.Set(EventGroupTimesDifferentKey, value);

        public static bool GetWeeklyHoursSpan() => Preferences.Get(WeeklyHoursSpanKey, true);
        public static void SetWeeklyHoursSpan(bool value) => Preferences.Set(WeeklyHoursSpanKey, value);

        public static int GetHoursSpanFrom() => Preferences.Get(HoursSpanFromKey, 7);
        public static void SetHoursSpanFrom(int value) => Preferences.Set(HoursSpanFromKey, value);

        public static int GetHoursSpanTo() => Preferences.Get(HoursSpanToKey, 18);
        public static void SetHoursSpanTo(int value) => Preferences.Set(HoursSpanToKey, value);


        public static void ClearAllPreferences()
        {
            Preferences.Clear();
        }
    }
}
