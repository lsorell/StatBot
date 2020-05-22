using System;
using System.Collections.Generic;
using System.Text;

namespace StatBot.Services
{
    /// <summary>
    /// Holds configuration data for modules.
    /// </summary>
    public class ConfigService
    {
        public ConfigService() { }

        public ConfigService(Config config)
        {
            BaseConfig = config;
        }

        public static Config BaseConfig { get; set; }
    }
}
