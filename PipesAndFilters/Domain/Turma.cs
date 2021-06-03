using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Domain
{
    public class Turma
    {
        public Guid Id
        {
            get; set;
        }
        public string Nome
        {
            get; set;
        }

        public List<Pacote> Pacotes = new List<Pacote>();
    }
}
