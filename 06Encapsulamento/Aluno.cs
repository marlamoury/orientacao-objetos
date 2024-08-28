using System;


namespace _06Encapsulamento
{
    public class Aluno
    {
        //Encapsulamento: Evita deixar atributos de forma publica
        //Atributos 
        private double nota1, nota2;

         //Metodo Média
         private double media()
         {
            return (nota1+nota2)/2;
         }

         //Mensagem
         // Método para exibir mensagens e coletar notas
        public void mensagem()
        {
            Console.WriteLine("Informe a primeira nota:");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota:");
            nota2 = Convert.ToDouble(Console.ReadLine());

            // Exibe a média
            Console.WriteLine($"A média das notas é:"+ media());
        }
    }
}