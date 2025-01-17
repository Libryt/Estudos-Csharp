internal class Program
{
    private static void Main(string[] args)
    {
        //*Objeto
        Fisico fisico = new Fisico();
        //!Atribuição de valor aos métodos do objeto
        fisico.altura = 179;
        fisico.peso = 60;

        //? Usando métodos do objeto criado
        Console.WriteLine($"A sua altura é {fisico.altura}");
        Console.WriteLine($"O seu peso é {fisico.peso}");



        Saudar saudar = new Saudar(); //! Criação do Objeto 
        saudar.Saudacao(); //! Resultado: "Olá mundo" "Tudo bom?"


        Console.ReadKey();
    }
}

class Saudar
{
  public void Saudacao()
  {
    System.Console.WriteLine("Olá mundo");
    System.Console.WriteLine("Tudo bom?");
  }
}

class Fisico
{

    //*Métodos
      public float cmabdomen;
      public int idade; 
      public int peso;
      public int altura;
      public float cmbraco;
}

