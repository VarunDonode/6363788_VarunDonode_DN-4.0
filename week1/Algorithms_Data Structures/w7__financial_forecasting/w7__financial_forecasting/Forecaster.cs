using System;
using System.Collections.Generic;

namespace w7__financial_forecasting
{
    public class Forecaster
    {
        public double PredictFutureValue(double initial, double growthRate, int years)
        {
            if (years == 0)
                return initial;

            return PredictFutureValue(initial, growthRate, years - 1) * (1 + growthRate);
        }

        private Dictionary<int, double> memo = new Dictionary<int, double>();
        public double PredictFutureValueMemo(double initial, double growthRate, int years)
        {
            if (years == 0)
                return initial;

            if (memo.ContainsKey(years))
                return memo[years];

            double result = PredictFutureValueMemo(initial, growthRate, years - 1) * (1 + growthRate);
            memo[years] = result;
            return result;
        }
    }
}
