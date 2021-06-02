using PipesAndFilters.Pipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Filters
{
    public abstract class BaseFilter<T>
    {
        public abstract T Execute(T input);
    }
}
