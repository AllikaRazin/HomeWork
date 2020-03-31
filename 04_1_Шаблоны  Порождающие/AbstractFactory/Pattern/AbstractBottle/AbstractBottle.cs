using System;

namespace AbstractFactory
{
    abstract class AbstractBottle
    {
        public abstract string NameOfBottle { get; }
        public abstract void Interact(AbstractWater water, AbstractCap cap, AbstractLabel label);
    }
}
