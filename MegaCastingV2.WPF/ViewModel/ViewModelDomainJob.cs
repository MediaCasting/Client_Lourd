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
        /// <summary>
        /// Sauvegarde les modifications
        /// </summary>
        public void UpdateDomainJob()
        {
            //TODO : Vérifs

            this.Entities.SaveChanges();
        }

        //Ajout d'un DomainJob
        public void AddDomainJob()
        {
            //Vérifiaction de validité 
            if (!this.Entities.DomainJobs
                .Any(type => type.Name == "Nouveau diplome")
                )
            {
                //Ajout d'un nouveau DomainJob
                DomainJob domainJob = new DomainJob();
                domainJob.Name = "nouveau diplome";
                this.DomainJobs.Add(domainJob);

                this.UpdateDomainJob();
                this.SelectedDomainJob = domainJob;
            }
        }
        /// <summary>
        /// Permet de supprimer un DomainJob
        /// </summary>
        public void DeleteDomainJob()
        {
            //TODO : Vérifs

            // Suppression de l'élément
            this.DomainJobs.Remove(SelectedDomainJob);
            this.UpdateDomainJob();
        }

        #endregion
    }
}
