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
using System.Windows.Shapes;

namespace IHM
{
    /// <summary>
    /// Logique d'interaction pour EditerSejour.xaml
    /// </summary>
    public partial class EditerSejour : Window
    {

        public EditerSejour()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonDateLieu(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            String info = this.lieu.Text + " (" + this.dateDebut.Text + "-" + this.dateFin.Text + ")";
        }

        private void LvToutes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ButtonDepense(object sender, RoutedEventArgs e)
        {
            EditerDepense fenetre = new EditerDepense();
            if (fenetre.ShowDialog() == true)
            {

            }
        }

        private void Button_Depense_Click(object sender, RoutedEventArgs e)
        {
            EditerDepense fenetre = new EditerDepense();
            if (fenetre.ShowDialog() == true)
            {

            }
        }

        private void Button_droit_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
