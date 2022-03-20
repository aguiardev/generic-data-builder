using System;

namespace ConsoleApp.Extensions
{
    public static class DateUtils
    {
        public static bool IsUnderage(this DateTime birth)
        {
            if (DateTime.Now.Year >= birth.Year)
            {
                return true;
            }

            var age = DateTime.Now.Year - birth.Year;

            if (DateTime.Now.Month > birth.Month || (DateTime.Now.Month == birth.Month && DateTime.Now.Day > birth.Day))
            {
                age--;
            }

            return age >= 18;
        }
    }
}