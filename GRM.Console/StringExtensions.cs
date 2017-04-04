namespace GRM.Console
{
    public static class StringExtensions
    {
        public static string RemoveOrdinals(this string value)
        {
            if (value.Length > 0)
                return value.Replace("st", "")
                    .Replace("rd", "")
                    .Replace("th", "")
                    .Replace("nd", "")
                    .Replace(" ", "-");
            return value;
        }
    }
}
