using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    class ViewModelMain : ViewModelBase
    {
 

		#region Properties
		/// <summary>
		/// 
		/// </summary>
		public int NbrOffers => this.Entities.Offers.Count();
		#endregion

		#region Constructors
		

		public ViewModelMain(MegaCastingEntities entities) : base(entities)
		{
		}
		#endregion
	}
}
