using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    class OfficePcFactory : IPcFactory
    {
        public Box CreatedBox() => new ARTLINE_Business_B27();

        public Hdd CreatedHdd() => new HddBleaz1000();

        public MainBoard CreatedMainBoard() => new MotherALC887();

        public Memory CreatedMemory() => new DDR4PowerDrop();

        public Processor CreatedProcessor() => new IntelUHD630();
    }
}
