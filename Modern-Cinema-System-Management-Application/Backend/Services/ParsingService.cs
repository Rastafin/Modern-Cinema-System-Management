using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    public static class ParsingService
    {
        public static string ParseStartTime(string startTime)
        {
            if(!string.IsNullOrEmpty(startTime) && startTime.Length >= 16)
            {
                return startTime.Substring(11, 5);
            }

            return startTime;
        }

        public static string ParseStartDate(string startTime)
        {
            if (!string.IsNullOrEmpty(startTime) && startTime.Length >= 10)
            {
                return startTime.Substring(0, 10);
            }

            return startTime;
        }
    }
}
