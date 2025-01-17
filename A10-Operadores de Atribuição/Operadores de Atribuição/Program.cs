var x = 10; // = atribui o valor
x+= 5; // adiciona 5 ao valor da variável, ficando 15
x-= 5; // subtrai 5 ao valor da variável, ficando 5
x*= 5; // multiplica o valor da variável por 5, ficando 50
x/= 5; // divide o valor da variável por 5, ficando 2
x%= 5; // recebe o módulo da variável pelo número, ficando 0, por que 10/5 é perfeito

//#Concatenação de Strings por atribuição
string nome = "daniel";
System.Console.WriteLine($"O nome é {nome}");
nome += "@gmail.com";
System.Console.WriteLine($"O nome concatenado com o endereço de email é: {nome}");
System.Console.WriteLine(nome);
Console.ReadKey();