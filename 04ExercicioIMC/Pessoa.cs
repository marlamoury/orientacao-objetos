using System;

public class Pessoa()
{
    //Atributos
    public string? nome;

    public double peso, altura;

    // Método Calcula IMC
    public double CalculaIMC()
    {
        return peso/(altura * altura);
    }

    public string situacaoIMC(double valorIMC)
    {
        string situacaoIMC = "";
        
        if(valorIMC < 18.5)
        {
            situacaoIMC = "Abaixo do Peso";
        }
        else if(valorIMC < 25)
        {
            situacaoIMC = "Peso Normal";
        }
        else if(valorIMC < 30)
        {
            situacaoIMC = "Acima do Peso";
        }
        else if(valorIMC < 35)
        {
            situacaoIMC = "Obesidade I";
        }
        else if(valorIMC < 40)
        {
            situacaoIMC = "Obesidade II";
        }
        else //(valorIMC >= 40)
        {
            situacaoIMC = "Obesidade III";
        }

       return  situacaoIMC; 
    }

    public void mensagem()
    {
        double valorIMC =  CalculaIMC();
       
        string resultadoIMC = this.situacaoIMC(valorIMC);

        Console.WriteLine("A Pessoa cujo nome é: " + nome + " está com o IMC no valor de: " +  Math.Round(valorIMC, 2) + "E portanto sua situação é considerada: " + resultadoIMC);

    }

}