namespace Proiect
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.dateMedicamente = new System.Windows.Forms.DataGridView();
            this.txtAdaugare = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.txtFiltrare = new System.Windows.Forms.Button();
            this.dataExp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataExpirare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dateMedicamente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pret";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(225, 32);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 3;
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Items.AddRange(new object[] {
            "Flacon",
            "Plic",
            "Tableta"});
            this.cmbTip.Location = new System.Drawing.Point(225, 76);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(121, 24);
            this.cmbTip.TabIndex = 4;
            this.cmbTip.Text = "Alegeti tipul";
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(225, 118);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(100, 22);
            this.txtPret.TabIndex = 5;
            // 
            // dateMedicamente
            // 
            this.dateMedicamente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateMedicamente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateMedicament,
            this.tipMedicament,
            this.pret,
            this.DataExpirare});
            this.dateMedicamente.Location = new System.Drawing.Point(552, 12);
            this.dateMedicamente.Name = "dateMedicamente";
            this.dateMedicamente.RowHeadersWidth = 51;
            this.dateMedicamente.RowTemplate.Height = 24;
            this.dateMedicamente.Size = new System.Drawing.Size(709, 283);
            this.dateMedicamente.TabIndex = 6;
            // 
            // txtAdaugare
            // 
            this.txtAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdaugare.Location = new System.Drawing.Point(42, 328);
            this.txtAdaugare.Name = "txtAdaugare";
            this.txtAdaugare.Size = new System.Drawing.Size(130, 59);
            this.txtAdaugare.TabIndex = 7;
            this.txtAdaugare.Text = "Adaugare";
            this.txtAdaugare.UseVisualStyleBackColor = true;
            this.txtAdaugare.Click += new System.EventHandler(this.txtAdaugare_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisare.Location = new System.Drawing.Point(197, 328);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(139, 59);
            this.btnAfisare.TabIndex = 8;
            this.btnAfisare.Text = "Afiseaza";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // txtFiltrare
            // 
            this.txtFiltrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrare.Location = new System.Drawing.Point(361, 328);
            this.txtFiltrare.Name = "txtFiltrare";
            this.txtFiltrare.Size = new System.Drawing.Size(123, 59);
            this.txtFiltrare.TabIndex = 9;
            this.txtFiltrare.Text = "Filtreaza";
            this.txtFiltrare.UseVisualStyleBackColor = true;
            this.txtFiltrare.Click += new System.EventHandler(this.txtFiltrare_Click);
            // 
            // dataExp
            // 
            this.dataExp.Location = new System.Drawing.Point(225, 161);
            this.dataExp.Name = "dataExp";
            this.dataExp.Size = new System.Drawing.Size(200, 22);
            this.dataExp.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data de expirare";
            // 
            // dateMedicament
            // 
            this.dateMedicament.HeaderText = "Nume";
            this.dateMedicament.MinimumWidth = 6;
            this.dateMedicament.Name = "dateMedicament";
            this.dateMedicament.Width = 125;
            // 
            // tipMedicament
            // 
            this.tipMedicament.HeaderText = "Tip";
            this.tipMedicament.MinimumWidth = 6;
            this.tipMedicament.Name = "tipMedicament";
            this.tipMedicament.Width = 125;
            // 
            // pret
            // 
            this.pret.HeaderText = "Pret";
            this.pret.MinimumWidth = 6;
            this.pret.Name = "pret";
            this.pret.Width = 125;
            // 
            // DataExpirare
            // 
            this.DataExpirare.HeaderText = "Data de expirare";
            this.DataExpirare.MinimumWidth = 6;
            this.DataExpirare.Name = "DataExpirare";
            this.DataExpirare.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 547);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataExp);
            this.Controls.Add(this.txtFiltrare);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.txtAdaugare);
            this.Controls.Add(this.dateMedicamente);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dateMedicamente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.DataGridView dateMedicamente;
        private System.Windows.Forms.Button txtAdaugare;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button txtFiltrare;
        private System.Windows.Forms.DateTimePicker dataExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataExpirare;
    }
}

