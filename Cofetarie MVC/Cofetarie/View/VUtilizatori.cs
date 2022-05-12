using System.Windows.Forms;

namespace Cofetarie.View
{
    public partial class VUtilizatori : Form
    {
		public VUtilizatori()
		{
			InitializeComponent();
			this.dgvUtilizatori.AllowUserToAddRows = false;
			for (int i = 0; i < dgvUtilizatori.ColumnCount; i++)
				this.dgvUtilizatori.Columns[i].ReadOnly = true;
		}
		public TextBox GetTxtNume()
		{
			return this.txtNume;
		}
		public TextBox GetTxtnrLegitimatie()
		{
			return this.txtnrLegitimatie;
		}
		public TextBox GetTxtCont()
		{
			return this.txtCont;
		}
		public TextBox GetTxtParola()
		{
			return this.txtParola;
		}
		public ComboBox GetTxtRol()
		{
			return this.cmbRol;
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
		public DataGridView GetDgvUtilizatori()
		{
			return this.dgvUtilizatori;
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
