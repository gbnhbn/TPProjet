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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IHM
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<personne> ps;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            personne p = new personne();
            EditerFamille fenetre = new EditerFamille(p);
            if (fenetre.ShowDialog() == true)
            {
                String Name = fenetre.tbName.Text;
                lvNom.Items.Add(Name);             
            };
        }

        private void BtnNouveausejour_Click(object sender, RoutedEventArgs e)
        {
            EditerSejour fenetreS = new EditerSejour();
            if (fenetreS.ShowDialog() == true)
            {
                String info = fenetreS.lieu.Text + " (" + fenetreS.dateDebut.Text + "-" + fenetreS.dateFin.Text + ")";
                lvSejour.Items.Add(info);
                
            }
            
        }

    }
}
