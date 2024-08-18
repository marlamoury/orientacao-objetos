using System;

class Pessoa
{
    public string? Nome;
    public int Idade;

    public void Mensagem()
    {
        Console.WriteLine("Ola "+Nome+" Voce tem "+Idade+" anos.");
    }

}