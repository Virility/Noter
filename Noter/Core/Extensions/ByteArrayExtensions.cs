namespace Noter.Core.Extensions
{
    public static class ByteArrayExtensions
    {
        public static bool IsNull(this byte[] input)
        {
            return (input == null || input.Length == 0);
        }
    }
}