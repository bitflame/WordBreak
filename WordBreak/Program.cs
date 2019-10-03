using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "goodtecher";
            String[] currentDict = { "good", "techer" };
            Console.WriteLine("My result:   {0}", WordBreakFinder(s, currentDict));
            Console.ReadLine();
        }
        private static bool WordBreakFinder(String s, IList<String> wordDict)
        {
            Boolean[] isWordBreak = new Boolean[s.Length + 1];

            isWordBreak[0] = true;

            for (int i = 0; i < s.Length + 1; i++)
            {
                for (int j = 0; j < i ; j++)
                {
                    if (!isWordBreak[j])
                    {
                        continue;
                    }
                    if (wordDict.Contains(s.Substring(j, i-j)))
                    {
                        isWordBreak[i] = true;
                        break;
                    }
                    }
            }
            return isWordBreak[s.Length];
        }
    }
}
