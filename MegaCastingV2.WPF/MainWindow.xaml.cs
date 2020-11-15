using MegaCastingV2.DBlib;
using MegaCastingV2.WPF.View;
using MegaCastingV2.WPF.ViewModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace MegaCastingV2.WPF
{

    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
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
        public MainWindow()
        {
            InitializeComponent();

            #if DEBUG
                this.Entities = new MegaCastingEntities();
            #endif
            #if RELEASE
                this.Entities.ContractTypes.FirstOrDefault();
            #endif
        }

        /// <summary>
        /// Permet de pouvoir bouger la fénètre
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            this.DragMove();
        }
        #endregion
        // Gestion des évènement du menu
        #region Evenement Menu
        /// <summary>
        /// Défini le dockPanel comme affichant le type de contrat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageProducer_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelProducer viewModel = new ViewModelProducer(Entities);
            ViewProducer viewProducer = new ViewProducer();
            viewProducer.DataContext = viewModel;
            this.DockPanelView.Children.Add(viewProducer);
        }

        private void ButtonManageOffer_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelOffer viewModel = new ViewModelOffer(Entities);
            ViewOffer viewOffer = new ViewOffer();
            viewOffer.DataContext = viewModel;
            this.DockPanelView.Children.Add(viewOffer);
        }

        private void ButtonManageContratType_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelContractType viewModel = new ViewModelContractType(Entities);
            ViewContratType viewContratType = new ViewContratType();
            viewContratType.DataContext = viewModel;
            this.DockPanelView.Children.Add(viewContratType);
        }

        private void ButtonManageJobLevelRequired_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelDomainJob viewModel = new ViewModelDomainJob(Entities);
            ViewDomainJob viewJobLevelRequired = new ViewDomainJob();
            viewJobLevelRequired.DataContext = viewModel;
            this.DockPanelView.Children.Add(viewJobLevelRequired);
        }
        private void ButtonManagePackageCasting_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelPackageCasting viewModel = new ViewModelPackageCasting(Entities);
            ViewPackageCasting viewPackageCasting = new ViewPackageCasting();
            viewPackageCasting.DataContext = viewModel;
            this.DockPanelView.Children.Add(viewPackageCasting);
        }

        private void ButtonManageJob_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelJob viewModel = new ViewModelJob(Entities);
            ViewJob viewJob = new ViewJob();
            viewJob.DataContext = viewModel;
            this.DockPanelView.Children.Add(viewJob);
        }
#endregion
        // Gestion des évènement sur la fenètre
#region EventWindows
        /// <summary>
        /// Action permettant de reduire la fenètre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMinimanizScrean_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        
        /// <summary>
        /// Action permettant d'agrandir ou de réduir la fenètre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFullScrean_Click(object sender, RoutedEventArgs e)
        {
            WindowState = (WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;
        }

        /// <summary>
        /// Action permettant de fermer la fenètre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


#endregion

      
    }
}
