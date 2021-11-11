using System;

namespace HerancaExemplo
{
	public class ContaPoupanca : Conta
	{
		public decimal PercentualRendimento { get; set; }

		public ContaPoupanca(int idConta, long numeroConta, string descricaoConta, decimal valorSaldo, decimal tarifa, decimal percentualRendimento)
			: base(idConta, numeroConta, descricaoConta, valorSaldo)
		{
			TipoConta = "Poupança";
			Tarifa = tarifa;
			PercentualRendimento = percentualRendimento;
		}

		public override void Sacar(decimal valor)
		{
			base.Sacar(valor);
			ValorSaldo -= 10;
		}

		public override void Depositar(decimal valor)
		{
			base.Depositar(valor);
		}

		public override decimal Saldo()
		{
			return base.Saldo();
		}

		public void AplicaRendimento()
		{
			ValorSaldo += (ValorSaldo * (PercentualRendimento / 100));
		}
	}
}
