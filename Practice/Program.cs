using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        public static List<List<string>> AnagramsFunc (string[] input)
        {
            var Recurrences = new Dictionary<string, List<string>>();
            var IndividualStrings = new List<string>();

            foreach (var SingleValue in input)
            {
                var OrderedChars = SingleValue.ToCharArray();
                Array.Sort(OrderedChars);
                var TheKey = new string(OrderedChars);
            
                if (!Recurrences.ContainsKey(TheKey))
                {
                    IndividualStrings = new List<string>();
                    IndividualStrings.Add(SingleValue);
                    Recurrences.Add(TheKey, IndividualStrings);
                    
                }
                else
                {
                    Recurrences.TryGetValue(TheKey, out IndividualStrings);
                    IndividualStrings.Add(SingleValue);
                }

            }
            var ReturnedList = new List<List<string>>();
            
            foreach (var key in Recurrences.Keys)
            {
                var SingleList = new List<string>();
                Recurrences.TryGetValue(key, out SingleList);

                if (SingleList.Count() > 1)
                {
                    ReturnedList.Add(SingleList);
                }
            }
            return ReturnedList;
        }
        static void Main(string[] args)
        {
            string[] anagram = new string[6] { "xvb", "xbv", "bvx", "yul", "luy", "kkl" };
            var X = AnagramsFunc(anagram);
        }
    }
}
