﻿using MegaCastingV2.DBlib;
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
        /// <summary>
        /// Initialise de le composant ainsi que le datacontexte ViewModelViewJobType
        /// </summary>
        public ViewContratType()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet l'ajout d'un type de travail 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageInsert_Click(object sender, RoutedEventArgs e)
        {
            if (ListBoxContractType.SelectedItem == null)
            {
                ((ViewModelContractType)this.DataContext).AddContractType(this.Nom.Text);
            }
            else
            {

                MessageBox.Show("Impossible d'ajouter un type de contrat à partir d'un contrat existant");

            }
        }

        /// <summary>
        /// Permet la supression d'un type de  travail 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageDelete_Click(object sender, RoutedEventArgs e)
        {
            
            ((ViewModelContractType)this.DataContext).DeleteContractType();
        }

        /// <summary>
        /// Permet la mise à jour d'un type de travail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageUpdate_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelContractType)this.DataContext).UpdateContractType(this.Nom.Text);
        }

        private void ButtonManageReset_Click(object sender, RoutedEventArgs e)
        {
            ListBoxContractType.UnselectAll();
        }

    }
}
