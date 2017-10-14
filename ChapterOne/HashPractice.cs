using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne
{
    public class HashPractice
    {
        public HashSet<string> HashSetObj { get; set; }
        public string[] array { get; set; }

        public HashPractice(string[] items)
        {
            array = items;
        }
        public void ReturnSingleItems()
        {
            HashSetObj = new HashSet<string>(array);
            Console.WriteLine(string.Join(",", HashSetObj.ToArray()));
        }
    }
}
