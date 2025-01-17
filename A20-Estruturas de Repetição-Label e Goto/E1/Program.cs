int i = 1;
repetir: {// o simbolo de dois pontos define uma label com o indentificador citado anterior
System.Console.WriteLine($"i = {i}");
i++;
if(i<=1000) 
{
    goto repetir; //se a condição não for a estabelecida, vai ir para repetir e incrementar até ser a condição proposta (go to, ir para)
}
}
System.Console.WriteLine($"i = {i}");
System.Console.WriteLine("Fim");


Console.ReadKey();