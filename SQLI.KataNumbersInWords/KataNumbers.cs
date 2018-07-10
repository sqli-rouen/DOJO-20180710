using System;

namespace SQLI.KataNumbersInWords
{
    public class KataNumbers
    {
        public static string ToWords(string number)
        {
            if(number == default(string)){
                return string.Empty;
            }

            if (number == "1")
                return "One";
            
            throw new NotImplementedException();
        }
    }
}
