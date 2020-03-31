using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    class HddPowerDeluxe4tb : Hdd
    {
        public override string Model => "HddPowerDeluxe4tb";

        public override int MemoryHdd => 4000;

        public override int Cost => 95;

        public override int Speed => 9300;
    }
}
