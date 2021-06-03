using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Domain
{
    public class Cdl
    {
        public Guid Id { get; set; }

        public Polo Polo { get; set; }

        public int SequencialNoPolo { get; set; }
    }
}
