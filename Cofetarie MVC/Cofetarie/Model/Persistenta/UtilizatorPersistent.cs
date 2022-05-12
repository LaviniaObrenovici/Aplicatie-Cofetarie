using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Cofetarie.Model.Persistenta
{
    public class UtilizatorPersistent
    {
        private string numeFisier;

        public UtilizatorPersistent()
        {
            this.numeFisier = "utilizatori.xml";
        }

        public UtilizatorPersistent(string numeFisier)
        {
            this.numeFisier = numeFisier;
        }

        public UtilizatorPersistent(UtilizatorPersistent up)
        {
            this.numeFisier = up.numeFisier;
        }

        public string GetNumeFisier()
        {
            return numeFisier;
        }

        public void SetNumeFisier(string numeFisier)
        {
            this.numeFisier = numeFisier;
        }

        public bool AdaugareUtilizator(Utilizator utilizator)
        {
            try
            {
                XElement xElement = XElement.Load(@"utilizatori.xml");
                xElement.Add(new XElement("utilizator",
                    new XElement("nume", utilizator.GetNume()),
                    new XElement("nrLegitimatie", utilizator.GetNrLegitimatie().ToString()),
                    new XElement("cont", utilizator.GetCont()),
                    new XElement("parola", utilizator.GetParola()),
                    new XElement("rol", utilizator.GetRol())
                    ));
                xElement.Save(@"utilizatori.xml");
                return true;
            }
            catch (Exception) 
            {
                return false;
            } 
        }
        public bool StergereUtilizator(uint nrLegitimatie)
        {
            try
            {
                XDocument xDocument = XDocument.Load(@"utilizatori.xml");
                xDocument.Root.Elements("utilizator").Where(e => Convert.ToUInt16(e.Element("nrLegitimatie").Value) == nrLegitimatie).Remove();
                xDocument.Save(@"utilizatori.xml");
                return true;
            } 
            catch (Exception)
            {
                return false;
            }
        }

        public bool ActualizareUtilizator(uint nrLegitimatie, Utilizator utilizator)
        {
            try
            {
                XDocument xDocument = XDocument.Load(@"utilizatori.xml");
                var element = xDocument.Root.Elements("utilizator").Where(e => Convert.ToUInt16(e.Element("nrLegitimatie").Value) == nrLegitimatie).Single();
                element.Element("nume").Value = utilizator.GetNume();
                element.Element("cont").Value = utilizator.GetCont();
                element.Element("parola").Value = utilizator.GetParola();
                element.Element("rol").Value = utilizator.GetRol();
                xDocument.Save(@"utilizatori.xml");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Utilizator> ListaUtilizatori()
        {
            List<Utilizator> utilizatori = new List<Utilizator>();
            try
            {
                XDocument xDoc = XDocument.Load(@"utilizatori.xml");
                List<XElement> xElemente = xDoc.Root.Elements("utilizator").ToList();
                foreach (XElement xElement in xElemente)
                {
                    string nume = xElement.Element("nume").Value;
                    uint nrLegitimatie = Convert.ToUInt16(xElement.Element("nrLegitimatie").Value);
                    string cont = xElement.Element("cont").Value;
                    string parola = xElement.Element("parola").Value;
                    string rol = xElement.Element("rol").Value;
                    Utilizator utilizator = new Utilizator(nume, nrLegitimatie, cont, parola, rol);
                    utilizatori.Add(utilizator);
                }
                return utilizatori;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Utilizator> FiltrareUtilizatori(string numeUtilizator)
        {
            List<Utilizator> utilizatori = new List<Utilizator>();
            try
            {
                XDocument xDoc = XDocument.Load(@"utilizatori.xml");
                List<XElement> xElemente = xDoc.Root.Elements("utilizator").ToList();
                foreach (XElement xElement in xElemente)
                {
                    string nume = xElement.Element("nume").Value;
                    if (nume == numeUtilizator)
                    {
                        uint nrLegitimatie = Convert.ToUInt16(xElement.Element("nrLegitimatie").Value);
                        string cont = xElement.Element("cont").Value;
                        string parola = xElement.Element("parola").Value;
                        string rol = xElement.Element("rol").Value;
                        Utilizator utilizator = new Utilizator(nume, nrLegitimatie, cont, parola, rol);
                        utilizatori.Add(utilizator);
                    }
                }
                return utilizatori;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Utilizator CautareUtilizator(uint nrLegitimatieCautat)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"utilizatori.xml");
                List<XElement> xElemente = xDoc.Root.Elements("utilizator").ToList();
                foreach (XElement xElement in xElemente)
                {
                    uint nrLegitimatie = Convert.ToUInt16(xElement.Element("nrLegitimatie").Value);
                    if (nrLegitimatie == nrLegitimatieCautat)
                    {
                        string nume = xElement.Element("nume").Value;
                        string cont = xElement.Element("cont").Value;
                        string parola = xElement.Element("parola").Value;
                        string rol = xElement.Element("rol").Value;
                        Utilizator utilizator = new Utilizator(nume, nrLegitimatie, cont, parola, rol);
                        return utilizator;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Utilizator CautareUtilizator(string contCautat)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"utilizatori.xml");
                List<XElement> xElemente = xDoc.Root.Elements("utilizator").ToList();
                foreach (XElement xElement in xElemente)
                {
                    string cont = xElement.Element("cont").Value;
                    if (cont == contCautat)
                    {
                        string nume = xElement.Element("nume").Value;
                        uint nrLegitimatie = Convert.ToUInt16(xElement.Element("nrLegitimatie").Value);
                        string parola = xElement.Element("parola").Value;
                        string rol = xElement.Element("rol").Value;
                        Utilizator utilizator = new Utilizator(nume, nrLegitimatie, cont, parola, rol);
                        return utilizator;
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
