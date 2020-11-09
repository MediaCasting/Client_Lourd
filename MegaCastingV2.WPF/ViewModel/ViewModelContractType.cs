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
   
    public class ViewModelContractType : ViewModelBase
    {
        
        #region Attributes
        /// <summary>
        /// Liste observable des ContractType
        /// </summary>
        private ObservableCollection<ContractType> _ContractTypes;

        /// <summary>
        /// Récupère le ContractType Selectionné
        /// </summary>
        private ContractType _SelectedContractType;
        #endregion


        #region Properties
        /// <summary>
        /// Obtien ou défini les ContractType
        /// </summary>
        public ObservableCollection<ContractType> ContractTypes
        {
            get { return _ContractTypes; }
            set { _ContractTypes = value; }
        }

        /// <summary>
        /// Obtion ou défini le ContractType Selectionné
        /// </summary>
        public ContractType SelectedContractType
        {
            get { return _SelectedContractType; }
            set { _SelectedContractType = value; }
        }
        #endregion


        #region Constructor
        public ViewModelContractType(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.ContractTypes.ToList();
            this.ContractTypes = this.Entities.ContractTypes.Local;

        }

        #endregion

        #region Methods
        

        public void AddContractType()
        {
            if (!this.Entities.ContractTypes
                .Any(type => type.Name == "Nouveau type de contrat")
                )
            {
                ContractType contractType = new ContractType();
                contractType.Name = "nouveau Type de contrat";
                this.ContractTypes.Add(contractType);

                this.UpdateContractType();
                this.SelectedContractType = contractType;
            }
        }

        /// <summary>
        /// Sauvegarde les modifications
        /// </summary>
        public void UpdateContractType()
        {
            this.Entities.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteContractType()
        {
            //Vérrification si on a le droit de supprimer


            // Suppression de l'élément
            this.ContractTypes.Remove(SelectedContractType);
            this.UpdateContractType();
        }
        #endregion
    }
}
