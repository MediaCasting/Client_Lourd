using MegaCastingV2.WPF.View;
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
    class ViewModelPackageCasting : ViewModelBase
    {

        #region Attributes
        /// <summary>
        /// Liste observable des Packs
        /// </summary>
        private ObservableCollection<Pack> _Packs;

        /// <summary>
        /// Récupère le pack Selectionné
        /// </summary>
        private Pack _SelectedPack;
        #endregion

        #region Properties
        /// <summary>
        /// Obtient ou défini les Packs
        /// </summary>
        public ObservableCollection<Pack> Packs
        {
            get { return _Packs; }
            set { _Packs = value; }
        }

        /// <summary>
        /// Obtient ou défini le pack Selectionné
        /// </summary>
        public Pack SelectedPack
        {
            get { return _SelectedPack; }
            set { _SelectedPack = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Permet d'affcter a Packs les entités de la liste des Packs
        /// </summary>
        public ViewModelPackageCasting(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.Packs.ToList();
            this.Packs = this.Entities.Packs.Local;

        }

        #endregion

        #region Methods
            /// <summary>
            /// Fonction permettant de voir si une string est un nombre
            /// </summary>
            /// <param name="input"></param>
            /// <returns></returns>
            static bool typeCheckInt(String input)
            {
                int nombre = 0;
                return int.TryParse(input, out nombre);
            }

            /// <summary>
            ///Permet d'jouter un Package Casting
            /// </summary>
            /// <param name="text"></param>
            /// <param name="number"></param>
            /// <param name="price"></param>
            public void AddPackageCasting(string text, string number, string price)
            {
               //Vérification d'existence des champs 
                if (text.Any() && number.Any() && price.Any())
                {
                    //Vérifiaction que number est bien un nombre
                    if (typeCheckInt(number) == true)
                    {
                        //Le pack existe t'il déjà ?
                        if (!this.Entities.Packs.Any(type => type.Name == text))
                        {
                            //Demande d'ajout
                            MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer l'ajout", "Ajout d'un pack", MessageBoxButton.YesNo);
                            //Ajout du pack
                            if (result == MessageBoxResult.Yes)
                            {
                                Pack pack = new Pack();
                                pack.Name = text;
                                this.Packs.Add(pack);

                                this.Entities.SaveChanges();
                                this.SelectedPack = pack;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Le pack existe déjà");
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Tous les champ ne sont pas renseigner");
                }
                
            }

            /// <summary>
            /// Sauvegarde les modifications
            /// </summary>
            public void UpdatePackageCasting(string text, string number, string price)
            {
                this.Entities.SaveChanges();
                //Vérifiaction de validité
                if (SelectedPack != null && !this.Entities.Packs
                    .Any(type => type.Name == text))
                {
                    Pack pack = new Pack();
                    pack.Name = text;

                    this.Entities.SaveChanges();

                    
                }
                else
                {
                    MessageBox.Show("Aucune modification efféctuée");
                }
            }

            /// <summary>
            /// Permet de supprimer un Pack
            /// </summary>
            public void DeletePackageCasting()
            {
                //Vérrification si on a le droit de supprimer
                if(SelectedPack == null)
                {
                    MessageBox.Show("Vous devez selectionner un Type de Contrat pour le supprimer");
                }
                else if (!SelectedPack.Producers.Any())
                {
                    MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer la suppression", "Suppresion d'un Type de Contrat", MessageBoxButton.YesNo);
                    if (result ==MessageBoxResult.Yes)
                    {
                        // Suppression de l'élément
                        this.Entities.Packs.Remove(SelectedPack);
                        this.Entities.SaveChanges();
                        this.Packs.Remove(SelectedPack);

                    }
                }

            }
       
        #endregion

    }
}
