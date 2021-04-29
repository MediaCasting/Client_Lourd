using MegaCastingV2.DBlib;
using MegaCastingV2.WPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelJob : ViewModelBase
    {
        #region Attributes
        /// <summary>
        /// Liste observable des DomainJobs
        /// </summary>
        private ObservableCollection<DomainJob> _DomainJobs;

        /// <summary>
        /// Liste observable des Jobs
        /// </summary>
        private ObservableCollection<Job> _Jobs;

        /// <summary>
        /// Récupère le Job Selectionné
        /// </summary>
        private Job _SelectedJob;
        #endregion

        #region Properties
        //Obtient ou défini les DomainJobs
        public ObservableCollection<DomainJob> DomainJobs
        {
            get { return _DomainJobs; }
            set { _DomainJobs = value; }
        }

        /// <summary>
        /// Obtient ou défini les Jobs
        /// </summary>
        public ObservableCollection<Job> Jobs
        {
            get { return _Jobs; }
            set { _Jobs = value; }
        }

        /// <summary>
        /// Obtient ou défini le Job Selectionné
        /// </summary>
        public Job SelectedJob
        {
            get { return _SelectedJob; }
            set { _SelectedJob = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Permet d'affcter a Job les entités de la liste des Jobs
        /// </summary>
        public ViewModelJob(MegaCastingEntities entities)
            : base(entities)
        {
            /// <summary>
            /// Permet d'affcter a Job les entités de la liste des Jobs
            /// </summary>
            this.Entities.Jobs.ToList();
            this.Jobs = this.Entities.Jobs.Local;
            /// <summary>
            /// Permet d'affcter a Job les entités de la liste des DomainJobs
            /// </summary>
            this.Entities.DomainJobs.ToList();
            this.DomainJobs = this.Entities.DomainJobs.Local;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Permet d'ajouter un Job
        /// </summary>
        public void AddJob(string text, int domainjob)
        {
            //Vérification d'existence de champ 
            if (text.Any())
            {

                    //Vérification -> Le métier existe déjà ?
                    if (!this.Entities.Jobs.Any(type => type.Name == text))
                    {
                        //Demande d'ajout
                        MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer l'ajout", "Ajout d'un type de métier", MessageBoxButton.YesNo);

                        //Ajout d'un métier
                        if (result == MessageBoxResult.Yes)
                        {

                            Job job = new Job();
                            job.Name = text;
                            job.IdentifierDomainJob = domainjob;

                            this.Jobs.Add(job);

                            this.Entities.SaveChanges();
                            this.SelectedJob = job;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le métier existe déjà !");
                    }
            }
            else
            {
                MessageBox.Show("Veulliez enseigner un Nom");
            }
            
        }
        
        /// <summary>
        /// Permet la suppression des Job
        /// </summary>
        public void DeleteJob()
        {
            //Vérrification d'existence pour le supprimer
            if (SelectedJob == null)
            {
                MessageBox.Show("Vous devez selectionner un métier pour le supprimer");
            }


            //Si il y a un métier faire ceci 
            else if (!SelectedJob.Offers.Any())
            {
                //Demande de Suppression 
                MessageBoxResult result = MessageBox.Show("Souhaitez-vous confimer la suppression", "Suppresion du métier", MessageBoxButton.YesNo);
                //Suppression d'un métier
                if (result == MessageBoxResult.Yes)
                {

                    // Suppression de l'élément
                    this.Entities.Jobs.Remove(SelectedJob);
                    this.Entities.SaveChanges();
                    this.Jobs.Remove(SelectedJob);
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas supprimer car il existe encore au moins une offre lier à ce métier");
            }

        }



        /// <summary>
        /// Sauvegarde les modifications
        /// </summary>
        public void UpdateJob(string text)
        {
            //Vérification de validité pour mettre a jour le ContractType 
            if (SelectedJob != null &&
                !this.Entities.Jobs.Any(type => type.Name == text))
            {
                Job job = new Job();
                job.Name = text;


                this.Entities.SaveChanges();
            }
            else
            {
                MessageBox.Show("Une erreur est survenu !");
            }
        }
        #endregion
    }
}
