using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    internal class Bed
    {
        public int Bed1 { get; set; }
        public int Bed2 { get; set; }
        public int Bed3 { get; set; }
        public int Bed4 { get; set; }


        public void nameOfPlants()
        {
            var GardenBeds = new List<string>() { " 1 Овес-Молокосос", " 2 Свекла - Краснощекая", " 3 Травушка - Муравушка", " 4 Клубничка - Ягодичка\n" };

            foreach (var gardenBed in GardenBeds)
            {
                Console.WriteLine($" Назваание грядки - {gardenBed}");
            }
        }
    }
}
