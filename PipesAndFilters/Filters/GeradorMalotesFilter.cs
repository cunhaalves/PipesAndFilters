using PipesAndFilters.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Filters
{
    public class GeradorMalotesFilter : BaseFilter<Polo>
    {
        public override Polo Execute(Polo polo)
        {
            foreach (var escola in polo.Escolas)
            {
                var malote = new Malote() { Id = Guid.NewGuid(), Escola = escola, SequencialNaEscola = 1 };
                escola.Malotes.Add(malote);

                foreach (var turma in escola.Turmas)
                {
                    foreach (var pacote in turma.Pacotes)
                    {
                        pacote.Malote = malote;
                    }
                }
            }

            return polo;
        }
    }
}
