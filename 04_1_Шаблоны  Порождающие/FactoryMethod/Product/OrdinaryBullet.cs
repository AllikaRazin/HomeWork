using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class OrdinaryBullet : IBullet
    {
        public OrdinaryBullet() => Console.WriteLine("Ordinary Bullet");
    }
}
