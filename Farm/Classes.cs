using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void Main()
        {
            Farm farm = new Farm();
            GardenBed gardenBed = new GardenBed();
            Program program = new Program();
            Bed bed = new Bed();
            Plants plants = new Plants();
            Building building = new Building();
            Animals animals = new Animals();

            farm.FarmName = " ''Точка G'' ";
            Console.WriteLine($"Название фермы - {farm.FarmName} \n");

            int lengthFarm = 1000;
            int widthFarm = 500;

            Console.WriteLine($"Площадь фермы - {farm.SpaceFarm(lengthFarm, widthFarm)} мк\n");
            farm.GardenBedsBuildings();
            
            bed.Bed1 = 6000;
            bed.Bed2 = 5000;
            bed.Bed3 = 30000;
            bed.Bed4 = 2000;
            int[] garden = { bed.Bed1, bed.Bed2, bed.Bed3, bed.Bed4 };
            bed.nameOfPlants();
            Console.WriteLine($"\nВсего занято {gardenBed.AreaBed(garden)} квадратных метров для грядок\n"); 

            program.GetPercent(gardenBed.AreaBed(garden), farm.SpaceFarm(lengthFarm, widthFarm));

            Console.WriteLine($" Ферма {farm.FarmName} занята на {program.GetPercent(gardenBed.AreaBed(garden), farm.SpaceFarm(lengthFarm, widthFarm))} % ");

            Console.WriteLine("\nКакую площадь новой грядки вы хотите создать в мк ?\n");

            int garden2 = int.Parse(Console.ReadLine());
         
            gardenBed.AreaBedNewGarden(gardenBed.AreaBed(garden), garden2);

            Console.WriteLine($" \nСумма площедей всех грядок составит {gardenBed.AreaBedNewGarden(gardenBed.AreaBed(garden), garden2)} мк");

            Console.WriteLine($" \nФерма {farm.FarmName} будет занята на {program.GetPercent(gardenBed.AreaBedNewGarden(gardenBed.AreaBed(garden), garden2), farm.SpaceFarm(lengthFarm, widthFarm))} % \n");

            program.Сheck(program.GetPercent(gardenBed.AreaBedNewGarden(gardenBed.AreaBed(garden), garden2), farm.SpaceFarm(lengthFarm, widthFarm)));

            gardenBed.GardenBed1 = " 1 Овес-Молокосос";
            gardenBed.GardenBed2 = " 2 Свекла - Краснощекая";
            gardenBed.GardenBed3 = " 3 Травушка - Муравушка";
            gardenBed.GardenBed4 = " 4 Клубничка - Ягодичка";


            plants.Plants1 = "Овес";
            plants.Plants2 = "Свекла";
            plants.Plants3 = "Трава";
            plants.Plants4 = "Клубника";

            plants.Season1 = "Зима";
            plants.Season1 = "Весна";
            plants.Season1 = "Лето";
            plants.Season1 = "Осень";
            plants.Season1 = "Не нуждается";

            plants.LandArea1 = 5000;
            plants.LandArea2 = 4000;
            plants.LandArea3 = 30000;
            plants.LandArea4 = 1000;


            building.BuildingName1 = "Конюшня";
            building.BuildingName1 = "Коровник";
            building.BuildingName1 = "Хлев";

            building.RoomArea1 = 300;
            building.RoomArea2 = 1000;
            building.RoomArea3 = 1500;

            building.NumberAnimals1 = 10;
            building.NumberAnimals2 = 30;
            building.NumberAnimals3 = 100;


            animals.AnimalName1 = "Конь";
            animals.AnimalName2 = "Корова";
            animals.AnimalName3 = "Свинья";

            animals.FoodProduct1 = "Конина";
            animals.FoodProduct2 = "Молоко";
            animals.FoodProduct3 = "Свинина";

            Console.WriteLine($"  На грядкe '{gardenBed.GardenBed1}' растет {plants.Plants1}, грядка занята на {program.GetPercent(plants.LandArea1, bed.Bed1)} %." +
                $"\nУкажите в мк сколько вы еще хотите засеять");
            int GetPercent1 = int.Parse(Console.ReadLine());
            Console.WriteLine($" \n Процент грядки '{gardenBed.GardenBed1}' составит {program.GetPercent((plants.LandArea1 + GetPercent1), bed.Bed1)} %");
            program.Сheck(program.GetPercent(gardenBed.AreaBedNewGarden(plants.LandArea1, GetPercent1), bed.Bed1));
            
        }
        public int GetPercent(int x, int y)
        {
            int d = (x * 100) / y;

            return d;
        }
        public int Сheck(int Percent)
        {
            if (Percent > 100)
            {
                Console.WriteLine("У вас не хватает площади, попрубуйте украсть у соседа\n");
            }
            return Percent;
        }
    }
}
