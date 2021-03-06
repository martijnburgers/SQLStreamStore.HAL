namespace SqlStreamStore.HAL.Resources
{
    internal static class LinkFormatter
    {
        private static string FormatLink(string baseAddress, string direction, int maxCount, long position, bool prefetch)
            => $"{baseAddress}?d={direction}&m={maxCount}&p={position}{(prefetch ? "&e=1" : string.Empty)}";

        public static string FormatForwardLink(string baseAddress, int maxCount, long position, bool prefetch)
            => FormatLink(baseAddress, "f", maxCount, position, prefetch);

        public static string FormatBackwardLink(string baseAddress, int maxCount, long position, bool prefetch)
            => FormatLink(baseAddress, "b", maxCount, position, prefetch);
    }
}