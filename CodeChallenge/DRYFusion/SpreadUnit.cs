using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRYFusion
{
    internal class SpreadUnit
    {
        public string UnitName { get; set; } = "No Name";

        public int Low { get; set; }

        public int High { get; set; }

        public override string ToString() => UnitName;
    }
}
