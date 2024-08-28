using System;

class Pessoa
{

    //Construtor : Todo construtor é publico, pode ter vários construtores desde que tenham parametros diferentes, a partir do momento que eu instancio um objeto ele é executado.

    public Pessoa()
    {
        Console.WriteLine("Construtor executado");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Olá" + nome);
    }
}