// Utilities/ConfigReader.cs
using System.IO;
using System.Text.Json;

namespace DemoQA_Automation.Utilities
{
    public static class ConfigReader
    {
        private static JsonDocument? _config;

        private static JsonDocument Config
        {
            get
            {
                if (_config == null)
                {
                    // config.json ko project root se dhundega
                    string path = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "Config",
                        "config.json"
                    );
                    string json = File.ReadAllText(path);
                    _config = JsonDocument.Parse(json);
                }
                return _config;
            }
        }

        public static string GetBrowser()
        {
            return Config.RootElement
                .GetProperty("Browser")
                .GetString() ?? "Chrome";
        }

        public static int GetImplicitWait()
        {
            return Config.RootElement
                .GetProperty("ImplicitWait")
                .GetInt32();
        }

        public static string GetScreenshotPath()
        {
            string relativePath = Config.RootElement
                .GetProperty("ScreenshotPath")
                .GetString() ?? "Reports/Screenshots/";

            // Project root dhundta hai — bin/debug se 3 level upar
            string projectRoot = Directory.GetParent(
                Directory.GetCurrentDirectory())!
                .Parent!.Parent!.FullName;

            return Path.Combine(projectRoot, relativePath);
        }
    }
}