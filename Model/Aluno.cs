using System;
using System.Collections.Generic;
using System.Data.Entity Namespace;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;

namespace Model
{
    public class Aluno
    {
        public static void Adicionar(String nome, String telefone)
        {

            Alunos a = new Alunos();
            a.Nome = nome;
            a.Telefone = telefone;

            Model1Container contexto = new Model1Container();
            contexto.AlunosSet.Add(a);
            contexto.SaveChanges();
        }

        public static void Atualizar(int id_aluno, String nome, String telefone)
        {

            Model1Container contexto = new Model1Container();
            Alunos a = contexto.AlunosSet.Find(id_aluno);
            a.Nome = nome;
            a.Telefone = telefone;
            contexto.AlunosSet.Attach(a);
            contexto.Entry(a).State = EntityState.Modified;
            contexto.SaveChanges();

        }

        public static List<Alunos> Listar()
        {

            Model1Container contexto = new Model1Container();
            return contexto.AlunosSet.ToList();

        }

        public static void Excluir(int id_aluno)
        {
            Alunos a = new Alunos() { Id = id_aluno };
            Model1Container contexto = new Model1Container();
            contexto.AlunosSet.Attach(a);
            contexto.AlunosSet.Remove(a);
            contexto.SaveChanges();
        }

        public static Alunos get(int id_aluno)
        {
            Model1Container contexto = new Model1Container();
            Alunos a = contexto.AlunosSet.Find(id_aluno);
            return a;

        }

    }
}
