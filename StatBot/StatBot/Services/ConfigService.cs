using System;
using System.Collections.Generic;
using System.Text;

namespace StatBot.Services
{
    public class ConfigService
    {
        private Config _config;

        public ConfigService(Config config)
        {
            _config = config;
        }
    }
}
