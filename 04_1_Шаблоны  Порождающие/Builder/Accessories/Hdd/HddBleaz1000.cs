using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    class HddBleaz1000 : Hdd
    {
        public override int MemoryHdd => 1000;

        public override string Model => "Bleaz 1000";
        public override int Cost => 59;

        public override int Speed => 7200;
    }
}
