using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Aircraf
    {
        ArrayList components = new ArrayList();

        public void Add(object part) => components.Add(part);
    }
}
