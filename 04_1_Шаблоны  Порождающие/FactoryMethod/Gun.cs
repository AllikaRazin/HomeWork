using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Gun
    {
        public virtual string FrequencyShot { get; set; }
        public virtual string Сaliber { get; set; }

        public virtual IBullet VievBullet{ get; set; }
    }
}
