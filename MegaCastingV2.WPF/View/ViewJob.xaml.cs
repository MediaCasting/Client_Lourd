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
    /// Logique d'interaction pour ViewJob.xaml
    /// </summary>
    public partial class ViewJob : UserControl
    {
        /// <summary>
        /// Initialise le composant 
        /// </summary>
        public ViewJob()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Affecte la fonction AddJob au bouton Insert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageInsert_Click(object sender, RoutedEventArgs e)
        {
            //Vérification de validité
            if ( ListBoxJob.SelectedItem == null)
            {
                ((ViewModelJob)this.DataContext).AddJob(this.NameJob.Text, this.ComboBoxJob.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Impossible d'ajouter un type de contrat à partir d'un métier existant");
            }
            
        }

        /// <summary>
        /// Affecte la fonction DeleteJob au bouton Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageDelete_Click(object sender, RoutedEventArgs e)
        {   
            //Vérification de validité
            if (ListBoxJob.SelectedItem != null)
            {
                ((ViewModelJob)this.DataContext).DeleteJob();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un travail a supprimer.");
            }
        }
        /// <summary>
        /// Affecte la fonction UpdateJob au bouton update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageUpdate_Click(object sender, RoutedEventArgs e)
        {
            //Vérification de validité
            if (ListBoxJob.SelectedItem != null)
            {
                ((ViewModelJob)this.DataContext).UpdateJob(this.Name);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un travail a mettre à jour");
            }

        }
        /// <summary>
        /// Affecte la fonction UnselectAll au bouton Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageReset_Click(object sender, RoutedEventArgs e)
        {
            //Vérification de validité
            if (ListBoxJob.SelectedItem != null)
            {
                ListBoxJob.UnselectAll();
            }
            else
            {

                MessageBox.Show("Veuillez selectionner un travail a supprimer.");

            }
        }
    }
}
