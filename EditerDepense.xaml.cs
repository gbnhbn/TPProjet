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
    /// Logique d'interaction pour EditerDepense.xaml
    /// </summary>
    public partial class EditerDepense : Window
    {
        public EditerDepense()
        {
            InitializeComponent();
            this.cbType.Items.Add("Repas");
            this.cbType.Items.Add("Logement");
            this.cbType.Items.Add("Transport");
            this.cbType.Items.Add("Divers");
        }

        private void cbDate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbFamille_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                      
        }

        private void Btn_nouvelle_depense(object sender, RoutedEventArgs e)
        {

        }
    }
}
