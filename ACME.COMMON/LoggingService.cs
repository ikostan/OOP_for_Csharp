using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.COMMON
{
    public class LoggingService
    {
        /// <summary>
        /// Write log
        /// </summary>
        /// <param name="items"></param>
        public static void WriteLog(IEnumerable<ILoggable> items)
        {
            foreach (ILoggable item in items)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
