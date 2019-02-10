using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webAPI.webAPI.Api.Services
{
    public class ValuesService : IValuesService
    {
        public string[] GetValues()
        {
            return new string[] { "value1", "value2" };
        }

        public string GetValue()
        {
            return "value";
        }
    }

    public interface IValuesService
    {
        string[] GetValues();
        string GetValue();
    }
}