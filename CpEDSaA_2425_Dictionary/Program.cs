using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpEDSaA_2425_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionaries 
            // It has 2 data types
            // It does not use indexes (has a key value pair)
            // All the keys have to be unique
            // a reinsertion of the key will just overwrite the existing value
            // the keys are not sorted

            // Initialization
            // Dictionary<key DT,value DT> <vn> = new Dictionary<key DT, value DT>();
            Dictionary<int,int> book = new Dictionary<int,int>();
            // add things to dictionarys
            book.Add(1, 1);
            book[2] = 2;

            // key = int, value int[]
            // key = string, value = list<string>
            Dictionary<string, string> actualDictionary = new Dictionary<string, string>();
            actualDictionary["apple"] = "Its a fruit thats sometimes red.";
            actualDictionary["car"] = "Krizan's joke is so corny...";

            foreach(string word in actualDictionary.Keys)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Displaying the whole dictionary...");
            foreach (KeyValuePair<string, string> word in actualDictionary)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }

            Console.WriteLine("Searching for apple's definition\n" + actualDictionary["apple"]);

            Console.ReadKey();
        }
    }
}
