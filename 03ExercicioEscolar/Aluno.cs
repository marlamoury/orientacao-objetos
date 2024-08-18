using System;

class Aluno
{
    //Atributos
    public string? nome;
    public double nota1, nota2;

    //Método de Média

    public double media()
    {
        return (nota1+nota2)/2;
    }

    //Método de Situação
    public string situacao(double media)
    {
        //Condição ternária, condição ? se sim : se não
        return media >= 7 ? "Aprovado" : "Reprovado";
    }

    //Método de Mensagem
    public void mensagem()
    {
        //Obter a média
        double obterMedia = media();

        //Obter a situação
        string obterSituacao = situacao(obterMedia);

        //Mensagem
        Console.WriteLine("O Aluno "+ nome + " está: "+ obterSituacao + ". Com média: " + obterMedia);
    }

}