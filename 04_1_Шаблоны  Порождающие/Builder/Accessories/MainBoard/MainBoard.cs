using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    abstract class MainBoard
    {
        public abstract string Model { get; }

        public abstract int Cost { get; }

    }
}
