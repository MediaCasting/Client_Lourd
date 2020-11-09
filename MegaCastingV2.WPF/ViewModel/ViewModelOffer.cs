using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelOffer : ViewModelBase
    {

        #region Attributes
        /// <summary>
        /// Liste observable des ContractType
        /// </summary>
        private ObservableCollection<Offer> _Offers;

        private ObservableCollection<City> _Citys;

        private ObservableCollection<Producer> _Producers;

        private ObservableCollection<Job> _Jobs;

        private ObservableCollection<ContractType> _ContractTypes;

        /// <summary>
        /// Récupère le ContractType Selectionné
        /// </summary>
        private Offer _SelectedOffer;
        #endregion


        #region Properties
        /// <summary>
        /// Obtien ou défini les ContractType
        /// </summary>
        public ObservableCollection<Offer> Offers
        {
            get { return _Offers; }
            set { _Offers = value; }
        }

        public ObservableCollection<City> Citys
        {
            get { return _Citys; }
            set { _Citys = value; }
        }


        public ObservableCollection<Producer> Producers
        {
            get { return _Producers; }
            set { _Producers = value; }
        }


        public ObservableCollection<Job> Jobs
        {
            get { return _Jobs; }
            set { _Jobs = value; }
        }


        public ObservableCollection<ContractType> ContractTypes
        {
            get { return _ContractTypes; }
            set { _ContractTypes = value; }
        }

        /// <summary>
        /// Obtion ou défini le ContractType Selectionné
        /// </summary>
        public Offer SelectedOffer
        {
            get { return _SelectedOffer; }
            set { _SelectedOffer = value; }
        }
        #endregion


        #region Constructor
        public ViewModelOffer(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.Offers.ToList();
            this.Offers = this.Entities.Offers.Local;

            this.Entities.Cities.ToList();
            this.Citys = this.Entities.Cities.Local;

            this.Entities.Producers.ToList();
            this.Producers = this.Entities.Producers.Local;

            this.Entities.Jobs.ToList();
            this.Jobs = this.Entities.Jobs.Local;
            
            this.Entities.ContractTypes.ToList();
            this.ContractTypes = this.Entities.ContractTypes.Local;

        }

        #endregion
        #region Methods

            public void AddOffer()
            {
                if (!this.Entities.Offers
                    .Any(type => type.Name == "Nouvelle offre")
                    )
                {
                    Offer offer = new Offer();
                    offer.Name = "nouvelle offre";
                    this.Offers.Add(offer);

                    this.UpdateOffer();
                    this.SelectedOffer = offer;
                }
            }

            /// <summary>
            /// Sauvegarde les modifications
            /// </summary>
            public void UpdateOffer()
            {
                this.Entities.SaveChanges();
            }

            /// <summary>
            /// 
            /// </summary>
            public void DeleteOffer()
            {
                //Vérrification si on a le droit de supprimer


                // Suppression de l'élément
                this.Offers.Remove(SelectedOffer);
                this.UpdateOffer();
            }
        #endregion
    }
}
