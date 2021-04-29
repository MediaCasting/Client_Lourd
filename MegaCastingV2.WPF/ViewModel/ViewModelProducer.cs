using MegaCastingV2.DBlib;
using MegaCastingV2.WPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            public void AddProducer(string companyName, string firstName, string lastName, int pack)
            {
                //Vérification d'existence des champ 
                if (companyName.Any() && firstName.Any() && lastName.Any())
                {
                    //Vérification -> Le producteur existe déjà ?
                    if (!this.Entities.Producers.Any(type => type.CompanyName == companyName))
                    {
                        //Demande d'ajout
                        MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer l'ajout", "Ajout d'un producteur", MessageBoxButton.YesNo);
                        
                        //Ajout d'un métier
                        if (result == MessageBoxResult.Yes)
                        {

                            Producer producer = new Producer();
                            producer.CompanyName = companyName;
                            producer.FirstName = firstName;
                            producer.LastName = lastName;
                            producer.IdentifierPack = pack;


                            this.Producers.Add(producer);

                            this.Entities.SaveChanges();
                            this.SelectedProducer = producer;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le producteur existe déjà !");
                    }
                }
                else
                {
                    MessageBox.Show("Veulliez enseigner un Nom de compagnie");
                }

            }

            /// <summary>
            /// Sauvegarde les modifications
            /// </summary>
            public void UpdateProducer(string companyName, string firstName, string lastName, int pack)
            { 
                //Vérification d'existence des champ 
                if (companyName.Any() && firstName.Any() && lastName.Any())
                {
                    //Demande d'ajout
                    MessageBoxResult result = MessageBox.Show("Souhaitez-vous mettre à jour ces informations", "Mise à jour d'un producteur", MessageBoxButton.YesNo);
                    //Ajout d'un métier
                    if (result == MessageBoxResult.Yes)
                    {
                        Producer producer = new Producer();
                        producer.CompanyName = companyName;
                        producer.FirstName = firstName;
                        producer.LastName = lastName;
                        producer.IdentifierPack = pack;
                    
                        this.Entities.SaveChanges();
                        this.SelectedProducer = producer;
                    }
                }
                else
                {
                    MessageBox.Show("Veulliez enseigner un Nom de compagnie");
                }
            }

            /// <summary>
            /// Permet de supprimer un Producer
            /// </summary>
            public void DeleteProducer()
            {
                //Vérrification d'existence pour le supprimer
                if (SelectedProducer == null)
                {
                    MessageBox.Show("Vous devez selectionner un producteur pour le supprimer");
                }


                //Si il y a un producteur faire ceci 
                else if (!SelectedProducer.Offers.Any())
                {
                    //Demande de Suppression 
                    MessageBoxResult result = MessageBox.Show("Souhaitez-vous confimer la suppression", "Suppresion du producteur", MessageBoxButton.YesNo);
                    //Suppression d'un métier
                    if (result == MessageBoxResult.Yes)
                    {

                        // Suppression de l'élément
                        this.Entities.Producers.Remove(SelectedProducer);
                        this.Entities.SaveChanges();
                        this.Producers.Remove(SelectedProducer);
                    }
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer car il existe encore au moins une offre lier à ce producteur");
                }

            // Suppression de l'élément
                this.Producers.Remove(SelectedProducer);
                this.Entities.SaveChanges();
            }
        #endregion

    }
}
