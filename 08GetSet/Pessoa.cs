class Pessoa
{

//atributo nome
private string nome;

//Get = Buscar e Set = Enviar, todo método Get e Set são publicos

// O nome do Get e Set fica do mesmo jeto do atributo contudo com a primeira letra em Maiusculo

public string Nome
{
    //pode usar um ou outro ou ambos
    get{return nome;}
    set{nome=value;}
}


}