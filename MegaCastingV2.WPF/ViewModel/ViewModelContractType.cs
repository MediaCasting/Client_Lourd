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
        /// Obtient ou défini les ContractType
        /// </summary>
        public ObservableCollection<ContractType> ContractTypes
        {
            get { return _ContractTypes; }
            set { _ContractTypes = value; }
        }

        /// <summary>
        /// Obtient ou défini le ContractType Selectionné
        /// </summary>
        public ContractType SelectedContractType
        {
            get { return _SelectedContractType; }
            set { _SelectedContractType = value; }
        }


        #endregion


        #region Constructor
        /// <summary>
        /// Permet d'affcter a ContractTypes les entités de la liste des types de contrats
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelContractType(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.ContractTypes.ToList();
            this.ContractTypes = this.Entities.ContractTypes.Local;

        }

        #endregion

        #region Methods
        /// <summary>
        /// Permet l'ajout d'un type de travail 
        /// </summary>
        /// <param name="text">Text saisie</param>
        public void AddContractType(string text)
        {
            //Vérification d'existence de champ 
            if (text.Any())
            {
                //Vérification -> Le nom du contrat existe déjà ?
                if ( !this.Entities.ContractTypes.Any(type => type.Name == text))
                {
                    //Demande d'ajout
                    MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer l'ajout", "Ajout d'un type de contrat", MessageBoxButton.YesNo);
                    //Ajout d'un nouveau contractType
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
                    MessageBox.Show("Le contrat existe déjà !");
                }
            }
            else
            {
                MessageBox.Show("Veuillez renseigner un Nom");
            }


        }


        /// <summary>
        /// Sauvegarde les modifications
        /// </summary>
        public void UpdateContractType(string text)
        {
            //Vérification de validité pour mettre a jour le ContractType 
            if (SelectedContractType != null &&
                !this.Entities.ContractTypes.Any(type => type.Name == text))
            {
                ContractType contractType = new ContractType();
                contractType.Name = text;

                
                this.Entities.SaveChanges();
            }
            else
            {
                MessageBox.Show("Une erreur est survenu !");
            }
        }

        /// <summary>
        /// Permet de supprimer un ContractType
        /// </summary>
        public void DeleteContractType()
        {
            //Vérrification d'existence pour le supprimer

            if (SelectedContractType == null)
            {
                MessageBox.Show("Vous devez selectionner un Type de Contrat pour le supprimer");
            }
            //Si il y a un contractType faire ceci 
            else if (!SelectedContractType.Offers.Any())
            {
                //Demande de Suppression 
                MessageBoxResult result = MessageBox.Show("Souhaitez-vous confimer la suppression", "Suppresion d'un Type de Contrat", MessageBoxButton.YesNo);
                //Suppression d'un ContractType
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
