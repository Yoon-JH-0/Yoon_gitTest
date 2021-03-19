using System;

namespace Middle
{
    class Program
    {
        static void Main(string[] args)
        {
            Scores MyScores = new Scores(1);

            MyScores.Input();
            MyScores.Sort(1);
            MyScores.Output();
        }
    }
}
