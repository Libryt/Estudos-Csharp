var email = new Email();

email.Enviar("@gmail.com");
email.Enviar("@gmail.com", "Assunto Escolhido\n");
email.Enviar("@gmail.com", 1000);
email.Enviar(1000, "@gmail.com");

Console.ReadKey();
class Email
{
    public void Enviar(string endereço)
    {
        Console.WriteLine(endereço);
        System.Console.WriteLine("Assunto padrão\n");
    }
    public void Enviar(string endereço, string assunto)
    {
        System.Console.WriteLine(endereço);
        System.Console.WriteLine($"Assunto:{assunto}\n");
    }
    public void Enviar(string endereço, decimal valor)
    {
        System.Console.WriteLine(endereço);
        System.Console.WriteLine("Proposta comercial");
        System.Console.WriteLine($"Valor:{valor}\n");
    }
    public void Enviar(decimal valor,string endereço)
    {
        System.Console.WriteLine(endereço);
        System.Console.WriteLine("Pagamento Fornecedor");
        System.Console.WriteLine($"Valor:{valor}");
    }
}