using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synes
{
    public partial class frmLogin : Form
    {
        string Username = "Aleco";
        string Password = "123";
        public frmLogin()
        {
            InitializeComponent();

            //replace with a reference file loc
            //just for testing rn

            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUser.Text;
            string enteredPassword = txtPass.Text;

            if (enteredUsername == null)
            {
                MessageBox.Show("PLEASE enter a username");
            }
            else if(enteredPassword == null)
            {
                MessageBox.Show("You need to enter a password :/");
            }
            else if(enteredUsername == Username & enteredPassword == Password)
            {
                frmSynes frm = new frmSynes();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong user/password cmon");
            }
        }
    }
}
