using System;

namespace HerancaExemplo
{
	public class ContaCorrente : Conta
	{
		public ContaCorrente(int idConta, long numeroConta, string descricaoConta, decimal valorSaldo, decimal tarifa) 
			:base(idConta, numeroConta, descricaoConta, valorSaldo)
		{
			TipoConta = "Corrente";
			Tarifa = tarifa;
		}

		public override void Sacar(decimal valor)
		{
			base.Sacar(valor);
		}

		public override void Depositar(decimal valor)
		{
			base.Depositar(valor);
		}

		public override decimal Saldo()
		{
			return base.Saldo();
		}
	}
}
