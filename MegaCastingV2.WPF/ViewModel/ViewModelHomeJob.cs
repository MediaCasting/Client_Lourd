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
    class ViewModelHomeJob : ViewModelBase
    {
        #region Attributs
         private ObservableCollection<Job> _Jobs;


        private MegaCastingEntities _Entities;

        #endregion
        #region Properties

        public ObservableCollection<Job> Jobs
        {
            get { return _Jobs; }
            set { _Jobs = value; }
        }
        public MegaCastingEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }
        #endregion

        public ViewModelHomeJob(MegaCastingEntities entities) :base(entities)
        {

            this.Entities.Jobs.ToList();
            this.Jobs = this.Entities.Jobs.Local;


        }


        public ViewJob AffichageJob()
        {
           
            ViewModelJob viewModel = new ViewModelJob(Entities);
            ViewJob viewJob = new ViewJob();
            viewJob.DataContext = viewModel;
            return viewJob;

        }
    }
}
