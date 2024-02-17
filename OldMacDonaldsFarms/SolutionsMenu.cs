using OldMacDonaldsFarms.Data_DrivenApproach;
using OldMacDonaldsFarms.PolymorphicApproach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonaldsFarms
{
    class SolutionsMenu
    {
        public static void ShowMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Data-driven approach");
                Console.WriteLine("2. Polymorphic approach");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DataDriven.RunDataDrivenApproach();
                        break;
                    case "2":
                        Polymorphic.RunPolymorphicApproach();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}
