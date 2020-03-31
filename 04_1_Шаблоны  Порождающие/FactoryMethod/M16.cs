using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class M16:Gun
    {
        public M16(IBullet vievBullet)
        {
            FrequencyShot = "14/sec";
            Сaliber = "12";
            VievBullet = vievBullet;
        }
    }
}
