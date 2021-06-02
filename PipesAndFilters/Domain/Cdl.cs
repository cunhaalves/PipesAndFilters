using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Domain
{
    public class Cdl
    {
        public Guid Id { get; set; }

        public List<Malote> Malotes { get; set; }
    }
}
