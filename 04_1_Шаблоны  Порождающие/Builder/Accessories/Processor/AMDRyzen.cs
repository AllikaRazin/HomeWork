using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    class AMDRyzen : Processor
    {
        public override string Model => "AMD Ryzen 9 3950X, 3,5-4,7";

        public override int Cost => 499;

        public override int Frequency => 4;

        public override byte Cores => 16;
    }
}
