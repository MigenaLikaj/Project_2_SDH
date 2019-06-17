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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            SignUp Client = new SignUp();
            Client.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "server=localhost;port=3306;user id=root;password=4939";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand SelectCommand = new MySqlCommand("select * from project2.project2sdh where username='" + this.txtUsernameL.Text + "' and password='" + this.txtPasswordL.Text + "' ;", myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Username and password is correct");

                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username or Password...Access");
                }
                else
                    MessageBox.Show("Username and password is NOT correct..Please try again");
                myConn.Close();
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

