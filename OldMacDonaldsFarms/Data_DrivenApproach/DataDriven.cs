using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonaldsFarms.Data_DrivenApproach
{
    public class DataDriven
    {
        public static void RunDataDrivenApproach()
        {
            Console.WriteLine("Running Data-driven approach...");

            Console.WriteLine();
            AnimalsMenu menu = new AnimalsMenu();
            menu.ShowAnimalsMenu();
        }
    }
}
