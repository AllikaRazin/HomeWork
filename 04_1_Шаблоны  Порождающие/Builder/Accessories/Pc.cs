using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    class Pc
    {
        public Box ConfigBox { get; set; }
        public Processor ConfigProcessor { get; set; }
        public Memory Configmemory { get; set; }
        public Hdd ConfigHdd { get; set; }
        public MainBoard ConfigMainBoard { get; set; }
    }
}
