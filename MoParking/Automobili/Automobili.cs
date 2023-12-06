using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo_Parking
{
    public partial class frmAutomobili : Form
    {
        Funkcije Con;
        public frmAutomobili()
        {
            InitializeComponent();
            Con = new Funkcije();
            PrikaziVozila();
        }
        private void PrikaziVozila()
        {
            string Query = " select * from VozilaTable";
            dgvVozila.DataSource = Con.GetData(Query);
        }
        private void btnDodajVozilo_Click_1(object sender, EventArgs e)
        {
            if (txtTablice.Text == "" || txtIme.Text == "" || txtPrezime.Text == "" || txtTelefon.Text == "" || txtBojaVozila.Text == "" || txtTipVozila.Text == "")
            {
                MessageBox.Show("Pogrešan unos!");
            }
            else
            {
                try
                {
                    string BrojTablica = txtTablice.Text;
                    string Ime = txtIme.Text;
                    string Prezime = txtPrezime.Text;
                    string BrojTelefona = txtTelefon.Text;
                    string TipVozila = txtTipVozila.Text;
                    string BojaVozila = txtBojaVozila.Text;
                    string Query = "insert into VozilaTable values ('{0}','{1}','{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, BrojTablica, Ime, Prezime, BrojTelefona, TipVozila, BojaVozila);
                    Con.SetData(Query);
                    MessageBox.Show("Vozilo uspješno pohranjeno.");
                    PrikaziVozila();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int key = 0;
        private void dgvVozila_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtTablice.Text = dgvVozila.SelectedRows[0].Cells[1].Value.ToString();
            txtIme.Text = dgvVozila.SelectedRows[0].Cells[2].Value.ToString();
            txtPrezime.Text = dgvVozila.SelectedRows[0].Cells[3].Value.ToString();
            txtTelefon.Text = dgvVozila.SelectedRows[0].Cells[4].Value.ToString();
            txtTipVozila.Text = dgvVozila.SelectedRows[0].Cells[5].Value.ToString();
            txtBojaVozila.Text = dgvVozila.SelectedRows[0].Cells[6].Value.ToString();
            if (txtTablice.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvVozila.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void btnUrediVozilo_Click_1(object sender, EventArgs e)
        {
            if (txtTablice.Text == "" || txtIme.Text == "" || txtPrezime.Text == "" || txtTelefon.Text == "" || txtBojaVozila.Text == "" || txtTipVozila.Text == "")
            {
                MessageBox.Show("Pogrešan unos!");
            }
            else
            {
                try
                {
                    string BrojTablica = txtTablice.Text;
                    string Ime = txtIme.Text;
                    string Prezime = txtPrezime.Text;
                    string BrojTelefona = txtTelefon.Text;
                    string TipVozila = txtTipVozila.Text;
                    string BojaVozila = txtBojaVozila.Text;
                    string Query = "update VozilaTable set BrojTablica = '{0}',Ime='{1}',Prezime = '{2}',Telefon = '{3}', TipVozila = '{4}',BojaVozila = '{5}' where IdVozila = {6}";
                    Query = string.Format(Query, BrojTablica, Ime, Prezime, BrojTelefona, TipVozila, BojaVozila, key);
                    Con.SetData(Query);
                    MessageBox.Show("Podaci o vozilu su uspješno uređeni.");
                    PrikaziVozila();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUkloniVozilo_Click_1(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Odaberite vozilo.");
            }
            else
            {
                try
                {
                    string Query = "delete from VozilaTable where IdVozila = {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    MessageBox.Show("Vozilo obrisano!");
                    PrikaziVozila();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Parking parking = new Parking();
            parking.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Lokacije lokacije=new Lokacije();
            lokacije.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
