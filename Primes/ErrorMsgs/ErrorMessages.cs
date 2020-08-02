using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ErrorMsgs
{
    public static class ErrorMessages
    {
        public static string floatingPointsError = "The input must be a whole number without floating points";
        public static string outOfLongBoundariesError = "The input number must be between -922337203685775808 and 9223372036854775807";
        public static string badJsonFormatError = "The input format is wrong and it is not supported please check our api request object format";
        public static string noPrimePropertyError = "The input request object must contain Prime property";
    }
}
