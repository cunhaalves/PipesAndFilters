using PipesAndFilters.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Filters
{
    class GeradorCDLFilter : BaseFilter<Polo>
    {
        public override Polo Execute(Polo polo)
        {
            var cdl = new Cdl() { Id = Guid.NewGuid(), Polo = polo, SequencialNoPolo = 1 };
            polo.Cdls.Add(cdl);

            foreach (var escola in polo.Escolas)
            {
                foreach (var malote in escola.Malotes)
                {
                    malote.Cdl = cdl;
                }
            }

            return polo;
        }
    }
}
