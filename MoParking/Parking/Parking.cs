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
    public partial class Parking : Form
    {
        public Parking()
        {
            InitializeComponent();
            Con=new Funkcije();
            GetVozila();
            GetMjesta();
            PrikaziRezervacije();
        }
        Funkcije Con;
        private void GetVozila()
        {
            string Query = "select * from VozilaTable";
            cmbVozilo.ValueMember = Con.GetData(Query).Columns["IdVozila"].ToString();
            cmbVozilo.DisplayMember = Con.GetData(Query).Columns["BrojTablica"].ToString();
            cmbVozilo.DataSource = Con.GetData(Query);
        }
        private void GetMjesta()
        {
            string PStat = "Slobodno";
            string Query = "select * from LokacijeTable where Status='{0}'";
            Query = string.Format(Query, PStat);
            cmbMjesto.ValueMember = Con.GetData(Query).Columns["BrojParkinga"].ToString();
            cmbMjesto.DisplayMember = Con.GetData(Query).Columns["Lokacija"].ToString();
            cmbMjesto.DataSource = Con.GetData(Query);
        }
        private void PrikaziRezervacije()
        {
            string Query = "select * from ParkingTable";
            dgvParking.DataSource=Con.GetData(Query);
        }
        private void UpdateStatus()
        {
            try
            {
                string PStat = "Zauzeto";
                string Mjesto=cmbMjesto.SelectedValue.ToString();
                string Query = "update LokacijeTable set Status='{0}' where BrojParkinga='{1}'";
                Query=string.Format(Query,PStat,Mjesto);
                Con.SetData(Query); 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);    
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            if (cmbVozilo.SelectedIndex == -1 || cmbMjesto.SelectedIndex == -1 || txtTrajanje.Text == "" || txtIznos.Text == "")
            {
                MessageBox.Show("Pogrešan unos!");
            }
            else
            {
                try
                {

                    string Vozilo = cmbVozilo.SelectedValue.ToString();
                    string Mjesto = cmbMjesto.SelectedValue.ToString();
                    int Iznos = Convert.ToInt32(txtIznos.Text);
                    string Trajanje = txtTrajanje.Text;
                    string Query = "insert into ParkingTable values('{0}','{1}',{2},{3},'{4}')";
                    Query = string.Format(Query, Vozilo, System.DateTime.Today.ToString(), Trajanje, Iznos, Mjesto);
                    Con.SetData(Query);
                    MessageBox.Show("Parking mjesto uspješno rezervisano.");
                    PrikaziRezervacije();
                    UpdateStatus();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmAutomobili automobli =new frmAutomobili();
            automobli.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Lokacije lokacije =new Lokacije();
            lokacije.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login obj=new Login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
