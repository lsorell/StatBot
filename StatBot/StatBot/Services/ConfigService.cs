using System;
using System.Collections.Generic;
using System.Text;

namespace StatBot.Services
{
    public class ConfigService : IServiceProvider
    {
        public Config Config { get; set; }

        public ConfigService(Config config)
        {
            Config = config;
        }

        public object GetService(Type serviceType)
        {
            return this;
        }
    }
}
