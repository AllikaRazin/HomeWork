using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    class PcConfigurator
    {
        public IPcFactory Factory { get; set; }
        public PcConfigurator(Pc pc, IPcFactory vievPc)
        {
            Factory = vievPc;
            
            pc.ConfigHdd = Factory.CreatedHdd();
            pc.ConfigMainBoard = Factory.CreatedMainBoard();
            pc.Configmemory = Factory.CreatedMemory();
            pc.ConfigProcessor = Factory.CreatedProcessor();
            pc.ConfigBox = Factory.CreatedBox();
        }
    }
}
