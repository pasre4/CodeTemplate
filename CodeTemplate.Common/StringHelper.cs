namespace System
{
    public static class StringHelper
    {
        public static bool IsNullOrEmpty(this String msg)
        {
            return string.IsNullOrEmpty(msg);
        }

        public static bool IsNullOrWhiteSpace(this String msg)
        {
            return string.IsNullOrWhiteSpace(msg);
        }
    }
}