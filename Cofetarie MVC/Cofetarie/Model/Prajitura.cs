using System;

namespace Cofetarie.Model
{
	public class Prajitura
	{
		private string denumire;
		private double pret;
		private uint cantitate;
		private DateTime valabilitate;

		public Prajitura()	{}
		public Prajitura(string denumire, double pret, uint cantitate, DateTime valabilitate)
		{
			this.denumire = denumire;
			this.pret = pret;
			this.cantitate = cantitate;
			this.valabilitate = valabilitate;
		}
		public Prajitura(Prajitura prajitura)
		{
			this.denumire = prajitura.denumire;
			this.pret = prajitura.pret;
			this.cantitate = prajitura.cantitate;
			this.valabilitate = prajitura.valabilitate;
		}
		public string GetDenumire()
		{
			return denumire;
		}
		public double GetPret()
		{
			return pret;
		}
		public uint GetCantitate()
		{
			return cantitate;
		}
		public DateTime GetValabilitate()
		{
			return valabilitate;
		}
		public void SetDenumire(string denumire)
		{
			this.denumire = denumire;
		}
		public void SetPret(double pret)
		{
			this.pret = pret;
		}
		public void SetCantitate(uint cantitate)
		{
			this.cantitate = cantitate;
		}
		public void SetValabilitate(DateTime valabilitate)
		{
			this.valabilitate = valabilitate;
		}
	}
}
