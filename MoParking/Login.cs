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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtLozinka.Text == "")
            {
                MessageBox.Show("Pogrešan unos!");
            }
            else
            {
                if(txtUsername.Text=="admin"&&txtLozinka.Text=="admin")
                {
                    frmAutomobili obj=new frmAutomobili();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username ili lozinka nisu ispravni!");
                    txtLozinka.Text = "";
                    txtUsername.Text = "";
                }
            }
        }
    }
}
