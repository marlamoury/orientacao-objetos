using System;

class Pessoa
{

//Método 01
public void apresentar()
{
    Console.WriteLine("Olá!");
}

//Método 02
public void apresentar(string nome)
{
    Console.WriteLine("Olá"+nome);
}

//Método 03
public void apresentar(string nome, int idade)
{
    Console.WriteLine("Olá! Você " + nome + " tem " + idade + " anos.");
}

}