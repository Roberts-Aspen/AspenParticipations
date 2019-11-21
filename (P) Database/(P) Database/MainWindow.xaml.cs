using System;
using System.Collections.Generic;
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
namespace _P__Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB_128040_practiceEntities db = new DB_128040_practiceEntities();

        public MainWindow()
        {
            InitializeComponent();

            foreach (var game in db.FootballSchedules)
            {
                if (cboSeasons.Items.Contains(game.Season) == false)
                {
                    cboSeasons.Items.Add(game.Season);
                }
            }

          
            
        }


   
        private void cboSeasons_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            int selectedSeason = (int)cboSeasons.SelectedValue;

            foreach (var game in db.FootballSchedules.Where(fb => fb.Season == selectedSeason))
            {
                if (game.IsHomeGame == true)
                {
                    home.Items.Add(game.Opponent);
                }

                else
                {
                    away.Items.Add(game.Opponent);
                }
            }
        }
    }

}
