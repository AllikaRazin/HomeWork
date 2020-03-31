using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            PcConfigurator CreatorPc = new PcConfigurator(new Pc(), new HomePcFactory());

            PcConfigurator CreatorPc2 = new PcConfigurator(new Pc(), new OfficePcFactory());
        }
    }
}
