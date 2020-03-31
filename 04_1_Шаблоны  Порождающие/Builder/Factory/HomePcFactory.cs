using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    class HomePcFactory : IPcFactory
    {
        public Box CreatedBox() => new Thermaltake_View_71_TG_1250W_80_Gold();

        public Hdd CreatedHdd() => new HddPowerDeluxe4tb();

        public MainBoard CreatedMainBoard() =>  new AMDX570();

        public Memory CreatedMemory() => new DDR4Predator();

        public Processor CreatedProcessor() => new AMDRyzen();
    }
}
