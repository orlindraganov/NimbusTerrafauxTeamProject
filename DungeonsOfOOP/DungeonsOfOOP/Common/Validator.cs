using System;

namespace DungeonsOfOOP.Common
{
    public static class Validator
    {
        public static void ValidateIsNotNull(object obj, string paramName = "The reference")
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName, paramName + " cannot be null.");
            }
        }

        public static void ValidateStringIsNotNullOrEmpty(string str, string strName = "The string")
        {
            Validator.ValidateIsNotNull(str, strName);

            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(strName, strName + " cannot be white space.");
            }
        }
    }
}
