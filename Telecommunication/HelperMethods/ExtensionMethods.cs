using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Telecommunication.HelperMethods
{
    public static class ExtensionMethods
    {
        //get a valid country code from a phoneNumber
        public static string CountryCode(this string phoneNumber)
        {
            string number = "+" + phoneNumber;
            PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance();
            try
            {
                PhoneNumber numberFormat = phoneUtil.Parse(number, "");
                string countryCode = numberFormat.CountryCode.ToString();
                return countryCode;
            }
            catch (NumberParseException e)
            {
                throw new Exception("NumberParseException was thrown: " + e.ToString());
            }
        }
    }
}
