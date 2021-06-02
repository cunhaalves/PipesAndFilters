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

        private ConcretePoloPipe _pipeInicial = new ConcretePoloPipe();
        private ConcretePoloPipe _pipeEtiquetaMalote = new ConcretePoloPipe();
        private ConcretePoloPipe _pipeMaloteCDL = new ConcretePoloPipe();
        private ConcretePoloPipe _pipeCDLSink = new ConcretePoloPipe();

        public override void Process(IEnumerable<Polo> polos)
        {
            EnqueuePipeInicial(polos);
            ProcessPipe();           
        }

        private void EnqueuePipeInicial(IEnumerable<Polo> polos)
        {
            foreach (var polo in polos)
                _pipeInicial.DataToProcess.Enqueue(polo);
        }

        private void ProcessPipe()
        {
            while (_pipeInicial.DataToProcess.Count > 0)
            {
                var polo = _pipeInicial.DataToProcess.Dequeue();
                
                GeradorEtiquetasFilter etiquetas = new GeradorEtiquetasFilter();

                Task<Polo> task = Task<Polo>.Factory.StartNew(() => etiquetas.Execute(polo));
                
                _pipeEtiquetaMalote.DataToProcess.Enqueue(task.Result);

            }
        }

    }
}
