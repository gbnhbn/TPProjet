using metier;
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
    /// Logique d'interaction pour EditerFamille.xaml
    /// </summary>
    /// 

    
    public partial class EditerFamille : Window
    {
        private List<personne> ps;

        public EditerFamille(personne p)
        {
            InitializeComponent();
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            famille fam = new famille();
            fam.setPersonnes(ps);
            DialogResult = true;
            String name = this.tbName.Text;
            ListPrenom.Items.Add(name);
            
        }

        private void Nouvel_enfant(object sender, RoutedEventArgs e)
        {
            String name = this.tbPrenom.Text;
            ListPrenom.Items.Add(name + " (E)");

        }

        private void Nouvel_adulte(object sender, RoutedEventArgs e)
        {
            String name = this.tbPrenom.Text;
            ListPrenom.Items.Add(name + " (A)");
        }

        private void TbName_TextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
