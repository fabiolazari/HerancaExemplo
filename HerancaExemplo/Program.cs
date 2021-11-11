using System;

namespace HerancaExemplo
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Conta Corrente
			ContaCorrente contaCorrente = new ContaCorrente(1, 245711, "Conta Corrente 1", 300, 5);

			Console.WriteLine("Saldo CC Atual: " + contaCorrente.Saldo().ToString());
			
			contaCorrente.Sacar(150);
			Console.WriteLine("Saldo CC Após Saque: " + contaCorrente.Saldo().ToString());

			contaCorrente.Depositar(100);
			Console.WriteLine("Saldo CC Após Depósito: " + contaCorrente.Saldo().ToString());

			Console.WriteLine();
			Console.WriteLine();



			//Conta Poupança
			ContaPoupanca contaPoupanca = new ContaPoupanca(2, 785421, "Conta Corrente 1", 5000, 10, 2);

			Console.WriteLine("Saldo CP Atual: " + contaPoupanca.Saldo().ToString());

			contaPoupanca.Sacar(500);
			Console.WriteLine("Saldo CP Após Saque: " + contaPoupanca.Saldo().ToString());

			contaPoupanca.Depositar(200);
			Console.WriteLine("Saldo CP Após Depósito: " + contaPoupanca.Saldo().ToString());

			contaPoupanca.AplicaRendimento();
			Console.WriteLine("Saldo CP Após Aplicação Rendimento: " + contaPoupanca.Saldo().ToString());


			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
