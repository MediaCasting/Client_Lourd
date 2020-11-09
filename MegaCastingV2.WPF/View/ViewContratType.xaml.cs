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
    /// Logique d'interaction pour ViewContratType.xaml
    /// </summary>
    public partial class ViewContratType : UserControl
    {
        public ViewContratType()
        {
            InitializeComponent();
        }

        private void ButtonManageInsert_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelContractType)this.DataContext).AddContractType();
        }

        private void ButtonManageDelete_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelContractType)this.DataContext).DeleteContractType();
        }

        private void ButtonManageUpdate_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelContractType)this.DataContext).UpdateContractType();
        }

        private void ButtonManageReset_Click(object sender, RoutedEventArgs e)
        {
            ListBoxContractType.UnselectAll();
        }

        private void Nom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
