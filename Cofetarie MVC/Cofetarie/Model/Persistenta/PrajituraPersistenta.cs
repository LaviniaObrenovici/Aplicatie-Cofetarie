using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Cofetarie.Model.Persistenta
{
	public class PrajituraPersistenta
	{
		private string numeFisier;

		public PrajituraPersistenta()
		{
			this.numeFisier = "prajituri.xml";
		}
		public PrajituraPersistenta(string numeFisier)
		{
			this.numeFisier = numeFisier;
		}
		public PrajituraPersistenta(PrajituraPersistenta pp)
		{
			this.numeFisier = pp.numeFisier;
		}
		public string GetNumeFisier()
		{
			return numeFisier;
		}
		public void SetNumeFisier(string numeFisier)
		{
			this.numeFisier = numeFisier;
		}
		public bool AdaugarePrajitura(Prajitura prajitura)
		{
			try
			{
				XElement xElement = XElement.Load(@"prajituri.xml");
				xElement.Add(new XElement("prajitura",
					new XElement("denumire", prajitura.GetDenumire()),
					new XElement("pret", prajitura.GetPret().ToString()),
					new XElement("cantitate", prajitura.GetCantitate().ToString()),
					new XElement("valabilitate", prajitura.GetValabilitate().ToString())
					));
				xElement.Save(@"prajituri.xml");
				return true; 
			}
			catch (Exception ex)
			{
				MessageBox.Show("Eroare adaugare prajitura: " + ex.ToString());
				return false;
			}
		}
		public bool StergerePrajitura(string denumire, uint cantitateStearsa)
		{
			try
			{
				XDocument xDocument = XDocument.Load(@"prajituri.xml");
				var element = xDocument.Root.Elements("prajitura").Where(e => e.Element("denumire").Value == denumire).Single();
				uint cantitateCofetarie = Convert.ToUInt16(element.Element("cantitate").Value);
				MessageBox.Show(cantitateCofetarie.ToString());
				MessageBox.Show(cantitateStearsa.ToString());
				if (cantitateCofetarie-cantitateStearsa>0)
                {
					element.Element("cantitate").Value = (cantitateCofetarie - cantitateStearsa).ToString();
				}
				else
					xDocument.Root.Elements("prajitura").Where(e => e.Element("denumire").Value == denumire).Remove();
				xDocument.Save(@"prajituri.xml");
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		public bool ActualizarePrajitura(string denumire, Prajitura prajitura)
		{
			try
			{
				XDocument xDocument = XDocument.Load(@"prajituri.xml");
				var element = xDocument.Root.Elements("prajitura").Where(e => e.Element("denumire").Value == denumire).Single();				
				element.Element("pret").Value = prajitura.GetPret().ToString();
				element.Element("denumire").Value = prajitura.GetDenumire().ToString();
				element.Element("cantitate").Value = prajitura.GetCantitate().ToString();
				element.Element("valabilitate").Value = prajitura.GetValabilitate().ToString();
				xDocument.Save(@"prajituri.xml");
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		public bool ActualizareCantitatePrajitura(string denumire, uint cantitateAdaugata)
		{
			try
			{
				XDocument xDocument = XDocument.Load(@"prajituri.xml");
				var element = xDocument.Root.Elements("prajitura").Where(e => e.Element("denumire").Value == denumire).Single();
				uint cantitateVeche = Convert.ToUInt16(element.Element("cantitate").Value); 
				element.Element("cantitate").Value= (cantitateVeche+cantitateAdaugata).ToString();
				xDocument.Save(@"prajituri.xml");
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		public List<Prajitura> ListaPrajituri()
		{
			List<Prajitura> prajituri = new List<Prajitura>();
			try
			{
				XDocument xDoc = XDocument.Load(@"prajituri.xml");
				List<XElement> xElemente = xDoc.Root.Elements("prajitura").ToList();
				foreach (XElement xElement in xElemente)
				{
					string denumire = xElement.Element("denumire").Value;
					double pret = Convert.ToDouble(xElement.Element("pret").Value);
					uint cantitate = Convert.ToUInt16(xElement.Element("cantitate").Value);
					DateTime valabilitate = Convert.ToDateTime(xElement.Element("valabilitate").Value);				
					Prajitura prajitura = new Prajitura(denumire, pret, cantitate, valabilitate);
					prajituri.Add(prajitura);
				}
				return prajituri;
			}
			catch (Exception)
			{
				return null;
			}
		}
		public List<Prajitura> FiltrarePrajituri(bool disponibilitate)
		{
			List<Prajitura> prajituri = new List<Prajitura>();
			try
			{
				if (disponibilitate)
				{
					XDocument xDoc = XDocument.Load(@"prajituri.xml");
					List<XElement> xElemente = xDoc.Root.Elements("prajitura").ToList();
					foreach (XElement xElement in xElemente)
					{
						uint cantitate = Convert.ToUInt16(xElement.Element("cantitate").Value);
						if (cantitate > 0)
						{
							string denumire = xElement.Element("denumire").Value;
							double pret = Convert.ToDouble(xElement.Element("pret").Value);
							DateTime valabilitate = Convert.ToDateTime(xElement.Element("valabilitate").Value);
							Prajitura prajitura = new Prajitura(denumire, pret, cantitate, valabilitate);
							prajituri.Add(prajitura);
						}
					}
				}
				return prajituri;
			}
			catch (Exception)
			{
				return null;
			}
		}
		public List<Prajitura> FiltrarePrajituri(double pretPrajitura)
		{
			List<Prajitura> prajituri = new List<Prajitura>();
			try
			{
				XDocument xDoc = XDocument.Load(@"prajituri.xml");
				List<XElement> xElemente = xDoc.Root.Elements("prajitura").ToList();
				foreach (XElement xElement in xElemente)
				{
					double pret = Convert.ToDouble(xElement.Element("pret").Value);
					if (pret == pretPrajitura)
					{
						string denumire = xElement.Element("denumire").Value;
						uint cantitate = Convert.ToUInt16(xElement.Element("cantitate").Value);
						DateTime valabilitate = Convert.ToDateTime(xElement.Element("valabilitate").Value);
						Prajitura prajitura = new Prajitura(denumire, pret, cantitate, valabilitate);
						prajituri.Add(prajitura);
					}
				}
				return prajituri;
			}
			catch (Exception)
			{
				return null;
			}
		}
		public List<Prajitura> FiltrarePrajituri(DateTime valabilitatePrajitura)
		{
			List<Prajitura> prajituri = new List<Prajitura>();
			try
			{
				XDocument xDoc = XDocument.Load(@"prajituri.xml");
				List<XElement> xElemente = xDoc.Root.Elements("prajitura").ToList();
				foreach (XElement xElement in xElemente)
				{
					DateTime valabilitate = Convert.ToDateTime(xElement.Element("valabilitate").Value);
					if (valabilitate == valabilitatePrajitura)
					{
						string denumire = xElement.Element("denumire").Value;
						double pret = Convert.ToDouble(xElement.Element("pret").Value);
						uint cantitate = Convert.ToUInt16(xElement.Element("cantitate").Value);
						Prajitura prajitura = new Prajitura(denumire, pret, cantitate, valabilitate);
						prajituri.Add(prajitura);
					}
				}
				return prajituri;
			}
			catch (Exception)
			{
				return null;
			}
		}
		public Prajitura CautarePrajitura(string denumirePrajitura)
		{
			try
			{
				XDocument xDoc = XDocument.Load(@"prajituri.xml");
				List<XElement> xElemente = xDoc.Root.Elements("prajitura").ToList();
				foreach (XElement xElement in xElemente)
				{
					string denumire = xElement.Element("denumire").Value;
					if (denumire == denumirePrajitura)
					{
						double pret = Convert.ToDouble(xElement.Element("pret").Value);
						uint cantitate = Convert.ToUInt16(xElement.Element("cantitate").Value);
						DateTime valabilitate = Convert.ToDateTime(xElement.Element("valabilitate").Value);
						Prajitura prajitura = new Prajitura(denumire, pret, cantitate, valabilitate);
						return prajitura;
					}
				}
				return null;
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
