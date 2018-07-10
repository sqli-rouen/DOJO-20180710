using System;
using System.Collections.Generic;

namespace SQLI.KataNumbersInWords
{
    public class KataNumbers
    {
        static Dictionary<string,string> _conversionTable = new Dictionary<string, string>()
        { 
            { "1", "One"},
            { "12", "Twelve"} 
        };

        public static string ToWords(string number)
        {
            if(number == default(string)){
                return string.Empty;
            }

            _conversionTable.TryGetValue(number, out string result);
            return result;
        }
    }
}
