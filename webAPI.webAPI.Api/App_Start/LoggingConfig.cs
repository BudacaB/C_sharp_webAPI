using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CorrelatorSharp.Logging;

namespace webAPI.webAPI.Api
{
    public class LoggingConfig
    {
        public static void Register()
        {
            LoggingConfiguration.Current.UseNLog();
        }
    }
}