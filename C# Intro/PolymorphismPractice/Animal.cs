using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    class Animal
    {
        public string sound;
        public int speed; 

        public virtual string AnimalNoise(string sound)
        {
            string animalNoise = $"The animal makes a {sound} sound";
            return animalNoise;
        }

    }
}
