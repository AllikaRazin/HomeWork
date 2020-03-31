using System;

namespace AbstractFactory
{
    class FantaFactory : AbstractFactory
    {
        public override AbstractWater CreateWater() => new FantaWater();

        public override AbstractBottle CreateBottle() => new FantaBottle();

        public override AbstractCap CreateCap() => new FantaCap();

        public override AbstractLabel CreateLabel() => new FantaLabel();
    }
}
