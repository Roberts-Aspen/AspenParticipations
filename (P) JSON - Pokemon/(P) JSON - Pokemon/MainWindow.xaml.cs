using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
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
namespace _P__JSON___Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string path = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=1000";

            PokeAPI PokemonAPI;

            using (var client = new HttpClient())
            {

                string json = client.GetStringAsync(path).Result;

                PokemonAPI = JsonConvert.DeserializeObject<PokeAPI>(json);
            }

            foreach (var character in PokemonAPI.results)
            {
                Characters.Items.Add(character);
            }

        }

        private void LstCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCharacterFromList = (ResultObject)Characters.SelectedItem;

            //imgCharacter.Source = new BitmapImage(new Uri("https://pokeapi.co/api/v2/pokemon/pikachu"));
            imgCharacter.Source = new BitmapImage(new Uri(selectedCharacterFromList.image));
        }

    }
}
