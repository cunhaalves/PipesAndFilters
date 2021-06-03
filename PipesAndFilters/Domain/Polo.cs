using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Domain
{
    public class Polo
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        
        public List<Escola> Escolas { get; set; }

        public List<Cdl> Cdls = new List<Cdl>();
    }
}
