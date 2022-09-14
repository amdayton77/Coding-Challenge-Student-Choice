using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRYFusion
{
    internal class Weather :SpreadClass 
    {
        public Weather(string filePath) : base(filePath,0,1,2)
        {
           
        }
    }
}
