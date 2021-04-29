using MegaCastingV2.WPF.ViewModel;
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

namespace MegaCastingV2.WPF.View
{
    /// <summary>
    /// Logique d'interaction pour ViewProducer.xaml
    /// </summary>
    public partial class ViewProducer : UserControl
    {
        /// <summary>
        /// Initialise le composant 
        /// </summary>
        public ViewProducer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Affecte la fonction AddProducer au bouton Insert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageInsert_Click(object sender, RoutedEventArgs e)
        {
            if (ListBoxProducer.SelectedItem == null)
            {
                ((ViewModelProducer)this.DataContext).AddProducer(this.CompanyName.Text, this.FirstName.Text, this.LastName.Text, this.ComboBoxPack.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Impossible d'ajouter un secteur d'activité à partir d'un secteur d'activité existant");
            }

        }

        /// <summary>
        /// Affecte la fonction DeleteProducer au bouton Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageDelete_Click(object sender, RoutedEventArgs e)
        {
            // Vérification de validité
            if (ListBoxProducer.SelectedItem != null)
            {
                ((ViewModelProducer)this.DataContext).DeleteProducer();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un producteur a réinitialiser.");
            }
        }
        /// <summary>
        /// Affecte la fonction UpdateProducer au bouton Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Vérification de validité
            if (ListBoxProducer.SelectedItem != null)
            {
                ((ViewModelProducer)this.DataContext).UpdateProducer(this.CompanyName.Text, this.FirstName.Text, this.LastName.Text, this.ComboBoxPack.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un producteur a mettre à jour.");
            }

        }
        /// <summary>
        /// Affecte la fonction UnselectAll au bouton Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageReset_Click(object sender, RoutedEventArgs e)
        {
            if (ListBoxProducer.SelectedItem != null)
            {
                ListBoxProducer.UnselectAll();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un producteur a mettre à jour.");
            }
            
        }
    }
}
