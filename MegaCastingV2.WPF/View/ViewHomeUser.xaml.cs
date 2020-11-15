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
    /// Logique d'interaction pour ViewHomePackage.xaml
    /// </summary>
    public partial class ViewHomeUser : UserControl
    {
        #region Attributes

        /// <summary>
        /// Context de l'application
        /// </summary>
        private MegaCastingEntities _Entities;

        #endregion

        #region Properties
        /// <summary>
        /// Obtoen ou défini le Context de l'application
        /// </summary>
        public MegaCastingEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Constructeur
        /// </summary>
        public ViewHomeUser()
        {
            InitializeComponent();
        }
        #endregion

        #region EventMenu
        /// <summary>
        /// Défini le dockPanel comme affichant les producteurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageProducer_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelViewMain.Children.Clear();

            ViewModelPackageCasting viewModel = new ViewModelPackageCasting(Entities);
            ViewPackageCasting viewPackageCasting = new ViewPackageCasting();
            viewPackageCasting.DataContext = viewModel;
            this.DockPanelViewMain.Children.Add(viewPackageCasting);
        }
        /// <summary>
        /// Défini le dockPanel comme affichant les producteurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void ButtonManagePackCasting_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelViewMain.Children.Clear();

            ViewModelPackageCasting viewModel = new ViewModelPackageCasting(Entities);
            ViewPackageCasting viewPackageCasting = new ViewPackageCasting();
            viewPackageCasting.DataContext = viewModel;
            this.DockPanelViewMain.Children.Add(viewPackageCasting);

        }




        #endregion



    }

}
