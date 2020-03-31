using System;

namespace AbstractFactory
{
    class CocaColaBottle : AbstractBottle
    {
        public override string NameOfBottle => "CocaCola bottle";

        public override void Interact(AbstractWater water, AbstractCap cap, AbstractLabel label)
        {
            Console.WriteLine(NameOfBottle + " created with " + water.ShowNameWater + " " + cap.NameOfCap + " " + label.ShowNameLable);
        }
    }
}
