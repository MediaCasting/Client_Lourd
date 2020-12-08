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

    class ViewModelDomainJob : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Liste Observacle des DomainJob
        /// </summary>
        private ObservableCollection<DomainJob> _DomainJobs;

        /// <summary>
        /// Récupère le DomainJob Selectionné
        /// </summary>
        private DomainJob _SelectedDomainJob;
        #endregion

        #region Properties
        /// <summary>
        /// Obtient ou défini les DomainJob
        /// </summary>
        public ObservableCollection<DomainJob> DomainJobs
        {
            get { return _DomainJobs; }
            set { _DomainJobs = value; }
        }

        /// <summary>
        /// Obtient ou défini le DomainJob Sélectionné
        /// </summary>
        public DomainJob SelectedDomainJob
        {
            get { return _SelectedDomainJob; }
            set { _SelectedDomainJob = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Permet d'affcter a DomainJob les entités de la liste des DomainJob
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelDomainJob(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.DomainJobs.ToList();
            this.DomainJobs = this.Entities.DomainJobs.Local;
        }

        #endregion

        #region Methods

        //Ajout d'un DomainJob
        public void AddDomainJob(string text)
        {
            //Vérification d'existance de champ
            if (text.Any())
            {
                //Vérification -> Le nom du contrat existe déjà ?
                if (!this.Entities.DomainJobs.Any(type => type.Name == text))
                {
                    //Demande d'ajout
                    MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer l'ajout", "Ajout d'un secteur d'activité", MessageBoxButton.YesNo);

                    //Ajout d'un nouveau contractType
                    if(result == MessageBoxResult.Yes)
                    {
                        //Ajout d'un nouveau DomainJob
                        DomainJob domainJob = new DomainJob();
                        domainJob.Name = text;
                        this.DomainJobs.Add(domainJob);

                        this.Entities.SaveChanges();
                        this.SelectedDomainJob = domainJob;
                    }
                }
                else
                {
                    MessageBox.Show("Le secteur d'activité existe déjà !");
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
        public void UpdateDomainJob(string text)
        {
            //Vérification de validité pour mettre a jour le ContractType
            if (SelectedDomainJob != null && 
                !this.Entities.DomainJobs.Any(type => type.Name == text))
            {
                DomainJob domainJob = new DomainJob();
                domainJob.Name = text;

                this.Entities.SaveChanges();

            }

        }

        /// <summary>
        /// Permet de supprimer un DomainJob
        /// </summary>
        public void DeleteDomainJob()
        {
            //Vérrification d'existence pour le supprimer

            if (SelectedDomainJob == null)
            {
                MessageBox.Show("Vous devez selectionner un secteur d'activité pour le supprimer");
            }

            //Si il y a un Secteur d'activité faire ceci
            else if(SelectedDomainJob.Jobs.Any())
            {
                //Demande de Suppression 
                MessageBoxResult result = MessageBox.Show("Souhaitez-vous confimer la suppression", "Suppresion le secteur d'activité", MessageBoxButton.YesNo);
                
                //Suppression d'un ContractType
                if(result == MessageBoxResult.Yes){

                    // Suppression de l'élément
                    this.Entities.DomainJobs.Remove(SelectedDomainJob);
                    this.Entities.SaveChanges();
                    this.DomainJobs.Remove(SelectedDomainJob);
                }
                else
                {
                MessageBox.Show("Vous ne pouvez pas supprimer car il existe encore au moins une métier lier à ce secteur d'activité !");
                }
            }

            
        }

        #endregion
    }
}
