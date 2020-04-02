using System;
using ICollection;

namespace Iterator
{
    class Program
    {
        static void Main()
        {
            UserCollection<int> elements = new UserCollection<int>();
            elements.Add(6);
            elements.Add(4);
            elements.Add(5);
            elements.Add(8);
            elements.Remove(4);
        }
    }
}
