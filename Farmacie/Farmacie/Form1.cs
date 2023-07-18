using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect;

namespace Proiect
{
    public partial class Form1 : Form
    {   
        private List<Medicament>  medicamentele;
        public Form1()
        {
            InitializeComponent();
            medicamentele = new List<Medicament>();
        }

        private int verificareMedicamentTip(string numeMedicament,string tipMedicament)
        {
            foreach (Medicament medicament in medicamentele)
            {
                if(medicament.numeMedicament == numeMedicament && medicament.tipMedicament == tipMedicament) 
                
                    return 0;
            }
            return 1;
        }
        private void ClearCasete()
        {
            txtNume.Text = String.Empty;
            cmbTip.Text = "Alegeti tipul";
            dataExp.Value = DateTime.Today;
            txtPret.Text = String.Empty;

        }
        
        private bool VerificareNumar(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }

        private void txtAdaugare_Click(object sender, EventArgs e)
        {
            //uint pret = Int32.Parse(txtPret.Text);
            

            if (txtNume.Text == String.Empty || txtPret.Text == String.Empty || cmbTip.SelectedIndex == -1)
            {
                MessageBox.Show("Toate casutele sunt obligatorii", "Adaugare invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verificareMedicamentTip(txtNume.Text, cmbTip.Text) == 0)
            {
                MessageBox.Show($"Exista deja medicamentul {txtNume.Text},de tipul {cmbTip.Text} ");
            }
            else if (!VerificareNumar(txtPret.Text))
            {
                MessageBox.Show("Introduceti un numar valid pentru pret.");
            }
            else 
            {

                uint pret = uint.Parse(txtPret.Text);

                medicamentele.Add(new Medicament(txtNume.Text, cmbTip.Text, UInt32.Parse(txtPret.Text), dataExp.Value));
                ClearCasete();
            }
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            dateMedicamente.Rows.Clear();
            foreach (Medicament medicament in medicamentele)
            {
                dateMedicamente.Rows.Add(medicament.numeMedicament, medicament.tipMedicament, medicament.pret,medicament.dataExpirare.ToShortDateString());
                dateMedicamente.Visible = true;
            }
        }

        private void txtFiltrare_Click(object sender, EventArgs e)
        {
            int ok = 0;
            if (cmbTip.SelectedIndex == -1)
            {
                MessageBox.Show("Tipul nu a fost selectat", "Filtrare invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dateMedicamente.Rows.Clear();
                foreach (Medicament medicament in medicamentele)
                {
                    if (medicament.tipMedicament == cmbTip.Text)
                    {
                        dateMedicamente.Rows.Add(medicament.numeMedicament, medicament.tipMedicament, medicament.pret, medicament.dataExpirare.ToShortDateString());
                        ok = 1;
                    }
                    else continue;
                }
                if (ok == 0)
                    MessageBox.Show("Nu s-a gasit nici un medicament dupa tipul cautat", "Filtrare invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
