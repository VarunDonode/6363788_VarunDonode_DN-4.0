using System;

namespace w7__financial_forecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forecaster forecaster = new Forecaster();

            double initial = 10000;       
            double growthRate = 0.08;     
            int years = 10;

            Console.WriteLine($"Predicting with naive recursion:");
            double futureValue = forecaster.PredictFutureValue(initial, growthRate, years);
            Console.WriteLine($"Future Value after {years} years: {futureValue:F2}");

            Console.WriteLine($"\nPredicting with memoized recursion:");
            double optimizedValue = forecaster.PredictFutureValueMemo(initial, growthRate, years);
            Console.WriteLine($"Future Value after {years} years: {optimizedValue:F2}");
        }
    }
}
