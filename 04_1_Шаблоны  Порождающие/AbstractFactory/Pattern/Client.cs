using System;

namespace AbstractFactory
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;
        private AbstractLabel label;
        private AbstractCap cap;

        public Client(AbstractFactory factory)
        {
            // Абстрагирование процесса инстанцирования.
            water = factory.CreateWater();
            cap = factory.CreateCap();
            label = factory.CreateLabel();
            bottle = factory.CreateBottle();
        }

        public void Run()
        {
            // Абстрагирование вариантов использования.
            bottle.Interact(water, cap, label);
        }
    }
}
