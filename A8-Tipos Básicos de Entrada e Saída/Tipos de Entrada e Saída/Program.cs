//Tipos de Saída
Console.Write("Olá"); //Escreve onde o cursor foi parado pela ultima vez
Console.WriteLine(" Mundo\n---Tipos de Entrada---"); //Escreve em uma nova linha

//Tipos de Entrada

System.Console.WriteLine("Informe seu nome");
string nome = Console.ReadLine(); //Armazena uma string, e não é necessário converter em string, pois o valor a ser digitado já é uma string por padrão
System.Console.WriteLine($"Seu nome é {nome}!\n");


System.Console.WriteLine("Informe sua idade"); 
int idade = Convert.ToInt16(Console.ReadLine()); //Armazena um número inteiro, é necessário converter a entrada "Console.ReadLine()" em inteiro antes de receber o valor.
System.Console.WriteLine($"Sua idade é {idade}!\n");


System.Console.WriteLine("Informe um caráctere"); 
int código = Console.Read(); //Lê a tecla digitada e retorna o código ascii, logo o valor armazenado é um inteiro.
System.Console.WriteLine("O codigo do seu caractére é: " + código);


Console.ReadKey();