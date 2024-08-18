using System;


namespace _06Encapsulamento
{
    public class Aluno
    {
        //Atributos 
        private double nota1, nota2;

         //Metodo Média
         private double media()
         {
            return (nota1+nota2)/2;
         }

         //Mensagem
         // Método para exibir mensagens e coletar notas
        public void Mensagem()
        {
            Console.WriteLine("Informe a primeira nota:");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Const
            
            Console.WriteLine("Informe a segunda nota:");
            nota2 = Convert.ToDouble(Console.ReadLine());

            // Exibe a média
            double media = Media();
            Console.WriteLine($"A média das notas é: {media}");
        }
    }
}