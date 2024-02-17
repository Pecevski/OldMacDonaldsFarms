using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OldMacDonaldsFarms.Data_DrivenApproach
{
    public class Animal
    {
        //[JsonPropertyName("name")]
        public string Name { get; set; }

        //[JsonPropertyName("sound")]
        public string Sound { get; set; }

        public void SingVerse()
        {
            Console.WriteLine($"Old MacDonald had a farm, E-I-E-I-O,");
            Console.WriteLine($"And on his farm he had a {Name}, E-I-E-I-O,");
            Console.WriteLine($"With a {Sound} {Sound} here and a {Sound} {Sound} there,");
            Console.WriteLine($"Here a {Sound}, there a {Sound}, everywhere a {Sound} {Sound},");
            Console.WriteLine($"Old MacDonald had a farm, E-I-E-I-O.\n");
        }
    }
}
