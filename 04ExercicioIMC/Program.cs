using System;


namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar Objeto da Classe Aluno

            Pessoa p = new Pessoa();
            p.nome = "Marla Amoury Silva";
            p.peso = 64;
            p.altura=1.61;  
            p.mensagem();
        }
    }


}