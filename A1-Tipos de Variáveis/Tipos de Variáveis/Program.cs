//Tipos de Variáveis Primitivas;
// Tipos de Variáveis Numéricas:


System.Console.WriteLine("____Tipos de Variáveis Primitivas____");
System.Console.WriteLine("----Tipos de Variáveis Numéricas----");
System.Console.WriteLine(" ");
int inteiro = 1; // Somente para números inteiros
float básico = 1f/3f; // Numéros reais com pouca precisão. OBS: Gasta 4 bytes
double científico = 1d/3d; // Numéros reais com média precisão. OBS: Gasta 8 bytes
decimal financeiro = 1m/3m; // Numéros reais com alta precisão. OBS: Gasta 16 bytes

const float numeroimutavel = 10.24f; // Uma variável constante é uma variável que não pode ser mudada posteriormente no código.
//  float numeroimutavel = 10,23f; --> Error


/*Observação: Quando eu declaro a variável como um numero real, seja float, double ou decimal, eu TENHO que declarar o valor como numero real também. Ex: float = 1f, double = 1d,
decimal 1m*/

System.Console.WriteLine("O valor inteiro é: " + inteiro);
System.Console.WriteLine("O valor real básico(float) é: " + básico);
System.Console.WriteLine("O valor real científico(double) é: " + científico);
System.Console.WriteLine("O valor real financeiro é(decimal): " + financeiro);




//Tipos de Variáveis Não Numéricas:
System.Console.WriteLine(" ");
System.Console.WriteLine("----Tipos de váriaveis não Numéricas----");
System.Console.WriteLine(" ");



string nome = "DanielSTRING"; //Representa uma sequência de zero ou mais carácteres
// string nome = "Daniel; -> Erro. A String tem uma propriedade de ser imutável, ou seja, não pode existir duas variáveis string com o mesmo nome

int x = 10; //OBS: Vai ser feito uma comparação posteriormente.
int y = 20;

bool pequeno = true; //Verdadeiro ou Falso
bool grande = false;
bool a = x>y;
System.Console.WriteLine("X(10) é maior que Y(20)? " + a);
char letra_E_de_Eternidade = 'E';  //Único caractérete
char symboleternity = '\u0045'; //O char pode detectar um único caractérete, seja simbolo(unicode) ou uma letra única.

System.Console.WriteLine("Qual o nome? " + nome);
Console.WriteLine(x>y); //Resposta: Falso
Console.WriteLine(x<y); //Resposta: Verdadeiro
System.Console.WriteLine("O nome Daniel é pequeno? " + pequeno); // Resposta: True
System.Console.WriteLine("Daniel é alto? " + grande); // Resposta: False
System.Console.WriteLine("A primeira letra da palavra Eternidade é '" + letra_E_de_Eternidade + "'");
System.Console.WriteLine("O unicode da palavra Eternidade é '" + symboleternity + "'");



//Tipos de Variáveis de Não Primitivas:
System.Console.WriteLine(" ");
System.Console.WriteLine("____Tipos de Variáveis Não Primitivas____");
System.Console.WriteLine(" ");



//O 'object' é útil quando não temos informações sobre o tipo de dados que desejamos usar, aceitando varios tipos de dados primitivos, porém usando mais memória pra isso.
object name = "DanielOBJECTSTRING";
object idade = 17;
object altura = 1.79;
object masculino = true;
object letrainicial = 'A'; 

// O 'dynamic' tem o comportamento similar ao object, porém ele é mais útil quando precisamos usar recursos avançados da linguagem ou recursos das linguagens dinâmicas.

dynamic nomi = "Daniel"; 
dynamic idadi = 11;
dynamic alturi = 1.97;
dynamic masculini = true;
dynamic letrainiciil = 'a';



System.Console.WriteLine("Qual é o nome? " + name);
System.Console.WriteLine("Qual é a idade? " + idade);
System.Console.WriteLine("Qual é a altura? " +altura);
System.Console.WriteLine("O Sexo é masculino? " + masculino);
System.Console.WriteLine("Qual a letra inicial do nome? " + letrainicial);

DateTime data= new DateTime(2006,04,11);
System.Console.WriteLine($"A data na forma longa é {data.ToLongDateString()}");


Console.ReadKey();