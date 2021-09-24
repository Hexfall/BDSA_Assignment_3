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

        public static (string, int) WizardsFromProperty(string property)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<Dictionary<string, IEnumerable<Wizard>>> WizardsByCreators()
        {
            throw new NotImplementedException();
        }
    }
}
