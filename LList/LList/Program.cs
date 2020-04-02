using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.Add(4);
            linkedList.Add(2);
            linkedList.Add(6);
            linkedList.Add(4);
            linkedList.Add(9);

            linkedList.Find(9);
        }
    }
}
