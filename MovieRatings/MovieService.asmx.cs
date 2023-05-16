using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MovieRatings
{
    /// <summary>
    /// Summary description for MovieService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MovieService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        private MovieContext _context;

        public MovieService()
        {
            _context = new MovieContext();
        }

        [WebMethod]
        public List<Movie> GetMovies()
        {
            return _context.GetMovies().ToList();
        }

        [WebMethod]
        public void AddMovie(string Title, string Director, int Year)
        {
            Movie movie = new Movie(Title, Director, Year,0);
            _context.AddMovie(movie);
        }

        [WebMethod]
        public List<Movie> SearchMovies(string title)
        {
            var movies = _context.GetMovies().Where(m => m.Title.Contains(title)).ToList();
            return movies;
        }

        [WebMethod]
        public void AddRating(string movieTitle, string user, float rating)
        {
            float roundedRating = (float)Math.Round(rating, 2);
            _context.AddRating(movieTitle, user, roundedRating);
        }

        [WebMethod]

        public bool Login(string username,string password)
        {
            return _context.Login(username, password, false);
        }

        [WebMethod]

        public bool AddUser(string username,string password)
        {
            return _context.AddUser(username, password, true);
        }

        [WebMethod]
        public float GetMovieAverageRating(string movieTitle)
        {
            return _context.GetMovieAverageRating(movieTitle);
        }

        [WebMethod]
        public void SetMovieAverageRating(string movieTitle)
        {
            _context.SetMovieAverageRating(movieTitle);
        }

        [WebMethod]

        public List<UserRating> GetUserRatings(string userName)
        {
            return _context.GetUserRatings(userName);
        }

    }
} 

