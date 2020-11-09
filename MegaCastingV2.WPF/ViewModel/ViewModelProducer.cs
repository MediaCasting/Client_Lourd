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


    class ViewModelProducer : ViewModelBase
    {
        #region Attributes


        private ObservableCollection<Pack> _Packs;

        

        /// <summary>
        /// Liste observable des ContractType
        /// </summary>
        private ObservableCollection<Producer> _Producers;

        /// <summary>
        /// Récupère le ContractType Selectionné
        /// </summary>
        private Producer _SelectedProducer;
        #endregion


        #region Properties
        /// <summary>
        /// Obtien ou défini les ContractType
        /// </summary>
        public ObservableCollection<Producer> Producers
        {
            get { return _Producers; }
            set { _Producers = value; }
        }

        /// <summary>
        /// Obtion ou défini le ContractType Selectionné
        /// </summary>
        public Producer SelectedProducer
        {
            get { return _SelectedProducer; }
            set { _SelectedProducer = value; }
        }
        public ObservableCollection<Pack> Packs
        {
            get { return _Packs; }
            set { _Packs = value; }
        }
        #endregion


        #region Constructor
        public ViewModelProducer(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.Producers.ToList();
            this.Producers = this.Entities.Producers.Local;

            this.Entities.Packs.ToList();
            this.Packs = this.Entities.Packs.Local;

        }

        #endregion
        #region Methods

            public void AddProducer()
            {
                if (!this.Entities.Producers
                    .Any(type => type.CompanyName == "Nouvelle Compagnie")
                    )
                {
                    Producer producer = new Producer();
                    producer.CompanyName = "Nouvelle Compagnie";
                    this.Producers.Add(producer);

                    this.UpdateProducer();
                    this.SelectedProducer = producer;
                }
            }

            /// <summary>
            /// Sauvegarde les modifications
            /// </summary>
            public void UpdateProducer()
            {
                this.Entities.SaveChanges();
            }

            /// <summary>
            /// 
            /// </summary>
            public void DeleteProducer()
            {
                //Vérrification si on a le droit de supprimer


                // Suppression de l'élément
                this.Producers.Remove(SelectedProducer);
                this.UpdateProducer();
            }
        #endregion

    }
}
