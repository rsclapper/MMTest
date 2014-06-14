using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var matches = new List<Match>()
                {
                    new Match() {Number = 3, Word = "Modern"},
                    new Match() {Number = 5, Word = "Medical"}
                };
            for (int i = 1; i < 101; i++)
            {
                DoFizzBuzz(i,matches);
                
            }
            Console.ReadLine();
        }

        public class Match
        {
            public int Number { get; set; }
            public string Word { get; set; }
        }
        
        public static void DoFizzBuzz(int i, List<Match> matches )
        {
            var result = matches.Where(match => i%match.Number == 0).Aggregate("", (current, match) => current + match.Word);
            if (result == "")
            {
                result = i.ToString(CultureInfo.InvariantCulture);
            }
            Console.WriteLine(result);
        }
    }


}
