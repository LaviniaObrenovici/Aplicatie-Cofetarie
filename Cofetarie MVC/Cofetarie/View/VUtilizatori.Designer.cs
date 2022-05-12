
namespace Cofetarie.View
{
    partial class VUtilizatori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUtilizatori = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnVizualizare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInformatie = new System.Windows.Forms.TextBox();
            this.cmbCriteriu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCautare = new System.Windows.Forms.Button();
            this.btnDeconectare = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnrLegitimatie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUtilizatori
            // 
            this.dgvUtilizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilizatori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvUtilizatori.Location = new System.Drawing.Point(66, 61);
            this.dgvUtilizatori.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUtilizatori.Name = "dgvUtilizatori";
            this.dgvUtilizatori.RowHeadersWidth = 51;
            this.dgvUtilizatori.Size = new System.Drawing.Size(786, 185);
            this.dgvUtilizatori.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nume";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NrLegitimatie";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cont";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Parola";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Rol";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA UTILIZATORI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(104, 272);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(110, 42);
            this.btnAdaugare.TabIndex = 2;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            // 
            // btnStergere
            // 
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.Location = new System.Drawing.Point(238, 274);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(4);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(112, 40);
            this.btnStergere.TabIndex = 3;
            this.btnStergere.Text = "Sterge";
            this.btnStergere.UseVisualStyleBackColor = true;
            // 
            // btnActualizare
            // 
            this.btnActualizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizare.Location = new System.Drawing.Point(383, 276);
            this.btnActualizare.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(156, 40);
            this.btnActualizare.TabIndex = 4;
            this.btnActualizare.Text = "Actualizeaza";
            this.btnActualizare.UseVisualStyleBackColor = true;
            // 
            // btnVizualizare
            // 
            this.btnVizualizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVizualizare.Location = new System.Drawing.Point(567, 278);
            this.btnVizualizare.Margin = new System.Windows.Forms.Padding(4);
            this.btnVizualizare.Name = "btnVizualizare";
            this.btnVizualizare.Size = new System.Drawing.Size(148, 38);
            this.btnVizualizare.TabIndex = 5;
            this.btnVizualizare.Text = "Vizualizeaza";
            this.btnVizualizare.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "NUME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 449);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "CONT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 489);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "PAROLA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 530);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "ROL";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(185, 362);
            this.txtNume.Margin = new System.Windows.Forms.Padding(4);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(132, 22);
            this.txtNume.TabIndex = 11;
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(185, 453);
            this.txtCont.Margin = new System.Windows.Forms.Padding(4);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(132, 22);
            this.txtCont.TabIndex = 12;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(185, 493);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(132, 22);
            this.txtParola.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(411, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "INFORMATIE CAUTATA";
            // 
            // txtInformatie
            // 
            this.txtInformatie.Location = new System.Drawing.Point(677, 449);
            this.txtInformatie.Name = "txtInformatie";
            this.txtInformatie.Size = new System.Drawing.Size(175, 22);
            this.txtInformatie.TabIndex = 17;
            // 
            // cmbCriteriu
            // 
            this.cmbCriteriu.FormattingEnabled = true;
            this.cmbCriteriu.Items.AddRange(new object[] {
            "Nume",
            "Legitimatie"});
            this.cmbCriteriu.Location = new System.Drawing.Point(677, 395);
            this.cmbCriteriu.Name = "cmbCriteriu";
            this.cmbCriteriu.Size = new System.Drawing.Size(174, 24);
            this.cmbCriteriu.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(411, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "CRITERIU DE CAUTARE";
            // 
            // btnCautare
            // 
            this.btnCautare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautare.Location = new System.Drawing.Point(752, 276);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(99, 40);
            this.btnCautare.TabIndex = 20;
            this.btnCautare.Text = "Cauta";
            this.btnCautare.UseVisualStyleBackColor = true;
            // 
            // btnDeconectare
            // 
            this.btnDeconectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconectare.Location = new System.Drawing.Point(704, 515);
            this.btnDeconectare.Name = "btnDeconectare";
            this.btnDeconectare.Size = new System.Drawing.Size(148, 43);
            this.btnDeconectare.TabIndex = 21;
            this.btnDeconectare.Text = "Deconectare";
            this.btnDeconectare.UseVisualStyleBackColor = true;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "admin",
            "angajat"});
            this.cmbRol.Location = new System.Drawing.Point(185, 534);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(132, 24);
            this.cmbRol.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "LEGITIMATIE";
            // 
            // txtnrLegitimatie
            // 
            this.txtnrLegitimatie.Location = new System.Drawing.Point(185, 402);
            this.txtnrLegitimatie.Margin = new System.Windows.Forms.Padding(4);
            this.txtnrLegitimatie.Name = "txtnrLegitimatie";
            this.txtnrLegitimatie.Size = new System.Drawing.Size(132, 22);
            this.txtnrLegitimatie.TabIndex = 15;
            // 
            // VUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 579);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.btnDeconectare);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCriteriu);
            this.Controls.Add(this.txtInformatie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnrLegitimatie);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVizualizare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUtilizatori);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VUtilizatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilizatori";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUtilizatori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnVizualizare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInformatie;
        private System.Windows.Forms.ComboBox cmbCriteriu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Button btnDeconectare;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnrLegitimatie;
    }
}