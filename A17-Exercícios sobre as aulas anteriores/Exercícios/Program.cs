/*(1)Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :
Aluno <nome> tem <idade> anos e nota <nota> usando a concatenação e a interpolação de strings. 
string nome = "Paulo"; int idade = 17; double nota = 7.5;
System.Console.WriteLine($"Aluno {nome} tem {idade}anos e nota {nota}"); 
(2) Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
escapes. System.Console.WriteLine($"Aluno {nome} tem {idade}anos\n e nota {nota}"); */
/* 3- Para qual tipo de dados você pode converter um float implicitamente ?
() int
( X ) double
( ) long
( X ) decimal
4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
( F) int para long
(V ) double para long
(V) double para float
( V) decimal para float
( V) long para int
( V) double para decimal */
/*(5) - Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
a concatenação e também a interpolação de strings 
char l1 = Convert.ToChar(Console.ReadLine()); char l2 = Convert.ToChar(Console.ReadLine()); 
System.Console.WriteLine("A ultima letra é" + l2); System.Console.WriteLine($"A primeira letra é{l1}"); */

/*(6) Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
( F) long resultado = 1.32;
( V) var nome = “Maria”;
( V) string resultado = 100.ToString();
( V) A sequência de escape \n inclui uma nova linha
( F) float f = 5.45;
( v) decimal valor = (decimal) 10.99f;
( F) var status = null;
( V) object o = 12.45m;
( V) string titulo = true.ToString();
(F) A sequencia \t inclui uma tabulação vertical */

/* (7) Escreva um programa para receber dois valores via teclado do tipo double e a seguir
realize as operações de soma, multiplicação, exponenciação, divisão e módulo
exibindo o resultado:  */
/*System.Console.WriteLine("Digite um número\n");
double n1 = Convert.ToDouble(Console.ReadLine()); 
System.Console.WriteLine("Digite outro número\n");
double n2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"Os números digitados foram: {n1} e {n2}.");
System.Console.WriteLine($"O resultado da soma é:{n1+n2}");
System.Console.WriteLine($"O resultado da multiplicação é:{n1*n2}");
System.Console.WriteLine($"O resultado da exponenciação é:{Math.Pow(n1,n2)}");
System.Console.WriteLine($"O resultado da divisão é:{n1/n2}");
System.Console.WriteLine($"O resultado do módulo  é:{n1%n2}"); */

/* (8) - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de
a b e c Valores : a = 1 , b = 12 e c = -13. 

int a,b,c;
a = 1; b = 12; c = -13;
double bhaskara = -b+Math.Sqrt(b*b-4*a*c)/2*a;
System.Console.WriteLine($"O resultado de bhaskara é:{bhaskara}");
double x1, x2, delta;
delta = (b^2)-4*a*c;
x1 = -b+Math.Sqrt(delta);
x2 = -b-Math.Sqrt(delta);
System.Console.WriteLine($"O resultado de x1 é {x1} e o resultado de x2 é {x2}");
*/
/*- (9) NAO CONSEGUI COM OPERADOR TERNÁRIO)Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
inválido’: (use o operador condicional ternário): 
System.Console.WriteLine("Digite seu nome");
string nome = Console.ReadLine();
System.Console.WriteLine("Digite sua senha");
int senha = Convert.ToInt16(Console.ReadLine());
if (nome == "Maria" || nome == "Admin" && senha == 123)
    System.Console.WriteLine("Login feito com sucesso");
else 
    System.Console.WriteLine("Login inválido"); */
/*10- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando
a nomenclatura usada:
(F ) string? nome; é um exemplo de nullable reference type;
(V ) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
( V) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
( F) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
(F ) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
(V ) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
(V  ) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
( F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
(F ) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
( V ) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
( V ) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?     */
/* 11- Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :) 
System.Console.WriteLine("Digite um número");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Digite outro número");
double b = Convert.ToDouble(Console.ReadLine());
if (a%2 == 0){
    System.Console.WriteLine("1 Número é par");
}
else{
    System.Console.WriteLine("1 Número é impar");
}
if (b%2 == 0) {
    System.Console.WriteLine("2 número é par");
}
else{
    System.Console.WriteLine("2 número é impar");
}
*/
/* 12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no
console o resultado das seguintes operações : (x^2 -> x ao quadrado) (pi = 3.1415) 

System.Console.WriteLine("Escreva um número inteiro");
int x = Convert.ToInt16(Console.ReadLine());
double PI = 3.1415;
int op1, op2, op3, op4, op5, op6;
op1 = -6 + x * 5;
op2 = (13-2) * x;
op3 = (x + -2) * (20 / x);
op4 = (12 + x) / (x - 4);
op5 = 3*x^2 + x + 10;
// NAO CONSEGUI OP 6
System.Console.WriteLine
(
    $"OP1:{op1}\n"+
    $"OP2:{op2}\n"+
    $"OP3:{op3}\n"+
    $"OP4:{op4}\n"+
    $"OP5:{op5}\n"
    
);
*/
/*14- Escreva um programa que solicite a temperatura em graus Celsius e converta para
Kelvin e Farhenheit usando as fórmulas a seguir: 

System.Console.WriteLine("Escreva a temperatura atual em graus Celsius");
double C = Convert.ToDouble(Console.ReadLine());
double K = C+273;
double F = C*9/5+32;
System.Console.WriteLine($"A temperatura em Celsius é {C}, e ela convertida em Kelvin é {K} e Farhenheit é{F}");
*/

// 15= A






Console.ReadKey();