using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Farm
    {
        public string FarmName { get; set; }

        public int SpaceFarm(int length, int width)
        {
            int Space = length * width;

            return Space;
        }
        public void GardenBedsBuildings()
        {


            List<string> Buildings = new List<string>() { "Конюшня", "Коровник", "Хлев\n" };

            foreach (var building in Buildings)
            {
                Console.WriteLine($" Строения для животных - {building} ");
            }
        }
    }
}
