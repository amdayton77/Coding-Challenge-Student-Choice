using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DRYFusion
{
    internal class SpreadClass
    {
        public List<SpreadUnit> Spreads { get; set; } = new();

        public SpreadClass(string filePath, int nameCol, int highCol, int lowCol)
        {
            Regex splitSpaces = new(@"\s+");
            Regex numOnly = new(@"\d+");

            if (GetFileContents.TryGetFileLines(filePath, out var lines))
            {
                foreach (var s in lines)
                {
                    var l = splitSpaces.Split(s.Trim());

                    if (l.Length > 1 && int.TryParse(numOnly.Match(l[highCol]).Value, out int high) && int.TryParse(numOnly.Match(l[lowCol]).Value, out int low))
                    {
                        Spreads.Add(new SpreadUnit() { High = high, Low = low, UnitName = l[nameCol] });  
                    }
                }
            }
        }
    }
}
