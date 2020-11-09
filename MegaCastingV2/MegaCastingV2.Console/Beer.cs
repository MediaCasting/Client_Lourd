using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.AppV1
{

	/// <summary>
	/// Classe d'une bière
	/// </summary>
	class Beer
	{
		#region Attributes
		/// <summary>
		/// Nom de la bière
		/// </summary>
		/// 
		private string _Name;

		/// <summary>
		/// Titre d'alcool
		/// </summary>

		private double _Degrees;

		/// <summary>
		/// Catégorie de bière
		/// </summary>
		private Category _Category;

		#endregion

		#region Properties
		/// <summary>
		/// Obtien ou défini le nom de la bière
		/// </summary>
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		/// <summary>
		/// Obtien ou défini le titre d'alcool
		/// </summary>
		public double Degrees
		{
			get { return _Degrees; }
			set { _Degrees = value; }
		}

		/// <summary>
		/// Obtien ou Defini la catégoie de bière
		/// </summary>
		public Category Category
		{
			get { return _Category; }
			set { _Category = value; }
		}
		#endregion



		#region Constructors


		/// <summary>
		/// Constructeur de bière
		/// </summary>
		/// <param name="name">Nom de l bière</param>
		/// <param name="degrees">Degré d'alcool</param>
		/// <param name="category">Categorie de la bière</param>
		public Beer(string name, double degrees, Category category)
		{

			this.Degrees = degrees;
			this.Name = name;
			this.Category = category;
		}
		#endregion



	}
}
