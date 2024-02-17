using OldMacDonaldsFarms.Data_DrivenApproach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonaldsFarms.PolymorphicApproach
{
    public class Polymorphic
    {
        public static void RunPolymorphicApproach()
        {
            Console.WriteLine("Running Polymorphic approach...");

            Console.WriteLine();
            PolymorphicAnimalMenu menu = new PolymorphicAnimalMenu();
            menu.ShowAnimalsMenu();
        }
    }
}
