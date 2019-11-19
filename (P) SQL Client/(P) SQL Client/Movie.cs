using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__SQL_Client
{
    class Movie
    {
        public int movieId { get; set; }
        public int duration { get; set; }
        public int gross { get; set; }
        public string genres { get; set; }
        public string title { get; set; }
        public string imdb { get; set; }

        public Movie()
        {
            movieId = 0;
            duration = 0;
            gross = 0;
            genres = "";
            title = "";
            imdb = "";
        }

        public override string ToString()
        {
            return $"Movie: {movieId} " +
                   $"Duration: {duration} minutes " +
                   $"Gross: {gross.ToString("C2")} " +
                   $"Genres: {genres} " +
                   $"Title: {title} " +
                   $"IMDB Link: {imdb} ";   
        }

    }
}
