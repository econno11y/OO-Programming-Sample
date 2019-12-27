using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace AverageNumbers
{
    class AverageNumber
    {
        protected List<double> Collection;
        public AverageNumber(List<double> collection)
        {
            if (collection == null || collection.Count == 0)
            {
                throw new ArgumentNullException();
            }

            Collection = collection;
        }

        public AverageNumber(AverageNumber averageNumber)
        {
            Collection = averageNumber.GetCollection().ToList<double>();
        }

        public ReadOnlyCollection<double> GetCollection()
        {
            return new ReadOnlyCollection<double>(Collection);
        }

        public void Replace(List<double> newCollection)
        {
            if (newCollection == null || newCollection.Count == 0)
            {
                throw new ArgumentNullException();
            }

            Collection = newCollection;
        }

        public void AddValue(double value)
        {
            Collection.Add(value);
        }
        public void AddValues(List<double> values)
        {
            if (values == null || values.Count == 0)
            {
                throw new ArgumentNullException();
            }
            Collection.AddRange(values);
        }

        public virtual double GetAverage()
        {
            return Collection.Average();      
        }

        public double[] GetRange()
        {
            return new double[] { Collection.Min(), Collection.Max() };
        }
    }
}
