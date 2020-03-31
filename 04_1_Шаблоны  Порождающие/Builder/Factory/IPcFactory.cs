using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    interface IPcFactory
    {
        Box CreatedBox();
        Hdd CreatedHdd();
        MainBoard CreatedMainBoard();
        Memory CreatedMemory();
        Processor CreatedProcessor();
    }
}
