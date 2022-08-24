using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class GardenBed
    {
        public string GardenBed1 { get; set; }
        public string GardenBed2 { get; set; }
        public string GardenBed3 { get; set; }
        public string GardenBed4 { get; set; }


        public int AreaBed(int[] areaBed)
        {
          
            int result = areaBed.Sum();

            return result;
        }
        public int AreaBedNewGarden(int garden, int garden2)
        {
            int sumGarden = garden2 + garden;
            return sumGarden;
        }
    }
}
