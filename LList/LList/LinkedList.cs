using System;
using System.Collections;
using System.Collections.Generic;

namespace LList
{
    class LinkedList<T> : ICollection, ICollection<T>, IEnumerable, IEnumerable<T>
    {
        private LinkedListNode<T> First { get; set; }
        private LinkedListNode<T> Last { get; set; }
        private int count = 0;
        public int Count => count;
        public bool IsReadOnly => false;
        public void AddAfter(T item, uint index)
        {
            LinkedListNode<T> temp = First;

            int i = 0;
            while (i != index && temp.Next != null)
            {
                temp = temp.Next;
                i++;
            }

            if (i == count - 1)
                AddLast(item);
            else
            {
                LinkedListNode<T> AddItem = new LinkedListNode<T>(this);
                AddItem.Value = item;

                temp.Next.Previous = AddItem;
                AddItem.Next = temp.Next;
                temp.Next = AddItem;
                AddItem.Previous = temp;
            }
            count++;
        }
        public void AddBefore(T item, uint index)
        {
            LinkedListNode<T> temp = First;

            int i = 0;
            while (i != index && temp.Next != null)
            {
                temp = temp.Next;
                i++;
            }

            if (i == 0)
                AddFirst(item);
            else
            {
                LinkedListNode<T> AddItem = new LinkedListNode<T>(this);
                AddItem.Value = item;

                temp.Previous.Next = AddItem;
                AddItem.Previous = temp.Previous;
                temp.Previous = AddItem;
                AddItem.Next = temp;
            }
            count++;
        }
        public void AddFirst(T item)
        {
            LinkedListNode<T> AddItem = new LinkedListNode<T>(this);
            AddItem.Value = item;

            First.Previous = AddItem;
            AddItem.Next = First;
            First = AddItem;
            count++;
        }
        public void AddLast(T item)
        {
            LinkedListNode<T> AddItem = new LinkedListNode<T>(this);
            AddItem.Value = item;

            Last.Next = AddItem;
            AddItem.Previous = Last;
            Last = AddItem;
            count++;
        }
        public void RemoveFirst()
        {
            First.Next.Previous = null;
            First = First.Next;
            count--;
        }
        public void RemoveLast()
        {
            Last.Previous.Next = null;
            Last = Last.Previous;
            count--;
        }
        public LinkedListNode<T> Find(T item)
        {
            LinkedListNode<T> temp = First;
            while (temp.Next != null)
            {
                if (temp.Value.Equals(item))
                    return temp;
                temp = temp.Next;
            }
            if (temp.Value.Equals(item))
                return temp;
            return null;
        }
        public LinkedListNode<T> FindLast(T item)
        {
            LinkedListNode<T> temp = Last;
            while (temp.Previous != null)
            {
                if (temp.Value.Equals(item))
                    return temp;
                temp = temp.Previous;
            }
            return null;

        }
        public void CopyTo(Array array, int index)
        {
            T[] temp = new T[array.Length];
            CopyTo(temp, index);
            temp.CopyTo(array, 0);
        }
        public IEnumerator GetEnumerator()
        {
            return new LinkedListEnumerator(this);
        }
        public void Add(T item)
        {
            LinkedListNode<T> temp = new LinkedListNode<T>(this);
            temp.Value = item;

            if (count == 0)
            {
                First = temp;
                Last = temp;
            }
            else if (count == 1)
            {
                Last = temp;
                First.Next = Last;
                Last.Previous = First;
            }
            else
            {
                Last.Next = temp;
                temp.Previous = Last;
                Last = temp;
            }
            count++;
        }
        public void Clear()
        {
            First = default;
            Last = default;
            count = 0;
        }
        public bool Contains(T item)
        {
            LinkedListNode<T> temp = First;
            while (temp.Next != null)
            {
                if (temp.Value.Equals(item))
                    return true;
                temp = temp.Next;
            }
            return false;
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> temp = First;
            for (int i = arrayIndex; i < count; i++)
            {
                array[i] = First.Value;
                if (temp.Next == null)
                    break;
                temp = temp.Next;
            }
        }
        public bool Remove(T item)
        {
            LinkedListNode<T> temp = First;
            while (temp.Next != null)
            {
                if (temp.Value.Equals(item))
                {
                    if (temp.Previous == null)
                    {
                        First = temp.Next;
                        temp.Next.Previous = null;
                    }
                    else if (temp.Next == null)
                    {
                        Last = temp.Previous;
                        temp.Previous.Next = null;
                    }
                    else
                        temp.Previous.Next = temp.Next;
                    count--;
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }
        public object SyncRoot { get; }
        public bool IsSynchronized => false;
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new LinkedListEnumerator(this);
        }
        private class LinkedListEnumerator : IEnumerator<T>
        {
            public T Current => CurrentNode.Value;
            private LinkedListNode<T> CurrentNode;
            private readonly LinkedList<T> list;
            public LinkedListEnumerator(LinkedList<T> list)
            {
                this.list = list;
                Reset();
            }
            object IEnumerator.Current => Current;
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
            public bool MoveNext()
            {
                if (CurrentNode.Next != null)
                {
                    CurrentNode = CurrentNode.Next;
                    return true;
                }
                return false;
            }
            public void Reset()
            {
                CurrentNode = list.First;
            }
        }
    }
}
