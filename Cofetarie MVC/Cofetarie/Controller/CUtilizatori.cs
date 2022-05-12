using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cofetarie.Model;
using Cofetarie.Model.Persistenta;
using Cofetarie.View;

namespace Cofetarie.Controller
{
    class CUtilizatori
    {
        private VUtilizatori vUtilizatori;
        private UtilizatorPersistent utilizatorP;
        private CAutentificare autentificareC;

        public CUtilizatori(CAutentificare ac)
        {
            this.vUtilizatori = new VUtilizatori();
            this.utilizatorP = new UtilizatorPersistent();
            this.autentificareC = ac;
            this.gestionareEvenimente();
        }
        public VUtilizatori GetVUtilizatori()
        {
            return this.vUtilizatori;
        }
        private void gestionareEvenimente()
        {
            this.vUtilizatori.GetBtnAdaugare().Click += new EventHandler(adaugare);
            this.vUtilizatori.GetBtnActualizare().Click += new EventHandler(actualizare);
            this.vUtilizatori.GetBtnStergere().Click += new EventHandler(stergere);
            this.vUtilizatori.GetBtnVizualizare().Click += new EventHandler(vizualizare);
            this.vUtilizatori.GetBtnCautare().Click += new EventHandler(cautare);
            this.vUtilizatori.GetDgvUtilizatori().SelectionChanged += new EventHandler(selectie);
            this.vUtilizatori.GetBtnDeconectare().Click += new EventHandler(deconectare);
        }
        private void selectie(object sender, EventArgs e)
        {
            if (this.vUtilizatori.GetDgvUtilizatori().SelectedRows.Count == 0)
            {
                this.vUtilizatori.GetTxtNume().Text = "";
                this.vUtilizatori.GetTxtnrLegitimatie().Text = "";
                this.vUtilizatori.GetTxtCont().Text = "";
                this.vUtilizatori.GetTxtParola().Text = "";
                this.vUtilizatori.GetTxtRol().Text = "";
            }
            else
            {
                string nume = (string)this.vUtilizatori.GetDgvUtilizatori().SelectedRows[0].Cells[0].Value;
                uint nrLegitimatie = Convert.ToUInt16(this.vUtilizatori.GetDgvUtilizatori().SelectedRows[0].Cells[1].Value);
                string cont = (string)this.vUtilizatori.GetDgvUtilizatori().SelectedRows[0].Cells[2].Value;
                string parola = (string)this.vUtilizatori.GetDgvUtilizatori().SelectedRows[0].Cells[3].Value;
                string rol = (string)this.vUtilizatori.GetDgvUtilizatori().SelectedRows[0].Cells[4].Value;
                this.vUtilizatori.GetTxtNume().Text = nume;
                this.vUtilizatori.GetTxtnrLegitimatie().Text = nrLegitimatie.ToString();
                this.vUtilizatori.GetTxtCont().Text = cont;
                this.vUtilizatori.GetTxtParola().Text = parola;
                this.vUtilizatori.GetTxtRol().Text = rol;
            }
        }
        private void adaugare(object sender, EventArgs e)
        {
            string nume = this.vUtilizatori.GetTxtNume().Text;
            uint nrLegitimatie = Convert.ToUInt16(this.vUtilizatori.GetTxtnrLegitimatie().Text);
            string cont = this.vUtilizatori.GetTxtCont().Text;
            string parola = this.vUtilizatori.GetTxtParola().Text;
            string rol = this.vUtilizatori.GetTxtRol().Text;

            if (nume.Length > 0  && cont.Length>0 && parola.Length>0 && rol.Length>0)
            {
                if (this.utilizatorP.CautareUtilizator(nrLegitimatie) != null)
                {
                    MessageBox.Show("Exista deja un utilizator cu acest numar de legitimatie!");
                }
                else if(this.utilizatorP.CautareUtilizator(cont) != null)
                    {
                        MessageBox.Show("Exista deja un utilizator cu acest nume de cont!");
                    }             
                else
                {
                    Utilizator utilizator = new Utilizator(nume, nrLegitimatie, cont, parola, rol);
                    if (this.utilizatorP.AdaugareUtilizator(utilizator))
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
            if (this.vUtilizatori.GetDgvUtilizatori().SelectedRows.Count == 0)
            {
                MessageBox.Show("Nu exista niciun utilizator selectat pentru a fi actualizat");
            }
            else
            {
                uint nrLegitimatieSelectat = Convert.ToUInt16(this.vUtilizatori.GetDgvUtilizatori().SelectedRows[0].Cells[1].Value);
                string nume = this.vUtilizatori.GetTxtNume().Text;
                uint nrLegitimatie = Convert.ToUInt16(this.vUtilizatori.GetTxtnrLegitimatie().Text);
                string cont = this.vUtilizatori.GetTxtCont().Text;
                string parola = this.vUtilizatori.GetTxtParola().Text;
                string rol = this.vUtilizatori.GetTxtRol().Text;
                if (nume.Length > 0 && cont.Length > 0 && parola.Length > 0 && rol.Length > 0)
                {
                    if (this.utilizatorP.CautareUtilizator(nrLegitimatieSelectat) == null)
                    {
                        MessageBox.Show("Nu exista un utilizator cu acest numar de legitimatie!");
                    }
                    else
                    {
                        Utilizator utilizator = new Utilizator(nume, nrLegitimatie, cont, parola, rol);
                        if (this.utilizatorP.ActualizareUtilizator(nrLegitimatieSelectat, utilizator))
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
            if (this.vUtilizatori.GetDgvUtilizatori().SelectedRows.Count == 0)
            {
                MessageBox.Show("Nu exista niciun utilizator selectat pentru a fi sters");
            }
            else
            {
                uint nrLegitimatieSelectat = Convert.ToUInt16(this.vUtilizatori.GetDgvUtilizatori().SelectedRows[0].Cells[1].Value);
                if (this.utilizatorP.StergereUtilizator(nrLegitimatieSelectat))
                    MessageBox.Show("Stergere incheiata cu succes!");
                else
                    MessageBox.Show("Nu s-a realizat stergere in fisier!");
            }
        }
        private void vizualizare(object sender, EventArgs e)
        {
            List<Utilizator> lista = this.utilizatorP.ListaUtilizatori();
            this.vUtilizatori.GetDgvUtilizatori().Rows.Clear();
            if (lista != null)
            {
                foreach (Utilizator utilizator in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.CreateCells(this.vUtilizatori.GetDgvUtilizatori());
                    rand.Cells[0].Value = utilizator.GetNume();
                    rand.Cells[1].Value = utilizator.GetNrLegitimatie();
                    rand.Cells[2].Value = utilizator.GetCont();
                    rand.Cells[3].Value = utilizator.GetParola();
                    rand.Cells[4].Value = utilizator.GetRol();
                    this.vUtilizatori.GetDgvUtilizatori().Rows.Add(rand);
                }
            }
        }
        private void cautare(object sender, EventArgs e)
        {
            int index = this.vUtilizatori.GetCmbCriteriu().SelectedIndex;
            if (index >= 0)
            {
                string informatie = this.vUtilizatori.GetTxtInformatie().Text;
                if (informatie.Length > 0)
                {
                    if (index == 0)
                        this.cautareNume(informatie);
                    else 
                        this.cautareNrLegitimatie(informatie);           
                }
                else
                    MessageBox.Show("Nu s-a introdus informatia cautata!");
            }
            else
            {
                MessageBox.Show("Nu s-a selectat niciun un criteriu de filtrare!");
            }
        }

        private void cautareNume(string informatie)
        {
            List<Utilizator> lista = this.utilizatorP.FiltrareUtilizatori(informatie);
            this.vUtilizatori.GetDgvUtilizatori().Rows.Clear();
            if (lista != null)
            {
                foreach (Utilizator utilizator in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.CreateCells(this.vUtilizatori.GetDgvUtilizatori());
                    rand.Cells[0].Value = utilizator.GetNume();
                    rand.Cells[1].Value = utilizator.GetNrLegitimatie();
                    rand.Cells[2].Value = utilizator.GetCont();
                    rand.Cells[3].Value = utilizator.GetParola();
                    rand.Cells[4].Value = utilizator.GetRol();
                    this.vUtilizatori.GetDgvUtilizatori().Rows.Add(rand);
                }
            }
        }
        private void cautareNrLegitimatie(string informatie)
        {
            Utilizator utilizator = this.utilizatorP.CautareUtilizator(Convert.ToUInt16(informatie));
            this.vUtilizatori.GetDgvUtilizatori().Rows.Clear();
            if (utilizator == null)
                MessageBox.Show("Nu exista niciun utilizator cu numarul de legitimatie introdus!");
            else
            {
                DataGridViewRow rand = new DataGridViewRow();
                rand.CreateCells(this.vUtilizatori.GetDgvUtilizatori());
                rand.Cells[0].Value = utilizator.GetNume();
                rand.Cells[1].Value = utilizator.GetNrLegitimatie();
                rand.Cells[2].Value = utilizator.GetCont();
                rand.Cells[3].Value = utilizator.GetParola();
                rand.Cells[4].Value = utilizator.GetRol();
                this.vUtilizatori.GetDgvUtilizatori().Rows.Add(rand);
            }
        }
        private void deconectare(object sender, EventArgs e)
        {
            this.vUtilizatori.Visible = false;
            this.autentificareC.GetVAutentificare().Visible = true;
        }
    }
}
