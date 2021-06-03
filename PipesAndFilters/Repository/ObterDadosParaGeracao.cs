using PipesAndFilters.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesAndFilters.Repository
{
    public static class ObterDadosParaGeracao
    {
        public static List<Polo> ObterPolos()
        {
            var polos = new List<Polo>();
            
            //Polo 1
            var polo1 = new Polo { Id = Guid.NewGuid(), Nome = "Polo 1", Escolas = new List<Escola>() };
            var escola1 = new Escola { Id = Guid.NewGuid(), Nome = "Escola 1", Turmas = new List<Turma>() };
            var turma1 = new Turma { Id = Guid.NewGuid(), Nome = "Turma 1" };
            var turma2 = new Turma { Id = Guid.NewGuid(), Nome = "Turma 2" };

            escola1.Turmas.Add(turma1);
            escola1.Turmas.Add(turma2);
            polo1.Escolas.Add(escola1);

            polos.Add(polo1);

            
            //Polo 2
            var polo2 = new Polo { Id = Guid.NewGuid(), Nome = "Polo 2", Escolas = new List<Escola>() };
            var escola2 = new Escola { Id = Guid.NewGuid(), Nome = "Escola 2", Turmas = new List<Turma>() };
            var turma3 = new Turma { Id = Guid.NewGuid(), Nome = "Turma 3" };
            var turma4 = new Turma { Id = Guid.NewGuid(), Nome = "Turma 4" };

            escola2.Turmas.Add(turma3);
            escola2.Turmas.Add(turma4);
            polo2.Escolas.Add(escola2);

            polos.Add(polo2);
     

            return polos;

        }
    }
}
