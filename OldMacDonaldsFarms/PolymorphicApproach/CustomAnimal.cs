using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonaldsFarms.PolymorphicApproach
{
    class CustomAnimal : Animal
    {
        public override void SingVerse()
        {
            Console.WriteLine($"Old MacDonald had a farm, E-I-E-I-O,");
            Console.WriteLine($"And on his farm he had a {Name}, E-I-E-I-O,");
            Console.WriteLine($"With a {Sound} {Sound} here and a {Sound} {Sound} there,");
            Console.WriteLine($"Here a {Sound}, there a {Sound}, everywhere a {Sound} {Sound},");
            Console.WriteLine($"Old MacDonald had a farm, E-I-E-I-O.\n");
        }
    }
}
