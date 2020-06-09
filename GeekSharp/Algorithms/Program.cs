using System;
using AnalysisOfAlgorithm;

namespace Algorithms
{
    /*
      dotnet new console -o Algorithms
      Code . 
      Open Terminal
      dotnet run --project Algorithms
    */

    class Program
    {
        static void Main(string[] args)
        {
            var  sumalg = new SumFirstNNaturalNumbers();
            Console.WriteLine("Algorithm 1 result:{0}", sumalg.fun1(3));
        }
        
    }
}
