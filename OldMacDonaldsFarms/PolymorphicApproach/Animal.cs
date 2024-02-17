using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonaldsFarms.PolymorphicApproach
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public abstract void SingVerse();

    }
}
