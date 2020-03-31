using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class BurstingBullet : IBullet
    {
        public BurstingBullet() => Console.WriteLine("BurstingBullet");
    }
}
