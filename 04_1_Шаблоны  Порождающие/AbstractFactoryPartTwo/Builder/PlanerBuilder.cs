using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class PlanerBuilder : Builder
    {
        Aircraf aircraf = new Aircraf();
        public override Aircraf GetResult() => aircraf;

        public void CreatedCorpus() => aircraf.Add(new PlanerCorpus());
        public void CreatedTail() => aircraf.Add(new Tail());
        public void CreatedWings() => aircraf.Add(new Wings());
    }
}
