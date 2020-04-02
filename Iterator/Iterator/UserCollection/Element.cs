using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection
{
    class Element
    {
        public string Name { get; set; }
        public string Surname { get; set; }


        public Element(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
