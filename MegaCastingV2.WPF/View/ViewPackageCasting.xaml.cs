using MegaCastingV2.WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace MegaCastingV2.WPF.View
{
    /// <summary>
    /// Logique d'interaction pour ViewPackageCasting.xaml
    /// </summary>
    public partial class ViewPackageCasting : UserControl
    {
        /// <summary>
        /// Initialise le composant 
        /// </summary>
        public ViewPackageCasting()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Affecte la fonction AddPackageCasting au bouton Insert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageInsert_Click(object sender, RoutedEventArgs e)
        {
            //Vérification de validité
            if (ListBoxPack.SelectedItems == null)
            {
                ((ViewModelPackageCasting)this.DataContext).AddPackageCasting(this.NamePack.Text, this.OfferNumber.Text, this.Prix.Text);
            }
            else
            {

                MessageBox.Show("Impossible d'ajouter un type de contrat à partir d'un contrat existant");

            }
        }
        /// <summary>
        /// Affecte la fonction DeletePackageCasting au bouton Insert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageDelete_Click(object sender, RoutedEventArgs e)
        {
            // Vérification de validité
            if (ListBoxPack.SelectedItem != null)
            {
                ((ViewModelPackageCasting)this.DataContext).DeletePackageCasting();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une offre a supprimer .");
            }
            

        }
        /// <summary>
        /// Affecte la fonction UpdatePackageCasting au bouton Insert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Vérification de validité
            if (ListBoxPack.SelectedItem != null)
            {
                ((ViewModelPackageCasting)this.DataContext).UpdatePackageCasting(this.NamePack.Text, this.OfferNumber.Text, this.Prix.Text);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une offre a mettre à jour.");
            }
            

        }
        /// <summary>
        /// Affecte la fonction UnselectAll au bouton reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageReset_Click(object sender, RoutedEventArgs e)
        {
            // Vérification de validité
            if (ListBoxPack.SelectedItem != null)
            {
                ListBoxPack.UnselectAll();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un pack a réinitialiser.");
            }

        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
