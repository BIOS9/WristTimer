using Newtonsoft.Json;
using System;
using System.IO;

namespace WristTimer
{
    class Settings
    {
        public enum NotificationMode
        {
            WindowsDefault,
            Custom,
            None
        }

        public string SoundFile = @"C:\Windows\Media\tada.wav";
        public decimal Interval = 10;
        public bool RunAtLogon = false, PlaySound = true;
        public NotificationMode Notifications = NotificationMode.WindowsDefault;
        public bool ForceWait = false;
        public int ForceWaitSeconds = 5;
        public bool TopMost = false;
        public bool ForceFocus = false;
        public bool PreWarning = false;
        public int PreWarningTime = 3;

        private static readonly string settingsPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
            "WristTimer");
        private const string settingsFile = "settings.json";

        public static Settings Load()
        {
            if (!File.Exists(Path.Combine(settingsPath, settingsFile)))
            {
                Settings settings = new Settings();
                Save(settings);
                return settings;
            }

            return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(
                Path.Combine(settingsPath, settingsFile)));
        }

        public void Save()
        {
            Save(this);
        }

        public static void Save(Settings settings)
        {
            if (!Directory.Exists(settingsPath))
                Directory.CreateDirectory(settingsPath);

            File.WriteAllText(Path.Combine(settingsPath, settingsFile), 
                JsonConvert.SerializeObject(settings));
        }
    }
}
