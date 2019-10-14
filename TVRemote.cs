namespace TVRemote
{
    static class TvRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}