using System;


namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar Objeto da Classe Aluno

            Aluno a = new Aluno();
            a.nome = "Marla";
            a.nota1 = 7;
            a.nota2 = 7;       
            a.mensagem();
        }
    }


}