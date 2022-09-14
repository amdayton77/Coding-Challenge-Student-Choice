using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRYFusion
{
    internal static class SpreadCalculator
    {

        public static string CalculateSpreads(List<SpreadUnit> spreads) 
        {
            int lowestSpread = int.MaxValue;
            string bestSpread = "No Unit";
            foreach (var s in spreads)
            {
                               
                    var testSpread = Math.Abs(s.High - s.Low);
                    if (lowestSpread > testSpread)
                    {
                        lowestSpread = testSpread;
                        bestSpread = s.UnitName;
                    }
                
            }
            return $"{bestSpread} had the lowest difference with {lowestSpread}";
        }
    }
}
