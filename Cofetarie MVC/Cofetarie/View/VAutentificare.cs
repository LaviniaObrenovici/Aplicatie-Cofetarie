using System.Windows.Forms;

namespace Cofetarie.View
{
    public partial class VAutentificare : Form
    {
        public VAutentificare()
        {
            InitializeComponent();
        }
        public TextBox GetTxtCont()
        {
            return this.txtCont;
        }
        public TextBox GetTxtParola()
        {
            return this.txtParola;
        }
        public Button GetBtnLogare()
        {
            return this.btnLogare;
        }

        private void btnLogare_Click(object sender, System.EventArgs e)
        {

        }
    }
}
