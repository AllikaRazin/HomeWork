using System;
using System.Collections;
using System.Collections.Generic;

namespace UserCollection
{
    class UserCollection<T> : IEnumerable<T>, IEnumerator<T>, IDisposable
    {
        T[] elements = new T[4];

        public T this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        private int position = -1;
        bool IEnumerator.MoveNext()
        {
            if (position < elements.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }
        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current => elements[position];
        T IEnumerator<T>.Current => elements[position];
        IEnumerator IEnumerable.GetEnumerator()
        { 
            while (true)
            {
                if (position < elements.Length - 1)
                {
                    position++;
                    yield return elements[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => this;
        void IDisposable.Dispose() => ((IEnumerator)this).Reset();
    }
}
