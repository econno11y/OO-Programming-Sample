using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageNumbers
{
    class PositiveAverageNumber : AverageNumber
    {
        public PositiveAverageNumber(List<double> doubles) 
            : base(doubles)
        {
        }

        public PositiveAverageNumber(AverageNumber number)
            : base(number)
        {
        }

        public override double GetAverage()
        {
            List<double> positives = Collection.Where(x => x >= 0).ToList();
            return positives == null ? 0 : positives.Average();
        }
    }
}
