using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using LINQ.Classes;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(importedFile);
            
            Functions functions = new Functions();

            FeatureCollection collection = new FeatureCollection();


            functions.PrintAllNeighborhoods(collection);
            functions.FilterNeighborhoodsWithNoName(collection);
            functions.RemoveDuplicates(collection);
            functions.MergeAllQueries(collection);
            functions.RemoveDuplicatesUsingFunctions(collection);
        }
    }
}
