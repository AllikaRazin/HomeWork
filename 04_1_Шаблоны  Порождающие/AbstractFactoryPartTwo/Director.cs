using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        Builder builder;

        public Director(Builder builder) => this.builder = builder;

        public void ConstructDeltaPlaner()
        {
            var b = (DeltaplanerBuilder)builder;
            b.CreatedCorpus();
            b.CreatedHolder();
        }
        public void ConstructPlaner()
        {
            var b = (PlanerBuilder)builder;
            b.CreatedCorpus();
            b.CreatedTail();
            b.CreatedWings();
        }
    }
}
