using PipesAndFilters.Domain;
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

            foreach (var polo in polos)
            {
                pipeline.Process(polo);
                Imprimir(polo);
            }

            Console.ReadKey();
        }

        static void Imprimir(Polo polo)
        {
            Console.WriteLine();
            Console.WriteLine("*** POLO ***");
            Console.WriteLine();
            Console.WriteLine(string.Format("Polo Id: {0} |  Polo: {1}", polo.Id, polo.Nome));
            Console.WriteLine();
            Console.WriteLine(" *** CDLs ***");
            Console.WriteLine();
            foreach (var cdl in polo.Cdls)
            {
                Console.WriteLine(string.Format("   Cdl Id: {0} |  Seq. Polo: {1}", cdl.Id, cdl.SequencialNoPolo));
            }

            Console.WriteLine();
            Console.WriteLine(" *** ESCOLAS ***");
            Console.WriteLine();
            foreach (var escola in polo.Escolas)
            {
                
                Console.WriteLine(string.Format("   Escola Id: {0} |  Escola: {1}", escola.Id, escola.Nome));
                Console.WriteLine();
                Console.WriteLine("     *** MALOTES DA ESCOLA ***");
                Console.WriteLine();
               
                foreach (var malote in escola.Malotes)
                {
                    Console.WriteLine(string.Format("       Malote Id: {0} |  Sequencial na Escola: {1} | Cdl: {2}", malote.Id, malote.SequencialNaEscola, malote.Cdl.Id));
                }

                Console.WriteLine();
                Console.WriteLine("     *** TURMAS ***");
                Console.WriteLine();

                foreach (var turma in escola.Turmas)
                {
                    Console.WriteLine();
                    Console.WriteLine(string.Format("     Turma Id: {0} |  Turma: {1}", turma.Id, turma.Nome));
                    Console.WriteLine();
                    Console.WriteLine("         *** PACOTES ***");
                    Console.WriteLine();

                    foreach (var pacote in turma.Pacotes)
                    {
                        Console.WriteLine(string.Format("         Pacote Id: {0} |  Sequencial: {1} | Malote Id: {2} | Sequencial Malote Escola: {3}", pacote.Id, pacote.SequencialNaTurma, pacote.Malote.Id, pacote.Malote.SequencialNaEscola));
                    }
                }
            }
        }
    }
}
