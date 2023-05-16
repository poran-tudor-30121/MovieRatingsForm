
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using static System.Net.Mime.MediaTypeNames;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Data.Common;
using System.Web.Mvc;
using System.Web.Services;
using System.Web.Services.Description;
using System.Data;

namespace MovieRatings
{
    public class MovieContext
    {
        private SQLiteConnection _connection;

        public MovieContext()
        {
            _connection = new SQLiteConnection("Data Source=D:/Facultate stuff/II/TEMA2_2/MovieRatings/movies.db;Version=3;");
            _connection.Open();
 
            InitializeDatabase();
        }
        private void InitializeDatabase()
        {
            var command0 = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Login (username TEXT PRIMARY KEY, password TEXT)", _connection);
            var command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS movies (title TEXT PRIMARY KEY, director TEXT , year INTEGER,rating NUMERIC(4,2) NULL)", _connection);
            var command1 = new SQLiteCommand("CREATE TABLE IF NOT EXISTS ratings(id INTEGER PRIMARY KEY AUTOINCREMENT, user TEXT, movie_title TEXT, rating NUMERIC(4,2) NULL,PRIMARY KEY(user, movie_title) FOREIGN KEY(movie_title) REFERENCES movies(title), FOREIGN KEY(user) REFERENCES Login(username))", _connection);
            
            command0.ExecuteNonQuery();
            command1.ExecuteNonQuery();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public List<Movie> GetMovies()
        {
            var movies = new List<Movie>();

            _connection.Open();
            using (var command = new SQLiteCommand("SELECT m.title, m.director, m.year, AVG(r.rating) as average_rating FROM movies m LEFT JOIN ratings r ON m.title = r.movie_title GROUP BY m.title, m.director, m.year", _connection))
            using (var reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    float averageRating = reader.IsDBNull(3) ? 0 : reader.GetFloat(3);
                    float roundedAverageRating = (float)Math.Round(averageRating, 2);

                    var movie = new Movie(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), averageRating);
                    movies.Add(movie);
                }
            }
            _connection.Close();
            return movies;
        }



        public void AddMovie(Movie movie)
        {
            // Movie movie = new Movie(Title, Director, Year);
            _connection.Open();
            var command = new SQLiteCommand("INSERT INTO movies (title, director, year) SELECT @title, @director, @year WHERE NOT EXISTS (SELECT 1 FROM movies WHERE title = @title)", _connection);
            command.Parameters.AddWithValue("@title", movie.Title);
            command.Parameters.AddWithValue("@director", movie.Director);
            command.Parameters.AddWithValue("@year", movie.Year);
            command.ExecuteNonQuery();
            _connection.Close();
            
        }
        public void AddRating(string movieTitle, string user, float rating)
        {
            _connection.Open();
            var command = new SQLiteCommand("INSERT OR REPLACE INTO ratings (movie_title, user, rating) VALUES (@movieTitle, @user, @rating)", _connection);
            command.Parameters.AddWithValue("@movieTitle", movieTitle);
            command.Parameters.AddWithValue("@user", user);
         
            float roundedRating = (float)Math.Round(rating, 2);
            command.Parameters.AddWithValue("@rating", roundedRating);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public bool Login(string username, string password,bool valid)
        {
            _connection.Open();
            //string username = textboxUsername.Text;
            //string password = textboxPassword.Text;
            valid = false;

            string query = "SELECT COUNT(*) FROM Login WHERE username=@username AND password=@password";
            using (SQLiteCommand command = new SQLiteCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    valid = true;
                    _connection.Close();
                    return valid;
                }
                else
                {
                    valid = false;
                        _connection.Close();
                    return valid;
                }
                
            }
            
        }
        public bool AddUser(string username, string password, bool valid)
        {
            _connection.Open();
            valid = true;
            string query = "SELECT COUNT(*) FROM Login WHERE username=@username AND password=@password";
            using (SQLiteCommand command = new SQLiteCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                username = Regex.Replace(username, @"\s", ""); // removes whitespaces
                if (!Regex.IsMatch(username, "^[a-zA-Z0-9_-]+$"))
                {
                    // Numele de utilizator nu respectă formatul dorit, afișăm un mesaj de eroare


                    valid = false;
                    _connection.Close();
                    return valid;


                }


                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    // MessageBox.Show("Login successful.");


                    valid = false;
                    _connection.Close();
                    return valid;

                }
                if (valid)
                {
                    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Login (Username, Password) VALUES ('" + username + "', '" + password + "')", _connection);
                    cmd.ExecuteNonQuery();
                    _connection.Close();
                    return valid;

                }
                _connection.Close();
                return
                    valid;
            }
        }
          
            public float GetMovieAverageRating(string movieTitle)
            {
                float averageRating = 0;
                int ratingCount = 0;

            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
            

                    using (SQLiteCommand command = new SQLiteCommand("SELECT rating FROM ratings WHERE movie_title = @title", _connection))
                    {
                        command.Parameters.AddWithValue("@title", movieTitle);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                float rating = reader.GetFloat(0);
                                averageRating += rating;
                                ratingCount++;
                            }
                        }
                    }
                

                if (ratingCount > 0)
                {
                    averageRating /= ratingCount;
                }

                // Round to 2 decimal places
                averageRating = (float)Math.Round(averageRating, 2);
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
                       return averageRating;
            }

    public void SetMovieAverageRating(string movieTitle)
        {
            var averageRating = GetMovieAverageRating(movieTitle);

            _connection.Open();
            var command = new SQLiteCommand("UPDATE movies SET rating = @averageRating WHERE title = @movieTitle", _connection);
            command.Parameters.AddWithValue("@averageRating", averageRating);
            command.Parameters.AddWithValue("@movieTitle", movieTitle);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public List<UserRating> GetUserRatings(string userName)
        {
            var ratings = new List<UserRating>();

            _connection.Open();
            using (var command = new SQLiteCommand("SELECT movie_title, rating FROM ratings WHERE user = @userName", _connection))
            {
                command.Parameters.AddWithValue("@userName", userName);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rating = new UserRating
                        {
                            MovieTitle = reader.GetString(0),
                            UserName = userName,
                            Rating = reader.GetFloat(1)
                        };
                        ratings.Add(rating);
                    }
                }
            }
            _connection.Close();
            return ratings;
        }


    }



}

