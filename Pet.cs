using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public void Feed()
        {
            this.Hunger--;
            this.Health++;
            this.Boredom++;
        }

        public void Print()
        {
            Console.WriteLine("Pet Stats for " + this.Name);
            Console.WriteLine("---------------------------");
            // Print stats
        }
    }
}
