using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace STATICCLASS
{
    public static class StringUtility
    {
        public static string Reverse(string input)
        {
            if(string.IsNullOrEmpty(input))
                return input;
            return new string(input);
        }
    }
    public static class Details {
        public static int Sno;
        public static string FirstName;
        public static string LastName;
        public static string City;
     public static string FullDetails()
        {
            return FirstName + " " + LastName;
        }
       
    }
}
