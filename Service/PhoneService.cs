using System.Text.RegularExpressions;

namespace Service
{
    public static class PhoneService
    {
        public static string RemovePhones(string message)
        {
            var rejex = new Regex(@"(\+98|0)?9\d{9}");
            var result = rejex.Replace(message, "");
            return result;
        }
    }
}