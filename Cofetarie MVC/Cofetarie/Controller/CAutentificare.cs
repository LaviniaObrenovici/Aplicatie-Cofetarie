using Cofetarie.Model;
using Cofetarie.Model.Persistenta;
using Cofetarie.View;
using System; 
using System.Windows.Forms;

namespace Cofetarie.Controller
{
    class CAutentificare
    {
        private VAutentificare vAutentificare;
        private UtilizatorPersistent utilizatorP;

        public CAutentificare()
        {
            this.vAutentificare = new VAutentificare();
            this.utilizatorP = new UtilizatorPersistent();
            this.gestionareEvenimente();
        }
        public VAutentificare GetVAutentificare()
        {
            return this.vAutentificare;
        }
        private void gestionareEvenimente()
        {
            this.vAutentificare.GetBtnLogare().Click += new EventHandler(logare);         
        }
        private void logare(object sender, EventArgs e)
        {
            string cont = this.vAutentificare.GetTxtCont().Text;
            string parola = this.vAutentificare.GetTxtParola().Text;
            Utilizator utilizator = this.utilizatorP.CautareUtilizator(cont);
            if(utilizator!=null)
            {
                if(parola==utilizator.GetParola())
                {
                    string rol = utilizator.GetRol();
                    if(rol=="admin")
                    {
                        CUtilizatori utilizatorC = new CUtilizatori(this);
                        utilizatorC.GetVUtilizatori().Visible = true;
                    }
                    else
                    {
                        CPrajituri prajituraC = new CPrajituri(this);
                        prajituraC.GetVPrajituri().Visible = true;
                    }
                    this.vAutentificare.Visible = false;
                }
                else
                {
                    MessageBox.Show("Parola incorecta!");
                }
            }
            else
            {
                MessageBox.Show("Nu s-a gasit utilizatorul precizat!");
            }
        }

    }
}
