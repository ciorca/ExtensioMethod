using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensioMethod
{
    public static class StringHelper
    {
        //width "this" an "static" added to the class,became an extension Method
        public static string ChangeFirstLetterCase(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }
            return inputString;
        }
    }
}
