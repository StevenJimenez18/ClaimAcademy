using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    class Dog : Animal
    {

        public override string AnimalNoise(string sound)
        {
            string animalNoise = $"The dog makes a {sound} sound";
            return animalNoise;
        }
    }
}
