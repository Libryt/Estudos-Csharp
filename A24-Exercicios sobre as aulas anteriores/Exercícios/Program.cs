//* 1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior

/* int x = int.Parse(Console.ReadLine()); //! 1
int y = int.Parse(Console.ReadLine()); //! 2
int z = int.Parse(Console.ReadLine()); //! 3
Console.WriteLine($"O maior número é {Math.Max(x, Math.Max(y, z))}");
//! Saída: 3 
Console.ReadKey();
*/
//* 2- Escreva um programa para realizar o calculo da equação quadrática.
/*
Console.WriteLine("Digite o valor de A");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de A");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de A");
double c = double.Parse(Console.ReadLine());
double d = b*b-4*a*c;
double x1 = (-b+Math.Sqrt(d))/2*a;
double x2 = (-b-Math.Sqrt(d))/2*a;
if (x1 > 0 && x2 < 0 && x1 != x2)
{
    Console.WriteLine($"O valor de x1 é {x1} e o valor de x2 é {x2}");
    System.Console.WriteLine("As raízes são reais e diferentes");
}
else {
    System.Console.WriteLine("As raízes são imaginárias e sem solução");
}
*/

//* 3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma
/*
int x = 1;
int y = 0;
while(x>=1 && x<=10)
{
    System.Console.WriteLine($"X = {x}");
    y=y+x;
    x++;
}
System.Console.WriteLine($"Soma = {y}");
*/
//*4- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero
//*recebido via teclado
//*- Verifique se o número é maior que zero e emita uma mensagem
//*- Considere a tabela de multiplicação de 1 até 10
//*- Após exibir a tabela torne a solicitar outro número
//*- Para sair do loop defina uma condição de saída 

/* Console.WriteLine("Escreva um número");
int x = Convert.ToInt16(Console.ReadLine());
int n = 1;
if(x > 0)
{
    while(n >= 1 && n<=10)
    {

    
    int m = x*n;
    System.Console.WriteLine($"{x}*{n}= {m}");
    n++;
    }
}
*/

//* 5- Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de
//*resposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder.
//* Não utilize a instrução break.
/* repetir:
Console.WriteLine("Responda a pergunta a seguir:\n" + 
"Qual a instrução para sair de um loop ?\n" +
"a.quit\n" +
"b.continue\n" +
"c.break\n"+ 
"d.exit\n"+
"Qual a opção correta ? (Tecle x para sair)");
char resposta = char.Parse(Console.ReadLine());
if(resposta == 'c')
{
    System.Console.WriteLine("Certa resposta!");
}
else
{
    while(resposta != 'c')
    {    
        System.Console.WriteLine("Deseja tentar novamente?\n" +
        "Se sim tecle (Y) Se não tecle (X)");
        char sair = char.Parse(Console.ReadLine());
        if(sair == 'x' || sair == 'X')
        {
            break;
        }
        else{
            goto repetir;
        }

    }
}
*/
//* 6- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16.
/*
int x = 10;
while(x>= 10 && x <=20)
{
    Console.WriteLine(x);
    x+=2;
    if(x == 16)
    {
        x+=2;
    }

}
*/
//*7- Crie um triangulo de ângulop reto
/* string x = "*";
while(x != "*****")
{
    Console.WriteLine(x);
    x+="*";

}
*/
//*8- Escreva um programa para calcular o fatorial de um número inteiro
/* n * (n – 1) * (n – 2) ....2*1 
Console.WriteLine("Escreva um número para ser calculado o fatorial");
int n = int.Parse(Console.ReadLine());
int fatorial = 1;
for (int i = 1; i<=n; i++)
{
    fatorial = fatorial*i;
    Console.WriteLine(fatorial);
}
System.Console.WriteLine(fatorial);  
*/
//*9  Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado
/*
int numero = 2;
while (numero <=6)
{   
    int multiplicador = 1;
    while(multiplicador  <=10)
    {
    Console.WriteLine($"{numero}x{multiplicador} = {numero*multiplicador}");
    multiplicador++;
    }
    numero++;
}
*/
//*10 Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de
//*um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a
//*instrução switch, break e default em um loop infinito e defina uma condição de saida.)


/* repetir:
Console.WriteLine("Digite sua nota:\n");
int nota = int.Parse(Console.ReadLine());
switch(nota)
    {
        case 0:
        case 1:
        case 2:
        case 3:
        case 4:
        Console.WriteLine("Você Tirou (F)");
        break;
        case 5:
        Console.WriteLine("Você tirou (E)");
        break;
        case 6:
        System.Console.WriteLine("Você tirou (C)");
        break;
        case 7:
        case 8:
        System.Console.WriteLine("Você tirou (B)");
        break;
        case 9:
        System.Console.WriteLine("Você tirou (A)");
        break;
        case 10:
        System.Console.WriteLine("Você tirou (A+)");
        break;
    }
if(nota >10 || nota <0)
{
    goto repetir;
}
*/
//* 11- Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números
//* inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e
//* quando isso ocorrer exibir uma mensagem de alerta)

/* System.Console.WriteLine("Informe o primeiro número\n");
double n1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Informe o operador:\n");
char  operador = char.Parse(Console.ReadLine());
System.Console.WriteLine("Informe o segundo número:\n");
double n2 = double.Parse(Console.ReadLine());
double resposta;
switch(operador)
{
    case '+':
    resposta = n1+n2;
    System.Console.WriteLine($"{n1}{operador}{n2}={resposta}");
    break;
    case '-':
    resposta = n1-n2;
    System.Console.WriteLine($"{n1}{operador}{n2}={resposta}");
    break;
    case '*':
    resposta = n1*n2;
    System.Console.WriteLine($"{n1}{operador}{n2}={resposta}");
    break;
    case '/':
    resposta = n1/n2;
    System.Console.WriteLine($"{n1}{operador}{n2}={resposta}");
    break;
    
}
*/
Console.ReadKey();