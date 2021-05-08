using System;
using System.IO;

namespace StringLengthTest
{
    public class Tester
    {
        private ITask _task;
        private string _path;

        public Tester(ITask task, string path)
        {
            _task = task;
            _path = path;
        }

        public void RunTests()
        {
            int nr = 0;
            while (true)
            {
                string inFile = $"{_path}\\test.{nr}.in";
                string outFile = $"{_path}\\test.{nr}.out";

                if (!File.Exists(inFile) || !File.Exists(outFile))
                {
                    break;
                }

                bool result = RunTest(inFile, outFile);

                Console.WriteLine($"Test #{nr} - " + result);
                nr++;
            }
        }

        private bool RunTest(string inFile, string outFile)
        {
            try
            {
                string[] data = File.ReadAllLines(inFile);
                string expect = File.ReadAllText(outFile).Trim();
                string actual = _task.Run(data);

                return actual == expect;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}