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

        /// <summary>
        /// Liste observable des packs
        /// </summary>
        private ObservableCollection<Pack> _Packs;

        /// <summary>
        /// Liste observable des Producers
        /// </summary>
        private ObservableCollection<Producer> _Producers;

        /// <summary>
        /// Récupère le Producer Selectionné
        /// </summary>
        private Producer _SelectedProducer;
        #endregion


        #region Properties
        /// <summary>
        /// Obtient ou défini les Producers
        /// </summary>
        public ObservableCollection<Producer> Producers
        {
            get { return _Producers; }
            set { _Producers = value; }
        }

        /// <summary>
        /// Obtient ou défini le Producer Selectionné
        /// </summary>
        public Producer SelectedProducer
        {
            get { return _SelectedProducer; }
            set { _SelectedProducer = value; }
        }
        /// <summary>
        /// Obtient ou défini les Packs
        /// </summary>
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
            /// <summary>
            /// Permet d'affcter a Produers les entités de la liste des producers
            /// </summary>
            this.Entities.Producers.ToList();
            this.Producers = this.Entities.Producers.Local;
            /// <summary>
            /// Permet d'affcter a Packs les entités de la liste des pack
            /// </summary>
            this.Entities.Packs.ToList();
            this.Packs = this.Entities.Packs.Local;

        }

        #endregion
        #region Methods
            /// <summary>
            /// Permet d'ajouter un producer 
            /// </summary>
            public void AddProducer()
            {
                //Vérification de validité
                if (!this.Entities.Producers
                    .Any(type => type.CompanyName == "Nouvelle Compagnie")
                    )
                {
                //Ajout du nouveau producer
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
                //TODO : Vérifs
                this.Entities.SaveChanges();
            }

            /// <summary>
            /// Permet de supprimer un Producer
            /// </summary>
            public void DeleteProducer()
            {
                //TODO : Vérifs

                // Suppression de l'élément
                this.Producers.Remove(SelectedProducer);
                this.UpdateProducer();
            }
        #endregion

    }
}
