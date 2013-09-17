using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_SCORE = 100;
            int score = 33;
            float percentage = (float)score / MAX_SCORE;
            Console.WriteLine(percentage);
        }
    }
}
