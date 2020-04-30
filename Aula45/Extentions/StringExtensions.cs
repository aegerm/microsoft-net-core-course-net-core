namespace System
{
    public static class StringExtensions
    {
        public static string Cut(this string obj, int value)
        {
            if (obj.Length <= value)
            {
                return obj;
            }

            else
            {
                return obj.Substring(0, value) + "...";
            }
        }
    }
}