using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Classes;

namespace LINQ
{
    public class Functions
    {

        /*
            Output all of the neighborhoods in this data list (Final Total: 147 neighborhoods)
            Filter out all the neighborhoods that do not have any names (Final Total: 143)
            Remove the duplicates (Final Total: 39 neighborhoods)
            Rewrite the queries from above and consolidate all into one single query.
            Rewrite at least one of these questions only using the opposing method (example: Use LINQ Query statements instead of LINQ method calls and vice versa.)

        */

        public static string path = "../../../data.json";

        public static string importedFile = File.ReadAllText(path);

        FeatureCollection featureCollection = JsonConvert.DeserializeObject<FeatureCollection>(importedFile);


        public void PrintAllNeighborhoods(FeatureCollection someCollection)
        {

            //query
            var allNeighbourhoods = from n in featureCollection.features
                                    select n.properties.neighborhood;

            foreach (var item in allNeighbourhoods)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("// ------------------------------------------------ //");
            Console.WriteLine("// ------------------------------------------------ //");

        }

        public void FilterNeighborhoodsWithNoName(FeatureCollection someCollection)
        {
            var allNeighbourhoods = from n in featureCollection.features
                                    where n.properties.neighborhood != ""
                                    select n.properties.neighborhood;

            foreach (var item in allNeighbourhoods)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("// ------------------------------------------------ //");
            Console.WriteLine("// ------------------------------------------------ //");

        }

        public void RemoveDuplicates(FeatureCollection someCollection)
        {
            var allNeighbourhoods = from n in featureCollection.features
                                    where n.properties.neighborhood != ""
                                    select n.properties.neighborhood;

            var removedDuplicates = allNeighbourhoods.Distinct();

            foreach (var item in removedDuplicates)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("// ------------------------------------------------ //");
            Console.WriteLine("// ------------------------------------------------ //");

        }

        public void MergeAllQueries(FeatureCollection someCollection)
        {
            //I dont understand this Task

            Console.WriteLine("// ------------------------------------------------ //");
            Console.WriteLine("// ------------------------------------------------ //");

        }

        public void RemoveDuplicatesUsingFunctions(FeatureCollection someCollection)
        {

            var allNeighbourhoods = featureCollection.features
                                    .Where(n => n.properties.neighborhood != "")
                                    .Select(n => n.properties.neighborhood);

            foreach (var n in allNeighbourhoods)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("// ------------------------------------------------ //");
            Console.WriteLine("// ------------------------------------------------ //");

        }

    }
}
