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
    /// Logique d'interaction pour ViewWorkType.xaml
    /// </summary>
    public partial class ViewDomainJob : UserControl
    {
        public ViewDomainJob()
        {
            InitializeComponent();
        }

        private void ButtonManageInsert_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelDomainJob)this.DataContext).AddDomainJob();

        }

        private void ButtonManageDelete_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelDomainJob)this.DataContext).DeleteDomainJob();

        }

        private void ButtonManageUpdate_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelDomainJob)this.DataContext).UpdateDomainJob();

        }

        private void ButtonManageReset_Click(object sender, RoutedEventArgs e)
        {
            ListBoxDomainJob.UnselectAll();

        }
        private void Nom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
