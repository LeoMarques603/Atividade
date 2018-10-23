using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente(1000, 200, 100, 2000, 500);

            Console.WriteLine(c.CalcularNovoSaldo());

            c.AtualizarSaldo();

            if (c.UltrapassouLimite())
            {
                Console.WriteLine("Limite de Credito Excedido.");
            }
        }
    }
}

class Cliente
{
    private int saldo;
    private int conta;
    private int cobranças;
    private int creditos;
    private int limiteDeCredito;

    public Cliente(int saldo, int conta, int cobrança, int credito, int limite)
    {
        this.saldo = saldo;
        this.conta = conta;
        this.cobranças = cobrança;
        this.creditos = credito;
        this.limiteDeCredito = limite;
    }

    public int CalcularNovoSaldo()
    {
        return this.saldo + this.cobranças - this.creditos;
    }

    public void AtualizarSaldo()
    {
        this.saldo = CalcularNovoSaldo();
    }

    public bool UltrapassouLimite()
    {
        return this.saldo > this.limiteDeCredito;
    }
}
