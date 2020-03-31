using System;

namespace AbstractFactory
{
    class CocaColaFactory : AbstractFactory
    {
        public override AbstractWater CreateWater() => new CocaColaWater();

        public override AbstractBottle CreateBottle() => new CocaColaBottle();

        public override AbstractCap CreateCap() => new CocaColaCap();

        public override AbstractLabel CreateLabel() => new CocaColaLabel();
    }
}
