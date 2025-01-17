//Operador Ternário é como se fosse um if e else simplificado

Console.WriteLine("Digite um número:\n");
var entrada = double.Parse(Console.ReadLine()); // False
var resultado = entrada > 0 ? "Número positivo" : "Número negativo"; // (?) = Se sim. (:) = Se não
System.Console.WriteLine($"O resultado é {resultado}");


//Aninhamento de Operador Ternário
System.Console.WriteLine("---Aninhamento de operador ternário---");
System.Console.WriteLine("Digite um número:\n");
var x = int.Parse(Console.ReadLine());
System.Console.WriteLine("Digite outro número:\n");
var y = int.Parse(Console.ReadLine());
string? result = x > y ? "X é maior que Y" :
                x == y ? "X é igual a Y" :
                x < y ? "X é menor que y" : null;
System.Console.WriteLine($"O resultado é {result}");

Console.ReadKey();