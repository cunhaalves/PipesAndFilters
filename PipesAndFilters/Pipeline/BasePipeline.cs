using PipesAndFilters.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Pipeline
{

    public abstract class BasePipeline<T>
    {
        
        protected readonly List<BaseFilter<T>> filters = new List<BaseFilter<T>>();

        public BasePipeline<T> Register(BaseFilter<T> filter)
        {
            filters.Add(filter);
            return this;
        }

        public abstract void Process(IEnumerable<T> input);
    }
}
