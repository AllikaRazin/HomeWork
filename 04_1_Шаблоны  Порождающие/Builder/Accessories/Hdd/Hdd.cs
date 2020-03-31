using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    abstract class Hdd
    {
        public abstract int MemoryHdd { get; }
        public abstract int Cost { get; }
        public abstract string Model { get; }
        public abstract int Speed { get; }
    }
}
