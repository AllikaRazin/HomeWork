using System;

namespace AbstractFactory
{
    class FantaBottle : AbstractBottle
    {
        public override string NameOfBottle => "Fanta Bottle";

        public override void Interact(AbstractWater water, AbstractCap cap, AbstractLabel label)
        {
            Console.WriteLine(NameOfBottle + " created with " + water.ShowNameWater + " " + cap.NameOfCap + " " + label.ShowNameLable);
        }
    }
}
