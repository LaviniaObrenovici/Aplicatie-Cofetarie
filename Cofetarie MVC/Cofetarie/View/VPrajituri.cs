using System.Windows.Forms;

namespace Cofetarie.View
{
    public partial class VPrajituri : Form
    {
        public VPrajituri()
        {
            InitializeComponent();
            this.dgvPrajituri.AllowUserToAddRows = false;
            for (int i = 0; i < dgvPrajituri.ColumnCount; i++)
                this.dgvPrajituri.Columns[i].ReadOnly = true;
        }
		public TextBox GetTxtDenumire()
		{
			return this.txtDenumire;
		}
		public TextBox GetTxtPret()
		{
			return this.txtPret;
		}
		public TextBox GetTxtCantitate()
		{
			return this.txtCantitate;
		}
		public DateTimePicker GetDtpValabilitate()
		{
			return this.dtpValabilitate;
		}
		public TextBox GetTxtInformatie()
		{
			return this.txtInformatie;
		}
		public Button GetBtnAdaugare()
		{
			return this.btnAdaugare;
		}
		public Button GetBtnActualizare()
		{
			return this.btnActualizare;
		}
		public Button GetBtnStergere()
		{
			return this.btnStergere;
		}
		public Button GetBtnVizualizare()
		{
			return this.btnVizualizare;
		}
		public DataGridView GetDgvPrajituri()
		{
			return this.dgvPrajituri;
		}
		public Button GetBtnCautare()
		{
			return this.btnCautare;
		}
		public ComboBox GetCmbCriteriu()
		{
			return this.cmbCriteriu;
		}
		public Button GetBtnDeconectare()
		{
			return this.btnDeconectare;
		} 
	}
}
