using System;

namespace AbstractFactory
{
    class SchweppesFactory : AbstractFactory
    {
        public override AbstractWater CreateWater() => new SchweppesWater();

        public override AbstractBottle CreateBottle() => new SchweppesBottle();

        public override AbstractCap CreateCap() => new SchweppesCap();

        public override AbstractLabel CreateLabel() => new SchweppesLabel();
    }
}
