using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Client
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login Client = new Login();
            Client.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
        public void BindData()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=Projekti2;password=4939");
            con.Open();

            MySqlCommand cmd = new MySqlCommand("select * from signupt", con);

        }
    }
}
