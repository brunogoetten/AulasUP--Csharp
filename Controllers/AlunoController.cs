using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controllers
{
    public class AlunoController
    {

        public bool Inserir(String nome, String telefone)
        {

            Aluno.Adicionar(nome, telefone);

            return true;

        }

        public List<Alunos> getLista()
        {

            List<Alunos> lista = Aluno.Listar();

            return lista;

        }

        public Alunos get(int id_aluno)
        {
            Alunos a = Aluno.get(id_aluno);
            return a;
        }

        public bool excluir(int id_aluno)
        {
            Aluno.Excluir(id_aluno);
            return true;
        }

        public void atualizar(int id_aluno, String nome, String telefone)
        {
            Aluno.Atualizar(id_aluno, nome, telefone);
        }

    }
}
