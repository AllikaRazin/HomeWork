namespace LList
{
    class LinkedListNode<T>
    {
        public LinkedList<T> List { get; }
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode<T> Previous { get; set; }
        public T Value { get; set; }
        public LinkedListNode(LinkedList<T> list)
        {
            List = list;
        }
    }
}
