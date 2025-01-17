Conta_Corrente contaCorrente = new(1, "Daniel");
Console.WriteLine($"{contaCorrente}: Número da Conta: {contaCorrente.NumeroConta} " +
    $"Titular: {contaCorrente.NomeCliente}");
contaCorrente.Depositar(1000);
contaCorrente.Sacar(100);
contaCorrente.ExibirSaldo();
contaCorrente.Sacar(2000);
contaCorrente.ExibirSaldo();

Console.WriteLine();

Poupança contaPoupança = new(2, "Jailson");
Console.WriteLine($"{contaPoupança}: Número da Conta: {contaPoupança.NumeroConta} " +
    $"Titular: {contaPoupança.NomeCliente}");
contaPoupança.Depositar(1000);
contaPoupança.Sacar(100);
contaPoupança.ExibirSaldo();
contaPoupança.Sacar(2000);
contaPoupança.ExibirSaldo();

Console.WriteLine();

Investimento contaInvestimento = new(3, "Jonas");
Console.WriteLine($"{contaInvestimento}: Número da Conta: {contaInvestimento.NumeroConta} " +
    $"Titular: {contaInvestimento.NomeCliente}");
contaInvestimento.Depositar(1000);
contaInvestimento.ExibirSaldo();
contaInvestimento.Sacar(100);
contaInvestimento.ExibirSaldo();
contaInvestimento.Sacar(2000);
contaInvestimento.ExibirSaldo();
class Conta_Corrente
{
    public int NumeroConta;
    public string NomeCliente;
    protected double Saldo = 0;
    public Conta_Corrente(int numeroConta, string nomeCliente)
    {
        NumeroConta = numeroConta;
        NomeCliente = nomeCliente;
        Console.WriteLine($"");
    }
    public virtual void Depositar(double valorDeposito)
    {
        Saldo += valorDeposito;
        Console.WriteLine($"Depósito de {valorDeposito} R$ foi efetuado.");
    }
    public virtual void Sacar(double valorSaque)
    {
        Saldo -= valorSaque;
        Console.WriteLine($"Saque de {valorSaque} R$ foi efetuado.");
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"{NomeCliente} seu saldo é {Saldo.ToString("c")} R$ !");
    }
}
class Poupança : Conta_Corrente
{
    public Poupança(int numeroConta, string nomeCliente) : base(numeroConta, nomeCliente) { }
    public override void Depositar(double valorDeposito)
    {
        Saldo += valorDeposito + (valorDeposito * 0.005);
        Console.WriteLine($"Depósito de {valorDeposito} R$ foi efetuado.");
    }
    public new void Sacar(double valorSaque)
    {

        if (valorSaque <= Saldo)
        {
            Saldo -= valorSaque;
            Console.WriteLine($"Saque de {valorSaque} R$ foi efetuado.");
        }
        else
        {
            Console.WriteLine("Saldo indisponível para saque");
        }
    }
}
class Investimento : Conta_Corrente
{
    public Investimento(int numeroConta, string nomeCliente) : base(numeroConta, nomeCliente) { }
    public override void Depositar(double valorDeposito)
    {
        Saldo += valorDeposito + (valorDeposito * 0.009);
        Console.WriteLine($"Depósito de {valorDeposito} R$ foi efetuado.");
    }
    public override void Sacar(double valorSaque)
    {
        if (valorSaque <= Saldo)
        {
            Saldo -= valorSaque + (Saldo * 0.001);
            Console.WriteLine($"Saque de {valorSaque} R$ foi efetuado.");
        }
        else
        {
            Console.WriteLine("Saldo indisponível para saque");
        }
    }
}