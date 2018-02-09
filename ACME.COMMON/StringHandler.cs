using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACME.COMMON
{
    public static class StringHandler
    {
        /*
        /// <summary>
        /// Singeltone
        /// </summary>
        private static StringHandler _instance;

        private StringHandler() { }

        /// <summary>
        /// Get instanse of StringHandler
        /// </summary>
        /// <returns></returns>
        public static StringHandler GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StringHandler();
            }

            return _instance;
        }
        */

        /// <summary>
        /// Capitalise first letter. 
        /// The rest of the name will be in lower case. 
        /// Trim extra spaces (start/end).
        /// </summary>
        /// <returns></returns>
        public static string CapitaliseFirstLetter(string name)
        {
            return name.Trim().First().ToString().ToUpper() + name.Trim().ToLower().Substring(1);
        }
    }
}
