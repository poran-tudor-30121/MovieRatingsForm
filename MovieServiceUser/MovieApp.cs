using MovieServiceUser.MovieServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieServiceUser
{
    public partial class MovieApp : Form
    {
        MovieServiceUser.MovieServiceReference.MovieServiceSoapClient service =
                new MovieServiceUser.MovieServiceReference.MovieServiceSoapClient();
        private List<MovieServiceReference.Movie> movies;
        private string currentUser;
        public MovieApp(string username)
        {
            InitializeComponent();
            currentUser = username;
            label1.Text = username + "'s Ratings ";
           
            MovieServiceReference.Movie[] movieArray = service.GetMovies();

            // Convert the array to a list
            movies = movieArray.ToList();
           


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Title", DataPropertyName = "Title" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Director", DataPropertyName = "Director" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Year", DataPropertyName = "Year" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Rating", DataPropertyName = "Rating" });
            dataGridView1.DataSource = movies;
            dataGridView1.Refresh();

            dataGridView1.ReadOnly = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = false;
            }
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            //dataGridView1.Dock = DockStyle.Fill;


            var userRatings = service.GetUserRatings(currentUser);

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Movie Title", DataPropertyName = "MovieTitle" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Rating", DataPropertyName = "Rating" });
            dataGridView2.DataSource = userRatings;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;

            dataGridView2.Refresh();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieServiceReference.Movie[] movieArray = service.GetMovies();

            // Convert the array to a list
            movies = movieArray.ToList();

            MovieAdd movieAddForm = new MovieAdd(movies,dataGridView1);
            movieAddForm.Owner = this;

            // Show the MovieAdd form
            movieAddForm.ShowDialog();

            // Refresh the DataGridView after the MovieAdd form is closed
            dataGridView1.Refresh();


        }
        public void UpdateDataGridView(List<MovieServiceReference.Movie> movieList)
        {
            dataGridView1.DataSource = movieList;
            dataGridView1.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            float rating = float.Parse(textboxRating.Text);
            float roundedRating = (float)Math.Round(rating, 2);
            string selectedMovieTitle = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            service.AddRating(selectedMovieTitle, currentUser, roundedRating);
         
            MessageBox.Show("Rating adaugat cu succes");
            // Call the GetMovieRatings method to retrieve the updated movie rating
            float updatedRating = service.GetMovieAverageRating(selectedMovieTitle);
            service.SetMovieAverageRating(selectedMovieTitle);
            // Update the movie rating in the dataGridView
            dataGridView1.SelectedRows[0].Cells[3].Value = updatedRating;
            UpdateDataGridView(movies);
            List<UserRating> userRatings = service.GetUserRatings(currentUser).ToList();
            dataGridView2.DataSource = userRatings;
            dataGridView2.Refresh();
        }
    }
}
