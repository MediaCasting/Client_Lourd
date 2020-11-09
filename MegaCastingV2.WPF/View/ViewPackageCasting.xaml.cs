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
    /// Logique d'interaction pour ViewPackageCasting.xaml
    /// </summary>
    public partial class ViewPackageCasting : UserControl
    {
        public ViewPackageCasting()
        {
            InitializeComponent();
        }

        private void ButtonManageInsert_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelPackageCasting)this.DataContext).AddPackageCasting();

        }

        private void ButtonManageDelete_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelPackageCasting)this.DataContext).DeletePackageCasting();

        }

        private void ButtonManageUpdate_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelPackageCasting)this.DataContext).UpdatePackageCasting();

        }

        private void ButtonManageReset_Click(object sender, RoutedEventArgs e)
        {
            ListBoxPack.UnselectAll();

        }
    }
}
