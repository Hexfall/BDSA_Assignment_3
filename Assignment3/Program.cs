using System;
using System.Linq;

namespace BDSA2020.Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            var wiz = from w in Wizard.Wizards.Value
                      orderby w.Creator descending, w.Name descending
                      group w.Name by w.Creator into g
                      select g;
            foreach (var w in wiz)
            {
                Console.WriteLine(w.Key);
                foreach (var val in w)
                    Console.WriteLine("\t" + val);
            }
        }
    }
}
