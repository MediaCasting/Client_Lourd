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
            //TODO : Vérifs

            ((ViewModelProducer)this.DataContext).AddProducer();

        }

        /// <summary>
        /// Affecte la fonction DeleteProducer au bouton Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageDelete_Click(object sender, RoutedEventArgs e)
        {
            //TODO : Vérifs
            ((ViewModelProducer)this.DataContext).DeleteProducer();
        }
    }
}
