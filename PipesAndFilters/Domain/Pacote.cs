using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Domain
{
    public class Pacote
    {
        public Guid Id
        {
            get; set;
        }

        public List<Aluno> Alunos { get; set; }
    }
}
