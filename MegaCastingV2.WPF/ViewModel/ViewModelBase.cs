using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    public abstract class ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Context de l'application
        /// </summary>
        private MegaCastingEntities _Entities;

        #endregion

        #region Properties
        /// <summary>
        /// Obtoen ou défini le Context de l'application
        /// </summary>
        public MegaCastingEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelBase(MegaCastingEntities entities)
        {
            this.Entities = entities;
        }



        #endregion
    }
}
