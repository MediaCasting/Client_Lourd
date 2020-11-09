using MegaCastingV2.WPF.View;
using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    class ViewModelPackageCasting : ViewModelBase
    {

        #region Attributes
        /// <summary>
        /// Liste observable des ContractType
        /// </summary>
        private ObservableCollection<Pack> _Packs;

        /// <summary>
        /// Récupère le ContractType Selectionné
        /// </summary>
        private Pack _SelectedPack;
        #endregion


        #region Properties
        /// <summary>
        /// Obtien ou défini les ContractType
        /// </summary>
        public ObservableCollection<Pack> Packs
        {
            get { return _Packs; }
            set { _Packs = value; }
        }

        /// <summary>
        /// Obtion ou défini le ContractType Selectionné
        /// </summary>
        public Pack SelectedPack
        {
            get { return _SelectedPack; }
            set { _SelectedPack = value; }
        }
        #endregion


        #region Constructor
        public ViewModelPackageCasting(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.Packs.ToList();
            this.Packs = this.Entities.Packs.Local;

        }

        #endregion
        #region Methods
            public void AddPackageCasting()
            {
                if (!this.Entities.Packs
                    .Any(type => type.Name == "Nouveau pack")
                    )
                {
                    Pack pack = new Pack();
                    pack.Name = "nouveau pack";
                    this.Packs.Add(pack);

                    this.UpdatePackageCasting();
                    this.SelectedPack = pack;
                }
            }

            /// <summary>
            /// Sauvegarde les modifications
            /// </summary>
            public void UpdatePackageCasting()
            {
                this.Entities.SaveChanges();
            }

            /// <summary>
            /// 
            /// </summary>
            public void DeletePackageCasting()
            {
                //Vérrification si on a le droit de supprimer


                // Suppression de l'élément
                this.Packs.Remove(SelectedPack);
                this.UpdatePackageCasting();
            }
        #endregion

    }
}
