using MegaCastingV2.DBlib;
using MegaCastingV2.WPF.View;
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
using System.Windows.Shapes;

namespace MegaCastingV2.WPF.View
{
    /// <summary>
    /// Logique d'interaction pour ViewHomeJob.xaml
    /// </summary>
    public partial class ViewHomeJob : UserControl
    {

        

        #region Constructors
        /// <summary>
        /// Constructeur
        /// </summary>
        public ViewHomeJob()
        {
            InitializeComponent();
        }
        #endregion

        #region Menu
        /// <summary>
        /// Défini le dockPanel comme affichant le Métier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageMetier_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelOffer.Children.Clear();
            ViewJob viewJob = ((ViewModelHomeJob)this.DataContext).AffichageJob();
           
            this.DockPanelOffer.Children.Add(viewJob);
        }

        /// <summary>
        /// Défini le dockPanel comme affichant le Secteur d'activité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageSecActivity_Click(object sender, RoutedEventArgs e)
        {
            /*
            ViewModelDomainJob viewModel = new ViewModelDomainJob(Entities);
            ViewDomainJob viewDomainJob = new ViewDomainJob();
            viewDomainJob.DataContext = viewModel;
            this.DockPanelOffer.Children.Add(viewDomainJob);
      */  }
        #endregion

    }
}
