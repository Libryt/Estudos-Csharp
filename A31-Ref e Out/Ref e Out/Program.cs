//! Usando o Ref
var alterarValorRef = new AlterarValorRef(); 
int valorRef = 10; // o valor DEVE ser inicializado
System.Console.WriteLine("Antes de chamar o método: " + valorRef);
alterarValorRef.AlterarValor(ref valorRef);
System.Console.WriteLine("Depois de chamar o método: " + valorRef);
System.Console.WriteLine("-----------------------");
//!Usando o Out
var alterarValorOut = new AlterarValorOut();
int valorOut;
System.Console.WriteLine("Valor antes de chamar o método: Nada");
alterarValorOut.AlterarValor(out valorOut);
System.Console.WriteLine($"Valor depois de chamar o método: {valorOut}");

Console.ReadKey();
class AlterarValorRef
{
    public void AlterarValor(ref int x)
    {
        x+=10;
    }
}
class AlterarValorOut
{
    public int AlterarValor(out int numero)
    {
        numero = 30;
        return numero;
    }
}

