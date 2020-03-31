using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    class IntelUHD630 : Processor
    {
        public override string Model => "Intel UHD 630";

        public override int Cost => 470;

        public override int Frequency => 3;

        public override byte Cores => 8;
    }
}
