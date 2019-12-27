using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> collection = new List<double> { 3.58, 11.8908, 2.1, 4.649, 312.7, .0789 };
            Console.WriteLine($"var collection = {GetStringFromDoubles(collection)}");
            Console.WriteLine($"\nCreating instance of AverageNumber with collection:");
            AverageNumber averageNumber = null;
            double[] range;

            try
            {
                averageNumber = new AverageNumber(collection);
                range = averageNumber.GetRange();

                Console.WriteLine("\nUsing methods in Average Number,...");
                Console.WriteLine($"\ncollection = {GetStringFromDoubles(averageNumber.GetCollection())}");
                Console.WriteLine($"average = {averageNumber.GetAverage()}");
                Console.WriteLine($"min = {range[0]}");
                Console.WriteLine($"max = {range[1]}");

                Console.WriteLine($"\nCreating copy of the current instance of AverageNumber:");
                averageNumber = new AverageNumber(averageNumber);
                range = averageNumber.GetRange();

                Console.WriteLine("\nUsing methods on the new instance of Average Number,...");
                Console.WriteLine($"\ncollection = {GetStringFromDoubles(averageNumber.GetCollection())}");
                Console.WriteLine($"average = {averageNumber.GetAverage()}");
                Console.WriteLine($"min = {range[0]}");
                Console.WriteLine($"max = {range[1]}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error attempting to create instance of average number with {GetStringFromDoubles(collection)}: {ex.Message}");
            }

            try
            {
                List<double> newValues = new List<double> { 7.82, 700.5, 1045.679, 45.39 };
                
                Console.WriteLine($"\nAdding newValues to var collection");
                Console.WriteLine($"\nvar newValues = {GetStringFromDoubles(newValues)}");
                collection.AddRange(newValues);
                range = averageNumber.GetRange();

                Console.WriteLine($"\nvar collection = {GetStringFromDoubles(collection)}");
                Console.WriteLine("\nThe collection belonging to the current instance of AverageNumber is still:");
                Console.WriteLine($"\ncollection = {GetStringFromDoubles(averageNumber.GetCollection())}");
                Console.WriteLine($"average = {averageNumber.GetAverage()}");
                Console.WriteLine($"min = {range[0]}");
                Console.WriteLine($"max = {range[1]}");

                Console.WriteLine($"\nAdding the following values to the collection using the 'AddValues' method: {GetStringFromDoubles(newValues)}");
                averageNumber.AddValues(newValues);
                range = averageNumber.GetRange();
                Console.WriteLine($"\nThe collection belonging to the current instance of AverageNumber is now: {GetStringFromDoubles(averageNumber.GetCollection())}");
                Console.WriteLine($"\ncollection = {GetStringFromDoubles(averageNumber.GetCollection())}");
                Console.WriteLine($"average = {averageNumber.GetAverage()}");
                Console.WriteLine($"min = {range[0]}");
                Console.WriteLine($"max = {range[1]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding values to the collection: {ex.Message}");
            }

            try
            {
                List<double> newCollection = new List<double> { 0, -99.999, -5.008, 8 };
                Console.WriteLine($"\nReplacing the current instance of AverageNumber with {GetStringFromDoubles(newCollection)}:");
                Console.WriteLine("Using that to create a PositiveAverageNumber");
                averageNumber.Replace(newCollection);
                averageNumber = new PositiveAverageNumber(averageNumber);
                range = averageNumber.GetRange();

                Console.WriteLine("\nUsing methods on the current instance of PositiveAverageNumber:");
                Console.WriteLine($"\ncollection = {GetStringFromDoubles(averageNumber.GetCollection())}");
                Console.WriteLine($"average = {averageNumber.GetAverage()}");
                Console.WriteLine($"min = {range[0]}");
                Console.WriteLine($"max = {range[1]}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding values to the collection: {ex.Message}");
            }
        }


        private static string GetStringFromDoubles(ICollection<double> doubles)
        {
            List<double> values = doubles.ToList<double>();
            string list = values[0].ToString();
            for (int i = 1; i < values.Count; i++)
            {
                list+= $", {values[i].ToString()}";
            }

            return list;
        }
    }
}
