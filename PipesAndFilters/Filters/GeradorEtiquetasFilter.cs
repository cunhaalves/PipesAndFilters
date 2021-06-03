using PipesAndFilters.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Filters
{
    public class GeradorEtiquetasFilter : BaseFilter<Polo>
    {
        public override Polo Execute(Polo polo)
        {
            foreach (var escola in polo.Escolas)
            {
                foreach (var turma in escola.Turmas)
                {
                    turma.Pacotes.Add(new Pacote { Id = Guid.NewGuid(), SequencialNaTurma = 1 });
                    turma.Pacotes.Add(new Pacote { Id = Guid.NewGuid(), SequencialNaTurma = 2 });
                }
            }

            return polo;
        }
    }
}
