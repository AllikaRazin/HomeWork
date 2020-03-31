using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    class AMDX570 : MainBoard
    {
        public override string Model => "AMDX 570";

        public override int Cost => 249;
    }
}
