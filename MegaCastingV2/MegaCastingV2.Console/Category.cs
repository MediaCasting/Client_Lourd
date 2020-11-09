using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.AppV1
{
    class Category
    {
        #region Attributes

        /// <summary>
        /// Nom de la category
        /// </summary>

        private string _Name;
        #endregion

        #region Properties
        /// <summary>
		/// Obtien ou Défini le nom de la catégories
		/// </summary>
		public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Category(string name) {
            this.Name = name;
        }
        #endregion

        

		

	}
}
