using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelOffer : ViewModelBase
    {

        #region Attributes
        /// <summary>
        /// Liste observable des Offers
        /// </summary>
        private ObservableCollection<Offer> _Offers;
        /// <summary>
        /// Liste observable des Citys
        /// </summary>
        private ObservableCollection<City> _Citys;
        /// <summary>
        /// Liste observable des Producers
        /// </summary>
        private ObservableCollection<Producer> _Producers;
        /// <summary>
        /// Liste observable des Jobs
        /// </summary>
        private ObservableCollection<Job> _Jobs;
        /// <summary>
        /// Liste observable des ContractTypes
        /// </summary>
        private ObservableCollection<ContractType> _ContractTypes;
        /// <summary>
        /// Récupère l'Offer Selectionnée
        /// </summary>
        private Offer _SelectedOffer;
        #endregion

        #region Properties
        /// <summary>
        /// Obtient ou défini les ContractType
        /// </summary>
        public ObservableCollection<Offer> Offers
        {
            get { return _Offers; }
            set { _Offers = value; }
        }
        /// <summary>
        /// Obtient ou défini les Citys
        /// </summary>
        public ObservableCollection<City> Citys
        {
            get { return _Citys; }
            set { _Citys = value; }
        }

        /// <summary>
        /// Obtient ou défini les Producers
        /// </summary>
        public ObservableCollection<Producer> Producers
        {
            get { return _Producers; }
            set { _Producers = value; }
        }

        /// <summary>
        /// Obtient ou défini les Jobs
        /// </summary>
        public ObservableCollection<Job> Jobs
        {
            get { return _Jobs; }
            set { _Jobs = value; }
        }
        /// <summary>
        /// Obtient ou défini les contractTypes
        /// </summary>

        public ObservableCollection<ContractType> ContractTypes
        {
            get { return _ContractTypes; }
            set { _ContractTypes = value; }
        }

        /// <summary>
        /// Obtion ou défini l'Offer Selectionnée
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
            /// <summary>
            /// Permet d'affcter a Offer les entités de la liste des Offers
            /// </summary>
            this.Entities.Offers.ToList();
            this.Offers = this.Entities.Offers.Local;
            /// <summary>
            /// Permet d'affcter a Citys les entités de la liste des cities
            /// </summary>
            this.Entities.Cities.ToList();
            this.Citys = this.Entities.Cities.Local;
            /// <summary>
            /// Permet d'affcter a Producers les entités de la liste des Producers
            /// </summary>
            this.Entities.Producers.ToList();
            this.Producers = this.Entities.Producers.Local;
            /// <summary>
            /// Permet d'affcter a Jobs les entités de la liste des jobs
            /// </summary>
            this.Entities.Jobs.ToList();
            this.Jobs = this.Entities.Jobs.Local;
            /// <summary>
            /// Permet d'affcter a ContractTypes les entités de la liste des ContractTypes
            /// </summary>
            this.Entities.ContractTypes.ToList();
            this.ContractTypes = this.Entities.ContractTypes.Local;

        }

        #endregion

        #region Methods

            /// <summary>
            /// Permet d'ajouter une Offer
            /// </summary>
            public void AddOffer(string text)
            {
                //Vérification d'existance de champ
                if (text.Any())
            {
                    //Vérification de validité de l'offre
                    if (!this.Entities.Offers.Any(type => type.Name == text)
                    )
                    {
                        //Demande d'ajout
                        MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer l'ajout", "Ajout d'une offre", MessageBoxButton.YesNo);

                        //Ajout d'un nouveau contractType
                        if (result == MessageBoxResult.Yes)
                        {
                            //Ajout d'une nouvelle offre
                            Offer offer = new Offer();
                            offer.Name = text;
                            this.Offers.Add(offer);

                            this.Entities.SaveChanges();
                            this.SelectedOffer = offer;
                        }
                    }
                    else
                    {
                        MessageBox.Show("L'offre existe déjà !");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez renseigner un Nom");
                }
            }

            /// <summary>
            /// Sauvegarde les modifications
            /// </summary>
            public void UpdateOffer(string text)
            {
                // Vérification de validité pour mettre a jour le ContractType
                if (SelectedOffer != null &&
                    !this.Entities.Offers.Any(type => type.Name == text))
                {
                    Offer offer = new Offer();
                    offer.Name = text;

                    this.Entities.SaveChanges();

                }
                else
                {
                    MessageBox.Show("Aucune modification efféctuée");
                }
            }

            /// <summary>
            /// Permet de supprimer une Offer
            /// </summary>
            public void DeleteOffer()
            {
                //Vérrification d'existence pour le supprimer
                if (SelectedOffer == null)
                {
                    MessageBox.Show("Vous devez selectionner un secteur d'activité pour le supprimer");
                }

                //Si il y a un Secteur d'activité faire ceci
                else if (!SelectedOffer.ArtistOffers.Any())
                {
                    //Demande de Suppression 
                    MessageBoxResult result = MessageBox.Show("Souhaitez-vous confimer la suppression", "Suppresion l'offre", MessageBoxButton.YesNo);

                    //Suppression d'un ContractType
                    if (result == MessageBoxResult.Yes)
                    {

                        // Suppression de l'élément
                        this.Entities.Offers.Remove(SelectedOffer);
                        this.Entities.SaveChanges();
                        this.Offers.Remove(SelectedOffer);
                    }
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer car il existe encore au moins une offre lier à ce secteur d'activité !");
                }

            }


        #endregion
    }
}
