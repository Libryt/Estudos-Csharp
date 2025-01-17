// If e else: Encontrar o maior de três números
Console.WriteLine("Digite o primeiro número");
int x = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
int y = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Digite o terceiro número");
int z = Convert.ToInt16(Console.ReadLine());

if (x > y && x > z) // se x é maior que y E x é maior que z = verdadeiro
{
    Console.WriteLine("O valor x é o maior de todos"); //retorna que x é o maior
}
else if(y > x && y > z) // se não, se y é maior que x e y é maior que z = verdadeiro
{
    Console.WriteLine("O valor y é o maior de todos"); // retorna que y é o maior
}
else // se nenhuma das condições for verdadeira retorna que Z é o maior de todos
{
    Console.WriteLine("O valor z é o maior de todos");
}
System.Console.WriteLine("--------------------------------------");
System.Console.WriteLine("\tSwitch\t");

//Switch: Encontrar o valor da parcela
Console.WriteLine("Valor da parcela 900R$");
int compra = 900;
Console.WriteLine("Digite quantas vezes quer parcelar (Max: 3 parcelas)");
int parcela = Convert.ToInt16(Console.ReadLine());
switch(parcela) // Switch é usado pra gerar condições de acordo com valores de igualdade
{
    case 1: //caso valor for 1
        Console.WriteLine($"O valor da prestação é {compra/parcela}");
        break; // encera a linha do caso
    case 2:
        Console.WriteLine($"O valor da parcela é {compra/parcela}");
        break;
    case 3:
        Console.WriteLine($"O valor da parcela é {compra/parcela}");
        break;
    default: //como se fosse o se não
        Console.WriteLine("Valor de parcelas escolhido inválido");
        break;
}

// Switch com mesmo comando para vários casos
System.Console.WriteLine("---Switch com mesmo comando para vários casos---");
System.Console.WriteLine("Digite um mês:\n");
string mes = Console.ReadLine().ToLower();
switch (mes)
{   case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine($"O mês de {mes} tem 31 dias");
    break;
    case "fevereiro":
        Console.WriteLine($"O mês de {mes} tem 29 dias");
    break;
    default:
    System.Console.WriteLine($"O mês de {mes} tem 30 dias");
    break;
}







Console.ReadKey();