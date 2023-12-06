using System;
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
    public partial class Lokacije : Form
    {
        Funkcije Con;
        public Lokacije()
        {
            InitializeComponent();
            Con=new Funkcije();
            PrikaziMjesta();
        }
        private void PrikaziMjesta()
        {
            string Query = " select * from LokacijeTable";
            dgvMjesta.DataSource = Con.GetData(Query);
        }
        private void btnDodajMjesto_Click(object sender, EventArgs e)
        {
            if(txtParkingMjesto.Text==""|| cmbStatus.SelectedIndex== -1)
            {
                MessageBox.Show("Pogrešan unos!");
            }
            else
            {
                try
                {
                    string Mjesto = txtParkingMjesto.Text;
                    string Status=cmbStatus.SelectedItem.ToString();
                    string Query = "insert into LokacijeTable values ('{0}','{1}')";
                    Query=string.Format(Query, Mjesto, Status);
                    Con.SetData(Query);
                    MessageBox.Show("Parking mjesto uspješno uneseno.");
                    PrikaziMjesta();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        int key = 0;
        private void dgvMjesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtParkingMjesto.Text = dgvMjesta.SelectedRows[0].Cells[1].Value.ToString();
            cmbStatus.SelectedItem= dgvMjesta.SelectedRows[0].Cells[2].Value.ToString();
            if (txtParkingMjesto.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvMjesta.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void btnUrediMjesto_Click(object sender, EventArgs e)
        {
            if (txtParkingMjesto.Text == "" || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite parking mjesto!");
            }
            else
            {
                try
                {
                    string Mjesto = txtParkingMjesto.Text;
                    string Status=cmbStatus.SelectedItem.ToString();
                    string Query = "update LokacijeTable set Lokacija = '{0}',Status = '{1}' where BrojParkinga = {2}";
                    Query = string.Format(Query,Mjesto,Status, key);
                    Con.SetData(Query);
                    MessageBox.Show("Parking mjesto uređeno.");
                    PrikaziMjesta();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUkloniMjesto_Click(object sender, EventArgs e)
        {
            if(txtParkingMjesto.Text==""||  cmbStatus.SelectedIndex ==-1)
            {
                MessageBox.Show("Odaberi parking mjesto!");
            }
            else
            {
                try
                {
                    string Mjesto = txtParkingMjesto.Text;
                    string Status=cmbStatus.SelectedItem.ToString();
                    string Query = "delete from LokacijeTable where BrojParkinga = {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    MessageBox.Show("Parking mjesto uklonjeno.");
                    PrikaziMjesta();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Lokacije_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Parking obj=new Parking();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmAutomobili frmAutomobili = new frmAutomobili();
            frmAutomobili.Show();
            this.Hide(); 
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
