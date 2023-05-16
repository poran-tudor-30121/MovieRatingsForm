using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MovieConsoleAppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoapClient service =
                new MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoapClient();

            MovieServiceReference1.Movie[] movieArray = service.GetMovies();

            // Convert the array to a list
            List<MovieServiceReference1.Movie> movies = movieArray.ToList();
            foreach (var movie in movies)
            Console.WriteLine(movie.Title);
            Console.ReadLine();
        }
    }
}
