using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    class Thermaltake_View_71_TG_1250W_80_Gold : Box
    {
        public override string ModelBox => "Thermaltake View 71 TG 1250W 80+ Gold";

        public override string Colour => "Red";

        public override int Cost => 148;
    }
}
