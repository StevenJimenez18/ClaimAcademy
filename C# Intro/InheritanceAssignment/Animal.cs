using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Animal
    {
        public string color;
        public bool isMale;
        public string food;
        public string habitat;
    
        public string FavoriteFood(string Food)
        {
            string favFood = $"your animals favorite food is {food}.";
            return favFood;
        }

        public string Habitat(string Habitat)
        {
            string habitat = $"your animals habitat is a {Habitat}.";
            return habitat;
        }
    }
}
