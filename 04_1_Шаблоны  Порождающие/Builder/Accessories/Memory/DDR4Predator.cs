using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    class DDR4Predator : Memory
    {
        public override string Model => "DDR4 Predator";

        public override int Cost => 189;

        public override int CountMemory => 8;

        public override int Frequency => 2400;
    }
}
