var calc = new Calculo();
calc.x = 10;
calc.y = 20;
calc.Somar();
//-------------------------
CalculoStatic.x = 30;
CalculoStatic.y = 20;
CalculoStatic.Subtrair();

Console.ReadKey();
class Calculo
{
    public int x; //  Campos(1)
    public int y; // (1)
    public void Somar()
    {
        int soma = x+y;
        System.Console.WriteLine(soma);
    }
}
class CalculoStatic
{
    public static int x;
    public static int y;

    public static void Subtrair()
    {
        int subtração = x-y;
        System.Console.WriteLine(subtração);
    }
}