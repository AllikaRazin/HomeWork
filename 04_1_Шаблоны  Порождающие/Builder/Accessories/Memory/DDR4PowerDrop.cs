using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    class DDR4PowerDrop : Memory
    {
        public override string Model => "DDR4PowerDrop";

        public override int Cost => 349;

        public override int CountMemory => 64;

        public override int Frequency => 3200;
    }
}
