using System;
using System.Collections.Generic;
using System.Text;

namespace StatBot.Services
{
    public class ConfigService
    {
        public static Config Config { get; set; }

        public ConfigService() { }

        public ConfigService(Config config)
        {
            Config = config;
        }
    }
}
