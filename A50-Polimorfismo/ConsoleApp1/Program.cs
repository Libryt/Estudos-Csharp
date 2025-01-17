Figura figura = new();
figura.Desenhar();
Figura figura1 = new Triangulo();
figura1.Desenhar();
Figura figura2 = new Quadrado();
figura2.Desenhar();
class Figura
{
    public virtual void Desenhar()
    {
        Console.WriteLine("Desenhando...");
    }
}
class Triangulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando Triângulo...");
    }
}
class Quadrado : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando Quadrado");
    }
}
