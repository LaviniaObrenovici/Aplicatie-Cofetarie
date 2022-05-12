using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cofetarie.Model;
using Cofetarie.Model.Persistenta;
using Cofetarie.View;

namespace Cofetarie.Controller
{
    class CPrajituri
    {
        private VPrajituri vPrajituri;
        private PrajituraPersistenta prajituraP;
        private CAutentificare autentificareC;

        public CPrajituri(CAutentificare ac)
        {
            this.vPrajituri = new VPrajituri();
            this.prajituraP = new PrajituraPersistenta();
            this.autentificareC = ac;
            this.gestionareEvenimente();
        }
        public VPrajituri GetVPrajituri()
        {
            return this.vPrajituri;
        }
        private void gestionareEvenimente()
        {
            this.vPrajituri.GetBtnAdaugare().Click += new EventHandler(adaugare);
            this.vPrajituri.GetBtnActualizare().Click += new EventHandler(actualizare);
            this.vPrajituri.GetBtnStergere().Click += new EventHandler(stergere);
            this.vPrajituri.GetBtnVizualizare().Click += new EventHandler(vizualizare);
            this.vPrajituri.GetBtnCautare().Click += new EventHandler(cautare);
            this.vPrajituri.GetDgvPrajituri().SelectionChanged += new EventHandler(selectie);
            this.vPrajituri.GetBtnDeconectare().Click += new EventHandler(deconectare);
        }
        private void selectie(object sender, EventArgs e)
        {
            if (this.vPrajituri.GetDgvPrajituri().SelectedRows.Count == 0)
            {
                this.vPrajituri.GetTxtDenumire().Text = "";
                this.vPrajituri.GetTxtPret().Text = "";
                this.vPrajituri.GetTxtCantitate().Text = "";
                this.vPrajituri.GetDtpValabilitate().Text = "";
            }
            else
            {
                string denumire = (string)this.vPrajituri.GetDgvPrajituri().SelectedRows[0].Cells[0].Value;
                double pret = Convert.ToDouble(this.vPrajituri.GetDgvPrajituri().SelectedRows[0].Cells[1].Value);
                uint cantitate = Convert.ToUInt16(this.vPrajituri.GetDgvPrajituri().SelectedRows[0].Cells[2].Value);
                DateTime valabilitate = Convert.ToDateTime(this.vPrajituri.GetDgvPrajituri().SelectedRows[0].Cells[3].Value);
                this.vPrajituri.GetTxtDenumire().Text = denumire;
                this.vPrajituri.GetTxtPret().Text = pret.ToString();
                this.vPrajituri.GetTxtCantitate().Text = cantitate.ToString();
                this.vPrajituri.GetDtpValabilitate().Value = valabilitate;
            }
        }
        private void adaugare(object sender, EventArgs e)
        {
            string denumire = this.vPrajituri.GetTxtDenumire().Text;
            double pret = Convert.ToDouble(this.vPrajituri.GetTxtPret().Text);
            uint cantitate = Convert.ToUInt16(this.vPrajituri.GetTxtCantitate().Text);
            DateTime valabilitate = this.vPrajituri.GetDtpValabilitate().Value;
            if (denumire.Length > 0 && pret!=0 && cantitate!=0 && valabilitate!=null)
            {
                if (this.prajituraP.CautarePrajitura(denumire) != null)
                {
                    if (prajituraP.ActualizareCantitatePrajitura(denumire, cantitate))
                    { MessageBox.Show("Adaugare incheiata cu succes!"); }
                }
                else
                {
                    Prajitura prajitura = new Prajitura(denumire, pret, cantitate, valabilitate);
                    if (this.prajituraP.AdaugarePrajitura(prajitura))
                        MessageBox.Show("Adaugare incheiata cu succes!");
                    else
                        MessageBox.Show("Nu s-a realizat adaugare in fisier!");
                }
            }
            else
                MessageBox.Show("Nu s-au introdus toate datele!");
        }
        private void actualizare(object sender, EventArgs e)
        {
            if (this.vPrajituri.GetDgvPrajituri().SelectedRows.Count == 0)
            {
                MessageBox.Show("Nu exista nicio prajitura selectata pentru a fi actualizata");
            }
            else
            {
                string denumireSelectat = (string)this.vPrajituri.GetDgvPrajituri().SelectedRows[0].Cells[0].Value;
                string denumire = this.vPrajituri.GetTxtDenumire().Text;
                double pret = Convert.ToDouble(this.vPrajituri.GetTxtPret().Text);
                uint cantitate = Convert.ToUInt16(this.vPrajituri.GetTxtCantitate().Text);
                DateTime valabilitate = this.vPrajituri.GetDtpValabilitate().Value;
                if (denumire.Length > 0 && pret!=0 && cantitate!=0)
                {
                    if (this.prajituraP.CautarePrajitura(denumireSelectat) == null)
                    {
                        MessageBox.Show("Nu exista o prajitura cu aceasta denumire!");
                    }
                    else
                    {
                        Prajitura prajitura = new Prajitura(denumire, pret, cantitate, valabilitate);
                        if (this.prajituraP.ActualizarePrajitura(denumireSelectat, prajitura))
                            MessageBox.Show("Actualizare incheiata cu succes!");
                        else
                            MessageBox.Show("Nu s-a realizat actualizare in fisier!");
                    }
                }
                else
                    MessageBox.Show("Nu s-au introdus toate datele!");
            }
        }
        private void stergere(object sender, EventArgs e)
        {
            if (this.vPrajituri.GetDgvPrajituri().SelectedRows.Count == 0)
            {
                MessageBox.Show("Nu exista nicio prajitura selectata pentru a fi stearsa");
            }
            else
            {
                string denumireSelectat = (string)this.vPrajituri.GetDgvPrajituri().SelectedRows[0].Cells[0].Value;
                uint cantitateSelectata = Convert.ToUInt16(this.vPrajituri.GetTxtCantitate().Text);
                if (this.prajituraP.StergerePrajitura(denumireSelectat, cantitateSelectata))
                    MessageBox.Show("Stergere incheiata cu succes!");
                else
                    MessageBox.Show("Nu s-a realizat stergere in fisier!");
            }
        }
        private void vizualizare(object sender, EventArgs e)
        {
            List<Prajitura> lista = this.prajituraP.ListaPrajituri();
            this.vPrajituri.GetDgvPrajituri().Rows.Clear();
            if (lista != null)
            {
                foreach (Prajitura prajitura in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.CreateCells(this.vPrajituri.GetDgvPrajituri());
                    rand.Cells[0].Value = prajitura.GetDenumire();
                    rand.Cells[1].Value = prajitura.GetPret();
                    rand.Cells[2].Value = prajitura.GetCantitate();
                    rand.Cells[3].Value = prajitura.GetValabilitate();
                    this.vPrajituri.GetDgvPrajituri().Rows.Add(rand);
                }
            }
        }
        private void cautare(object sender, EventArgs e)
        {
            int index = this.vPrajituri.GetCmbCriteriu().SelectedIndex;
            if (index >= 0)
            {
                string informatie = this.vPrajituri.GetTxtInformatie().Text;
                if (informatie.Length > 0)
                {
                    if (index == 0)
                        this.cautareDenumire(informatie);
                    else 
                        this.cautarePret(informatie);
                }
                else
                    MessageBox.Show("Nu s-a introdus informatia cautata!");
            }
            else
            {
                MessageBox.Show("Nu s-a selectat niciun un criteriu de filtrare!");
            }
        }
        private void cautarePret(string informatie)
        {
            List<Prajitura> lista = this.prajituraP.FiltrarePrajituri(Convert.ToUInt16(informatie));
            this.vPrajituri.GetDgvPrajituri().Rows.Clear();
            if (lista != null)
            {
                foreach (Prajitura prajitura in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.CreateCells(this.vPrajituri.GetDgvPrajituri());
                    rand.Cells[0].Value = prajitura.GetDenumire();
                    rand.Cells[1].Value = prajitura.GetPret();
                    rand.Cells[2].Value = prajitura.GetCantitate();
                    rand.Cells[3].Value = prajitura.GetValabilitate();
                    this.vPrajituri.GetDgvPrajituri().Rows.Add(rand);
                }
            }
        }
        private void cautareDenumire(string informatie)
        {
            Prajitura prajitura = this.prajituraP.CautarePrajitura(informatie);
            this.vPrajituri.GetDgvPrajituri().Rows.Clear();
            if (prajitura == null)
                MessageBox.Show("Nu exista nicio prajitura cu denumirea introdusa!");
            else
            {
                DataGridViewRow rand = new DataGridViewRow();
                rand.CreateCells(this.vPrajituri.GetDgvPrajituri());
                rand.Cells[0].Value = prajitura.GetDenumire();
                rand.Cells[1].Value = prajitura.GetPret();
                rand.Cells[2].Value = prajitura.GetCantitate();
                rand.Cells[3].Value = prajitura.GetValabilitate();
                this.vPrajituri.GetDgvPrajituri().Rows.Add(rand);
            }
        }
        private void deconectare(object sender, EventArgs e)
        {
            this.vPrajituri.Visible = false;
            this.autentificareC.GetVAutentificare().Visible = true;
        } 
    }
}
