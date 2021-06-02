using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Domain
{
    public class Malote
    {
        public Guid Id
        {
            get; set;
        }

        public List<Pacote> Pacotes { get; set; }
    }
}
