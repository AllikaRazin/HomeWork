using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollection
{
    class UserCollection<T> : ICollection<T>
    {
        T[] elements = new T[0];
        public void Add(T item)
        {
            var newArray = new T[elements.Length + 1];
            elements.CopyTo(newArray, 0);
            newArray[newArray.Length - 1] = item;
            elements = newArray;
        }

        public void Clear() => elements = new T[0];
        public bool Contains(T item)
        {
            foreach (var element in elements)
            {
                if (element.Equals(item))
                    return true;
            }
            return false;
        }
        public void CopyTo(T[] array, int arreyIndex) => elements.CopyTo(array, arreyIndex);

        public int Count => elements.Length;

        public bool IsReadOnly => false;

        public bool Remove(T item)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (item.Equals(elements[i]))
                {
                    for (int j = i; i < elements.Length - 1; i++)
                    {
                        elements[j] = elements[j+1];
                    }
                    Array.Resize(ref elements, elements.Length - 1);
                    return true;
                }
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)elements).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => elements.GetEnumerator();
    }
}
