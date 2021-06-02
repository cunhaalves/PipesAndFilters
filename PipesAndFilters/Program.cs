using PipesAndFilters.Filters;
using PipesAndFilters.Pipeline;
using PipesAndFilters.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            var polos = ObterDadosParaGeracao.ObterPolos();

            ConcretePoloPipeline pipeline = new ConcretePoloPipeline();
            
            pipeline.Register(new GeradorEtiquetasFilter());
            pipeline.Register(new GeradorMalotesFilter());
            pipeline.Register(new GeradorCDLFilter());

            pipeline.Process(polos);
            
        }
    }
}
