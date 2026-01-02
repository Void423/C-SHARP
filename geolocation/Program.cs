using System;

namespace GeoLocation
{
   public class Region
   {
      public static void Main(string[] args)
      {
      string[] state = ["Russia","Indonesia", "China", "Japan", "South Korea"];
      // Data populasi per region (CUMA kota > 1 juta, sorted dari besar ke kecil)
        int[] RussiaLocation = [37400000, 28500000, 25500000, 21500000, 20900000, 
                                 19600000, 18800000, 17400000, 16800000, 15400000,
                                 14300000, 13900000, 13200000, 12800000, 12100000,
                                 11500000, 11200000, 10800000, 10500000, 10200000,
                                 9800000, 9500000, 9200000, 8900000, 8600000,
                                 8300000, 8000000, 7700000, 7400000, 7100000,
                                 6800000, 6500000, 6200000, 5900000, 5600000,
                                 5300000, 5000000, 4700000, 4400000, 4100000,
                                 3800000, 3500000, 3200000, 2900000, 2600000,
                                 2300000, 2000000, 1700000, 1400000, 1100000];
                                 // ↑ SEMUA > 1 juta (1,000,000)

        int[] IndonesiaLocation = [13200000, 12500000, 11900000, 10900000, 10500000,
                                   9700000, 8900000, 8600000, 8100000, 7800000,
                                   7400000, 7100000, 6800000, 6500000, 6200000,
                                   5900000, 5600000, 5300000, 5000000, 4700000,
                                   4400000, 4100000, 3800000, 3500000, 3200000,
                                   2900000, 2600000, 2300000, 2000000, 1700000,
                                   1400000, 1200000, 1050000];
                                   // ↑ SEMUA > 1 juta

        int[] ChinaLocation = [21000000, 15200000, 13500000, 11200000, 9500000,
                                   8800000, 7300000, 6200000, 5400000, 4900000,
                                   4300000, 3800000, 3400000, 3000000, 2700000,
                                   2400000, 2100000, 1900000, 1700000, 1500000,
                                   1300000, 1100000];
                                   // ↑ Cuma 22 kota (< 25), semua > 1 juta

         Console.WriteLine("");
         Console.WriteLine("=========== GEO LOCATION ===========");

         foreach (string cities in city)
         {
            int[] cityLocation = GetPopulationByRegion(state, RussiaLocation, IndonesiaLocation, ChinaLocation);
            int totalPopulation = 0;
            int counter = 0;

            foreach (var population in cityLocation)
            {
               counter++;
               if (counter <= 25)
               {
                  totalPopulation += population;
               } else
               {
                  break;
               }
            }
            Console.WriteLine($"Region{cities, -20} : {totalPopulation:No}");
         }


      }
      
   }
}