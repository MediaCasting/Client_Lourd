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
        /// Obtion ou défini les DomainJob
        /// </summary>
        public ObservableCollection<DomainJob> DomainJobs
        {
            get { return _DomainJobs; }
            set { _DomainJobs = value; }
        }

        /// <summary>
        /// Obtien ou défini le DomainJob Sélectionné
        /// </summary>
        public DomainJob SelectedDomainJob
        {
            get { return _SelectedDomainJob; }
            set { _SelectedDomainJob = value; }
        }
        #endregion

        #region Constructor
        public ViewModelDomainJob(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.DomainJobs.ToList();
            this.DomainJobs = this.Entities.DomainJobs.Local;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Sauvegarde les modifications
        /// </summary>
        public void UpdateDomainJob()
        {
            this.Entities.SaveChanges();
        }


        public void AddDomainJob()
        {
            if (!this.Entities.DomainJobs
                .Any(type => type.Name == "Nouveau diplome")
                )
            {
                DomainJob domainJob = new DomainJob();
                domainJob.Name = "nouveau diplome";
                this.DomainJobs.Add(domainJob);

                this.UpdateDomainJob();
                this.SelectedDomainJob = domainJob;
            }
        }
        public void DeleteDomainJob()
        {
            //Vérrification si on a le droit de supprimer


            // Suppression de l'élément
            this.DomainJobs.Remove(SelectedDomainJob);
            this.UpdateDomainJob();
        }

        #endregion
    }
}
