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
    /// Logique d'interaction pour ViewOffre.xaml
    /// </summary>
    public partial class ViewOffer : UserControl
    {
        public ViewOffer()
        {
            InitializeComponent();
        }

        private void ButtonManageInsert_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelOffer)this.DataContext).AddOffer();

        }

        private void ButtonManageDelete_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelOffer)this.DataContext).DeleteOffer();

        }

        private void ButtonManageUpdate_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelOffer)this.DataContext).UpdateOffer();

        }

        private void ButtonManageReset_Click(object sender, RoutedEventArgs e)
        {
            ListBoxOffer.UnselectAll();

        }
    }
}
