int cargo, funcao;
System.Console.WriteLine("Você é Gerente (1) ou Programador (2)?");
cargo = int.Parse(Console.ReadLine());
if (cargo == 1)
{
    System.Console.WriteLine("Bem vindo Gerente\n");
}
else if (cargo == 2){
    System.Console.WriteLine("Você é programador");
    System.Console.WriteLine("Qual sua função?\n Junior(1)\nPleno(2)\nSenior(3)");
    funcao = int.Parse(Console.ReadLine());
    switch(funcao)
    {
        case 1:
            System.Console.WriteLine("Você é Junior");
        break;
        case 2: 
            System.Console.WriteLine("Você é Pleno");
        break;
        case 3:
            System.Console.WriteLine("Você é Senior");
        break;
        default:
            System.Console.WriteLine("Função não indentificada");
        break;
    }
}
else{
    System.Console.WriteLine("Cargo Não indentificado");
}























Console.ReadKey();