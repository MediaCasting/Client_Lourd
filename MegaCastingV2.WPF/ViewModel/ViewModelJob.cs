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
        private ObservableCollection<DomainJob> _DomainJobs;

        


        /// <summary>
        /// Liste observable des ContractType
        /// </summary>
        private ObservableCollection<Job> _Jobs;

        /// <summary>
        /// Récupère le ContractType Selectionné
        /// </summary>
        private Job _SelectedJob;
        #endregion


        #region Properties

        public ObservableCollection<DomainJob> DomainJobs
        {
            get { return _DomainJobs; }
            set { _DomainJobs = value; }
        }

        /// <summary>
        /// Obtien ou défini les ContractType
        /// </summary>
        public ObservableCollection<Job> Jobs
        {
            get { return _Jobs; }
            set { _Jobs = value; }
        }

        /// <summary>
        /// Obtion ou défini le ContractType Selectionné
        /// </summary>
        public Job SelectedJob
        {
            get { return _SelectedJob; }
            set { _SelectedJob = value; }
        }
        #endregion


        #region Constructor
        public ViewModelJob(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.Jobs.ToList();
            this.Jobs = this.Entities.Jobs.Local;

            this.Entities.DomainJobs.ToList();
            this.DomainJobs = this.Entities.DomainJobs.Local;
        }

        #endregion
        #region Methods
        public void AddJob()
        {
            if (!this.Entities.Jobs
                .Any(type => type.Name == "Nouveau métier")
                )
            {
                Job job = new Job();
                job.Name = "nouveau métier";
                this.Jobs.Add(job);

                this.UpdateJob();
                this.SelectedJob = job;
            }
        }
        public void UpdateJob()
        {
            this.Entities.SaveChanges();
        }
        public void DeleteJob()
        {
            //Vérrification si on a le droit de supprimer


            // Suppression de l'élément
            this.Jobs.Remove(SelectedJob);
            this.UpdateJob();
        }
        #endregion
    }
}
