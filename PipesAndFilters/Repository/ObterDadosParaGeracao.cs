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

            for (int i = 0; i < 300; i++)
            {
                //Polo 1
                var polo1 = new Polo { Id = Guid.NewGuid(), Nome = "Polo "+ i, Escolas = new List<Escola>() };
                var escola1 = new Escola { Id = Guid.NewGuid(), Nome = "Escola " + i, Turmas = new List<Turma>() };
                var turma1 = new Turma { Id = Guid.NewGuid(), Nome = "Turma " + i };
                var turma2 = new Turma { Id = Guid.NewGuid(), Nome = "Turma " + i + 1 };

                escola1.Turmas.Add(turma1);
                escola1.Turmas.Add(turma2);
                polo1.Escolas.Add(escola1);

                polos.Add(polo1);
            }

            return polos;

        }
    }
}
