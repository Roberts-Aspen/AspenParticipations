using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//Aspen Roberts
namespace _P__SQL_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var connectionString = "Data Source = tcp:s13.winhost.com; Initial Catalog = DB_128040_practice; User ID = DB_128040_practice_user; Password = test123; Integrated Security = False;";
            using (var connection = new SqlConnection())
            {

                connection.ConnectionString = connectionString;

                connection.Open();

                using (var command = connection.CreateCommand())

                {
                    //                                 0          1       2      3           4             5
                    command.CommandText = "SELECT   Movie_Id, duration, gross, genres, movie_title, movie_imdb_link " +
                                          "FROM     Movie";

                    

                    using (var reader = command.ExecuteReader())

                    {

                        while (reader.Read())

                        {
                            Movie awesomeMovie = new Movie();
                            awesomeMovie.movieId = Convert.ToInt32(reader[0]);
                            awesomeMovie.duration = Convert.ToInt32(reader[1]);
                            awesomeMovie.gross = Convert.ToInt32(reader[2]);
                            awesomeMovie.genres = Convert.ToString(reader[3]);
                            awesomeMovie.title = Convert.ToString(reader[4]);
                            awesomeMovie.imdb = Convert.ToString(reader[5]);
                            var col1 = reader[0]; //gets first column returned
                            ListMovies.Items.Add(awesomeMovie);  //col1.ToString() + reader[2].ToString());  // Perform stuff for each ROW // OR INSTANCE

                        }
                    }
                }
            }

        }

        private void ListMovies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var movie = (Movie)ListMovies.SelectedItem;
            Web.Navigate(movie.imdb);
        }
    }
}
