using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Controllers
{
    public class ProfessorController
    {
        List<Professor> tabelaProfessor = new List<Professor>();
        public void Inserir(Professor a)
        {
            tabelaProfessor.Add(a);
        }
        public List<Professor> ListarTodos()
        {
            return tabelaProfessor;
        }

    }

}