namespace StringLengthTest
{
    public class StringLengthTask : ITask
    {
        public string Run(string[] data)
        {
            return data[0].Length.ToString();
        }
    }
}
