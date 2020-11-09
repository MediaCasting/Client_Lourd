 using MegaCastingV2.DBlib;
using MegaCastingV2.WPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCastingV2.WPF.ViewModel
{
   
    public class ViewModelContractType : ViewModelBase
    {

        #region Attributes
        private ObservableCollection<Offer> _Offers;

        

        /// <summary>
        /// Liste observable des ContractType
        /// </summary>
        private ObservableCollection<ContractType> _ContractTypes;

        /// <summary>
        /// Récupère le ContractType Selectionné
        /// </summary>
        private ContractType _SelectedContractType;
        #endregion


        #region Properties
        /// <summary>
        /// Obtien ou défini les ContractType
        /// </summary>
        public ObservableCollection<ContractType> ContractTypes
        {
            get { return _ContractTypes; }
            set { _ContractTypes = value; }
        }

        /// <summary>
        /// Obtion ou défini le ContractType Selectionné
        /// </summary>
        public ContractType SelectedContractType
        {
            get { return _SelectedContractType; }
            set { _SelectedContractType = value; }
        }

        /// <summary>
        /// Obtion ou défini les Offre
        /// </summary>
        public ObservableCollection<Offer> Offers
        {
            get { return _Offers; }
            set { _Offers = value; }
        }
        #endregion


        #region Constructor
        public ViewModelContractType(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.ContractTypes.ToList();
            this.ContractTypes = this.Entities.ContractTypes.Local;

            this.Entities.Offers.ToList();
            this.Offers = this.Entities.Offers.Local;

        }

        #endregion

        #region Methods
        /// <summary>
        /// Permet l'ajout d'un type de travail 
        /// </summary>
        /// <param name="text">Text saisie</param>
        public void AddContractType(string text)
        {
            if (text.Any())
            {
                if ( !this.Entities.ContractTypes.Any(type => type.Name == text))
                {
                    MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer l'ajout", "Ajout d'un type de job", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        ContractType contractType = new ContractType();
                        contractType.Name = text;
                        this.ContractTypes.Add(contractType);

                        this.Entities.SaveChanges();
                        this.SelectedContractType = contractType;
                    }
                }
                else
                {
                    MessageBox.Show("Le contrat existe déjà");
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir un Nom");
            }


            

        }



        /// <summary>
        /// Sauvegarde les modifications
        /// </summary>
        public void UpdateContractType(string text)
        {
            if (SelectedContractType != null && !this.Entities.ContractTypes
                .Any(type => type.Name == text))
            {
                ContractType contractType = new ContractType();
                contractType.Name = text;
                
                this.Entities.SaveChanges();
            }
            else
            {
                MessageBox.Show("Aucune modification efféctuée");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteContractType()
        {
            //Vérrification si on a le droit de supprimer

            if (SelectedContractType == null)
            {
                MessageBox.Show("Vous devez selectionner un Type de Contrat pour le supprimer");
            }
            else if (!SelectedContractType.Offers.Any())
            {
                MessageBoxResult result = MessageBox.Show("Souhaitez-vous confimer la suppression", "Suppresion d'un Type de Contrat", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {

                    // Suppression de l'élément
                    this.Entities.ContractTypes.Remove(SelectedContractType);
                    this.Entities.SaveChanges();
                    this.ContractTypes.Remove(SelectedContractType);
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas supprimer car il existe encore au moins une offre lier à un type de contrat");
            }

        }  
        
        #endregion
    }
}
