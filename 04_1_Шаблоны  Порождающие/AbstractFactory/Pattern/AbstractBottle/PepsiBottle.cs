using System;

namespace AbstractFactory
{
    class PepsiBottle : AbstractBottle
    {
        public override string NameOfBottle => "Pepsi bottle";

        public override void Interact(AbstractWater water, AbstractCap cap, AbstractLabel label)
        {
            Console.WriteLine(NameOfBottle + " created with " + water.ShowNameWater + " " + cap.NameOfCap + " " + label.ShowNameLable);
        }
    }
}
