using System.Text.RegularExpressions;

namespace Service
{
    public static class PhoneUtils
    {
        public static string RemovePhones(string message)
        {
            var enRegex = new Regex(@"(\+98|0)?9(0|1|2|3|4|5|6|7|8|9){9}");
            var firstResult = enRegex.Replace(message, "");

            var faRegex = new Regex(@"(\+۹۸|۰)?۹(۰|۱|۲|۳|۴|۵|۶|۷|۸|۹){9}");
            var result = faRegex.Replace(firstResult, "");

            return result;
        }
    }
}