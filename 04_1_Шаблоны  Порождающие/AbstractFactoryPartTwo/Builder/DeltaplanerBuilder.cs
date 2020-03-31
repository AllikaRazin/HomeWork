using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class DeltaplanerBuilder : Builder
    {
        Aircraf aircraf = new Aircraf();
        public override Aircraf GetResult() => aircraf;

        public void CreatedCorpus() => aircraf.Add(new DeltaplanerCorpus());
        public void CreatedHolder() => aircraf.Add(new Holder());
    }
}
