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
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace MovieServiceUser
{
    public partial class CreateUser : Form
    {
        MovieServiceUser.MovieServiceReference.MovieServiceSoapClient service =
                new MovieServiceUser.MovieServiceReference.MovieServiceSoapClient();

        public CreateUser()
        {
            InitializeComponent();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string username = textboxUsername.Text;
            string password = textboxPassword.Text;
            bool valid = service.AddUser(username, password);

            if (valid)
            {
                MessageBox.Show("User-ul a fost adaugat cu succes");
            }
            else
                MessageBox.Show("User invalid");
            
            

            
        }
    }
}
