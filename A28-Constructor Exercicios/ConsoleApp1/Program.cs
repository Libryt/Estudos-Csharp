// 1- Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e
// potencia com os tipos de dados string, string, string, int e int. (1\1)
// Crie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”
// a- Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet , Onix, 2016, 110
// b- Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120
// c- Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar para cada objeto
// d- Altere o método Acelerar para receber um parâmetro do tipo string chamado marca e a seguir altere a
// mensagem para exibir o texto “Acelerando o meu {marca}“ , seguido da marca do carro. 
// e- Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos :
// modelo, montadora, marco, ano e potencia (use a palavra this para identificar a instância da classe)




/*(e)*/var chevrolet = new Carro("Sedan","Chevrolet","Onix",2016,110); //*(a)
/*chevrolet.Modelo = "Sedan";
chevrolet.Montadora = "Chevrolet";
chevrolet.Marca = "Onix";
chevrolet.Ano = 2016;
chevrolet.Potencia = 110; *///!(a)

/* var ford = new Carro(); //*(b)
ford.Modelo = "SUV";
ford.Montadora = "Ford";
ford.Marca = "EcoSport";
ford.Ano = 2018;
ford.Potencia = 120;//!(b) */



chevrolet.Acelerar(chevrolet.Marca);
// chevrolet.Acelerar(); //*(c)
Console.WriteLine($"{chevrolet.Modelo} {chevrolet.Montadora} {chevrolet.Marca}" +
$"{chevrolet.Ano} {chevrolet.Potencia}CV"); //!(c)


Console.ReadKey();
public class Carro //*(1) //criação da classe
{

    /*(E)*/ /*Criação do Constructor*/public Carro(string modelo, string montadora, string marca, int potencia, int ano) //!(E) 
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }
    public string Modelo;
    public string Montadora;
    public string Marca;
    public int Potencia;
    public int Ano;

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando meu /*(d)*/{marca}/*(d)*/");
    }
    // public void Acelerar()
    // {
    //     System.Console.WriteLine("Acelerando...");
    // }
} //!(1)