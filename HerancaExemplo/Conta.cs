using System;

namespace HerancaExemplo
{
	public class Conta
	{
		public int IdConta { get; set; }
		public long NumeroConta { get; set; }
		public string DescricaoConta { get; set; }
		public decimal ValorSaldo { get; set; }
		public decimal Tarifa { get; set; }
		public string TipoConta { get; set; }

		public Conta(int idConta, long numeroConta, string descricaoConta, decimal valorSaldo)
		{
			IdConta = idConta;
			NumeroConta = numeroConta;
			DescricaoConta = descricaoConta;
			ValorSaldo = valorSaldo;
		}

		public virtual void Sacar(decimal valor)
		{
			ValorSaldo -= valor;
			ValorSaldo -= (valor * (Tarifa / 100));
		}

		public virtual void Depositar(decimal valor)
		{
			ValorSaldo += valor;
		}

		public virtual decimal Saldo()
		{
			return ValorSaldo;
		}
	}
}
