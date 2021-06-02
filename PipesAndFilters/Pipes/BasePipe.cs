using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Pipes
{
    public abstract class BasePipe<T>
    {
        public Queue<T> DataToProcess { get; set; }

    }
}
