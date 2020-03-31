using System;

namespace AbstractFactory
{
    class SchweppesBottle : AbstractBottle
    {
        public override string NameOfBottle => "Schweppes bottle";

        public override void Interact(AbstractWater water, AbstractCap cap, AbstractLabel label)
        {
            Console.WriteLine(NameOfBottle + " created with " + water.ShowNameWater + " " + cap.NameOfCap + " " + label.ShowNameLable);
        }
    }
}
