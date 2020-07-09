using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0va_E_Learning_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate_user() == true)
            {
                MC_Item_Delivery MCD = new MC_Item_Delivery();
                MCD.Show();
                MessageBox.Show("Welcome to my Online General Knowledge Quiz! Choose your answer and click next to pass onto the following one. Once you completed all of the questions, click the submit button to confirm your choices. However, be careful: the timer running. ");
                this.Hide();
            }
        }

        private Boolean validate_user()
        {
            // this would be a db lookup and probably count three attempts before you boot them out.
            // we will just use a stub here
            return true;
        }
    }
}
