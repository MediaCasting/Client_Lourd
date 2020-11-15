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
    /// Logique d'interaction pour ViewOffer.xaml
    /// </summary>
    public partial class ViewOffer : UserControl
    {
        /// <summary>
        /// initialise le composant 
        /// </summary>
        public ViewOffer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Affecte la fonction AddOffer au bouton Insert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageInsert_Click(object sender, RoutedEventArgs e)
        {
            //TODO : Vérifs

            ((ViewModelOffer)this.DataContext).AddOffer();

        }
        /// <summary>
        /// Affecte la fonction DeleteOffer au bouton Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageDelete_Click(object sender, RoutedEventArgs e)
        {
            //TODO : Vérifs

            ((ViewModelOffer)this.DataContext).DeleteOffer();

        }
        /// <summary>
        /// Affecte la fonction UpdateOffer au bouton Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageUpdate_Click(object sender, RoutedEventArgs e)
        {
            //TODO : Vérifs

            ((ViewModelOffer)this.DataContext).UpdateOffer();

        }
        /// <summary>
        /// Affecte la fonction UnselectAll au bouton Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageReset_Click(object sender, RoutedEventArgs e)
        {
            ListBoxOffer.UnselectAll();

        }
    }
}
