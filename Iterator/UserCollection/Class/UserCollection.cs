using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection
{ 
    class UserCollection<T> : IEnumerable<T>, IEnumerator<T>, IDisposable
    {
        readonly Element[] elements = new Element[4];

        public Element this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        int position = -1;

        //IEnumerator
        bool IEnumerable<T>.
    }
}
