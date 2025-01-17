string nome = "Daniel";
int idade = 17;


System.Console.WriteLine("---Concatenação---");
//Concatenação:
System.Console.WriteLine("Seu nome é " + nome + " e sua idade é " + idade + " anos.");

System.Console.WriteLine("---Interpolação---");

//Interpolação:
System.Console.WriteLine($"Seu nome é {nome} e sua idade é {idade} anos.");

System.Console.WriteLine("---Placeholders---");

//Placeholders
System.Console.WriteLine("Seu nome é {0} e sua idade é {1} anos.  ", nome, idade);


//Principais Sequências de Escape

string barra = "C:\\system32\\Windows\\...";
string nosme = "Dani";
string pularLinha = "O seu nome é:\n" + nosme;

System.Console.WriteLine("---Principais Sequências de Escape---\n Campainha \a");

System.Console.WriteLine(barra);
System.Console.WriteLine(pularLinha);




Console.ReadKey();