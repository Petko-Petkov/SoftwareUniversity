namespace AsynchronousTimer
{
    using System;

    class TimerMain
    {
        static void Main()
        {
            AsyncTimer at = new AsyncTimer(PassStringOne, 10, 1000);

            at.Begin();
        }

        public static void PassStringOne(string str)
        {
            Console.WriteLine(str);
        }
    }
}
