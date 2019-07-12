using System;

namespace WritingShared
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting!");
            DoStuff.setup();
            WritingShared.DoStuff.StartTest();

        }
    }
}
