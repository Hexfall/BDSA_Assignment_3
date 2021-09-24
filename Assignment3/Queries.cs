using System;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2020.Assignment03
{
    public class Queries
    {
        public static IEnumerable<string> WizardsByAuthor(string author)
        {
            return from w in Wizard.Wizards.Value
                   where w.Creator.Trim().ToLower() == author.Trim().ToLower()
                   select w.Name;
        }

        public static int FirstAppearanceOfSith()
        {
            return (int)(from w in Wizard.Wizards.Value
                         where w.Name.Trim().ToLower().StartsWith("darth")
                         orderby w.Year
                         select w.Year).FirstOrDefault();
        }

        public static HashSet<(string, int)> WizardsFromProperty(string property)
        {
            return new HashSet<(string, int)>(from w in Wizard.Wizards.Value
                                              where w.Medium.ToLower().Contains(property.ToLower())
                                              select (w.Name, (int)w.Year));
        }

        public static IEnumerable<(string, IEnumerable<string>)> WizardsByCreators()
        {
            return (from w in Wizard.Wizards.Value
                    group w.Name by w.Creator into g
                    select g).Select(o => (o.Key, o.Select(el => el)));

        }
    }
}
