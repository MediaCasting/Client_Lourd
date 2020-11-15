using MegaCastingV2.DBlib;
using MegaCastingV2.WPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void AddJob()
        {
            //Vérification de validité 
            if (!this.Entities.Jobs
                .Any(type => type.Name == "Nouveau métier")
                )
            {
                //Ajout d'un nouveau job
                Job job = new Job();
                job.Name = "nouveau métier";
                this.Jobs.Add(job);

                this.UpdateJob();
                this.SelectedJob = job;
            }
        }
        /// <summary>
        /// Permet la mise à jour des job
        /// </summary>
        public void UpdateJob()
        {
            //TODO : Vérifs

            this.Entities.SaveChanges();
        }
        /// <summary>
        /// Permet la suppression des Job
        /// </summary>
        public void DeleteJob()
        {
            //TODO : Vérifs

            // Suppression de l'élément
            this.Jobs.Remove(SelectedJob);
            this.UpdateJob();
        }
        #endregion
    }
}
