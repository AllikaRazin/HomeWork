using System;

namespace AbstractFactory
{
    class PepsiFactory : AbstractFactory
    {
        public override AbstractWater CreateWater() => new PepsiWater();

        public override AbstractBottle CreateBottle() => new PepsiBottle();

        public override AbstractCap CreateCap() => new PepsiCap();

        public override AbstractLabel CreateLabel() => new PepsiLabel();
    }
}
