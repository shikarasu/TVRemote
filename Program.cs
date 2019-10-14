using System;

namespace TVRemote
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var tv = TvRemote.GetDevice();

            var powBut = new PowerButton(tv);

            powBut.Execute();
            powBut.Undo();
        }
    }
}
