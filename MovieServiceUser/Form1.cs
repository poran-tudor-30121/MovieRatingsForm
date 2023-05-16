using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace MovieServiceUser
{
    public partial class Form1 : Form
    {
        MovieServiceUser.MovieServiceReference.MovieServiceSoapClient service =
                new MovieServiceUser.MovieServiceReference.MovieServiceSoapClient();
        // DataSet dsLogin;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            Form createAdmin = new CreateUser();
            
            createAdmin.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            string username = textboxUsername.Text;
            string password = textboxPassword.Text;

           
            bool valid = service.Login(username, password);

            if (valid)
            {
               // MessageBox.Show("User logat");
                MovieApp movieApp = new MovieApp(username);
                movieApp.Show();
                this.Hide();
                

            }
            else
                MessageBox.Show("Parola sau User invalid");

            
        }
    }
}
