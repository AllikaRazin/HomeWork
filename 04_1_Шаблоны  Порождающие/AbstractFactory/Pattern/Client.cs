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
            // ��������������� �������� ���������������.
            water = factory.CreateWater();
            cap = factory.CreateCap();
            label = factory.CreateLabel();
            bottle = factory.CreateBottle();
        }

        public void Run()
        {
            // ��������������� ��������� �������������.
            bottle.Interact(water, cap, label);
        }
    }
}
