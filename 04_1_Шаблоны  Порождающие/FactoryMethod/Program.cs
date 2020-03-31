using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreator creator = new CreatorBullet();

            Gun m16 = new M16(creator.CreateBullet(new OrdinaryBullet()));
        }
    }
}
