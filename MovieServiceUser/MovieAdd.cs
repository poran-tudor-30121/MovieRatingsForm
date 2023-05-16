using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieServiceUser
{
    public partial class MovieAdd : Form
    {
        private List<MovieServiceReference.Movie> movieList;
        private DataGridView dataGridView;
        MovieServiceUser.MovieServiceReference.MovieServiceSoapClient service =
               new MovieServiceUser.MovieServiceReference.MovieServiceSoapClient();
        public MovieAdd(List<MovieServiceReference.Movie> movieList, DataGridView dataGridView)
        {
            InitializeComponent();
            this.movieList = movieList;
            this.dataGridView = dataGridView;
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Get the text from the three textboxes
            string title = textboxTitle.Text;
            string director = textboxDirector.Text;
            int year = int.Parse(textboxYear.Text);

            // Create a new movie object
            MovieServiceReference.Movie newMovie = new MovieServiceReference.Movie
            {
                Title = title,
                Director = director,
                Year = year
            };

            // Add the new movie object to the list of movies
            movieList.Add(newMovie);
            try
            {
                // Call the AddMovie method in the web service
                service.AddMovie(newMovie.Title, newMovie.Director, newMovie.Year);
                Console.WriteLine("Movie added to database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding movie to database: " + ex.Message);
            }


            // Set the DataSource of the DataGridView to the updated BindingList object
            dataGridView.DataSource = movieList;

            MovieApp parentForm = (MovieApp)this.Owner;
            parentForm.UpdateDataGridView(movieList);

            // Close the MovieAdd form
            this.Close();
        }
    }
    }

