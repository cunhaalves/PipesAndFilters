using PipesAndFilters.Domain;
using PipesAndFilters.Filters;
using PipesAndFilters.Pipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PipesAndFilters.Pipeline
{
    public class ConcretePoloPipeline : BasePipeline<Polo>
    {
        public override Polo Process(Polo polo)
        {
            Random r = new Random();
            Thread.Sleep(r.Next(100, 500));

            foreach (var filter in filters)
                polo = filter.Execute(polo);

            return polo;
        }
    }
}
