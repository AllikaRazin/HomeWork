using System.Collections;

namespace Iterator
{ 
    class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList elements = new ArrayList();
        private ConcreteIterator iterator;
        public override Iterator CreateIterator()
        {
            iterator = new ConcreteIterator(this);
            return iterator;
        }
        public int Count => elements.Count;
        public override object this[int index] 
        {
            get => elements[index];
            set => elements.Insert(index, value); 
        }
    }
}
