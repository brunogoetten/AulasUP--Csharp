﻿using System;
using Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;
namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunosController alunosController = new AlunosController();
            //Cadastrando alunos
            Aluno a = CadastrarAluno();
            alunosController.Inserir(a);
            Aluno b = CadastrarAluno();
            alunosController.Inserir(b);
            Aluno c = CadastrarAluno();
            alunosController.Inserir(c);
            foreach (Aluno aluno in alunosController.ListarTodos())
            {
                ImprimirDadosAluno(aluno);
            }


            ProfessorController professorController = new ProfessorController();
            //Cadastrando professor
            Professor d = CadastrarProfessor();
            professorController.Inserir(d);
            Professor e = CadastrarProfessor();
            professorController.Inserir(e);
            Professor f = CadastrarProfessor();
            professorController.Inserir(f);
            foreach (Professor professor in professorController.ListarTodos())
            {
                ImprimirDadosProfessor(professor);
            }

            //ImprimirDadosAluno(a);
            Console.ReadKey();
        }
        private static void ImprimirDadosAluno(Aluno a)
        {
            Console.WriteLine("Aluno: " + a.Nome);                      //get
            Console.WriteLine("Matrícula: " + a.Matricula);             //get
        }
        private static Aluno CadastrarAluno()
        {
            Aluno a = new Aluno();
            Console.Write("DIGITE O NOME DO ALUNO: ");
            a.Nome = Console.ReadLine();                                //set
            Console.Write("DIGITE O NOME DA MATRICULA DO ALUNO: ");
            a.Matricula = int.Parse(Console.ReadLine());                     //set
            return a;

            

            //ImprimirDadosProfessor(a);
            Console.ReadKey();
        }
        private static void ImprimirDadosProfessor(Professor a)
        {
            Console.WriteLine("Professor: " + a.Nome);                      //get
            Console.WriteLine("Registro: " + a.Registro);             //get
        }
        private static Professor CadastrarProfessor()
        {
            Professor a = new Professor();
            Console.Write("DIGITE O NOME DO PROFESSOR: ");
            a.Nome = Console.ReadLine();                                //set
            Console.Write("DIGITE O NOME DO REGISTRO DO PROFESSOR: ");
            a.Registro = int.Parse(Console.ReadLine());                     //set
            return a;

        }

    }
}