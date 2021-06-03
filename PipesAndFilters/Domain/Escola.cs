using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Domain
{
    public class Escola
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<Turma> Turmas { get; set; }
        public List<Malote> Malotes = new List<Malote>();
    }
}
