using System;

namespace StringLengthTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ITask task = new StringLengthTask();

            Tester tester = new Tester(task, @"D:\algorithms\A01_Licky_Tickets\0.String\");
            tester.RunTests();

        }
    }
}
