using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    internal class Building
    {
        public string BuildingName1 { get; set; }
        public string BuildingName2 { get; set; }
        public string BuildingName3 { get; set; }


        public int RoomArea1 { get; set; }
        public int RoomArea2 { get; set; }
        public int RoomArea3 { get; set; }


        public int NumberAnimals1 { get; set; }
        public int NumberAnimals2 { get; set; }
        public int NumberAnimals3 { get; set; }

        public void NumberAnimalss()
        {


            List<string> Buildings = new List<string>() { "Кони", "Коровы", "Свиньи\n" };

            foreach (var building in Buildings)
            {
                Console.WriteLine($" В зданиях для животных живут - {building} ");
            }
        }
    }
}
