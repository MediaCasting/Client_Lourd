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
    /// Logique d'interaction pour ViewDomainJob.xaml
    /// </summary>
    public partial class ViewDomainJob : UserControl
    {
        /// <summary>
        /// Initialise le composant
        /// </summary>
        public ViewDomainJob()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Affecte la fonction AddDomainJob au bouton Insert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageInsert_Click(object sender, RoutedEventArgs e)
        {
            //TODO : Vérifs//Vérification de validité
            if (ListBoxDomainJob.SelectedItem == null)
            {
                ((ViewModelDomainJob)this.DataContext).AddDomainJob(this.Nom.Text);
            }
            else
            {
                MessageBox.Show("Impossible d'ajouter un secteur d'activité à partir d'un secteur d'activité existant");
            }

        }
        /// <summary>
        /// Affecte la fonction DeleteDomainJob au bouton Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageDelete_Click(object sender, RoutedEventArgs e)
        {
            

            ((ViewModelDomainJob)this.DataContext).DeleteDomainJob();

        }
        /// <summary>
        /// Affecte la fonction UpdateDomainJob au bouton update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageUpdate_Click(object sender, RoutedEventArgs e)
        {
            //TODO : Vérifs

            ((ViewModelDomainJob)this.DataContext).UpdateDomainJob(this.Nom.Text);

        }
        /// <summary>
        /// Affecte la fonction UnselectAll au bouton Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageReset_Click(object sender, RoutedEventArgs e)
        {
            ListBoxDomainJob.UnselectAll();

        }
        private void Nom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
