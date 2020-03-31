using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    abstract class Box
    {
        public abstract string ModelBox { get; }
        public abstract string Colour { get; }

        public abstract int Cost { get; }
    }
}
