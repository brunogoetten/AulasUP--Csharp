using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = CadastrarAluno();

            //            a.Nome = "Godofredo";   //set
            //            a.Matricula = 123; //set

            ImprimirCadastro(a);

            Console.ReadKey();
        }

        private static void ImprimirCadastro(Aluno a)
        {
            Console.WriteLine("Aluno: " + a.Nome);
            Console.WriteLine("Matricula: " + a.Matricula);
        }

        private static Aluno CadastrarAluno()
        {
            Aluno a = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.Write("Digite o número da matricula: ");
            a.Matricula = int.Parse(Console.ReadLine());
            return a;
        }
    }
}
