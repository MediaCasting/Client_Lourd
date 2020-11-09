using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.AppV1
{
    class Program
    {
        /// <summary>
        /// Categories
        /// </summary>
        private static List<Category> _Categories = null;

        /// <summary>
        /// Bières
        /// </summary>
        private static List<Beer> _Beers = null;

        static void Main(string[] args)
        {
            #region Presentation LinQ
            #region Génération des données

            #region Categories
            _Categories = new List<Category>();

            _Categories.Add(new Category("Brune"));
            _Categories.Add(new Category("Blonde"));
            _Categories.Add(new Category("Ambrée"));
            #endregion

            #region Beers

            _Beers = new List<Beer>();

            /// <summary>
            /// 
            /// </summary>

            Category blondCategory = _Categories
                .First(category => category.Name == "Blonde");

            _Beers.Add(new Beer("Corona", 5, blondCategory));
            _Beers.Add(new Beer("Despe", 4.7, blondCategory));
            _Beers.Add(new Beer("Corona", 4.2, blondCategory));
            _Beers.Add(new Beer("Chouffe", 7.6, blondCategory));
            _Beers.Add(new Beer("La levrette", 3.5, blondCategory));
            _Beers.Add(new Beer("La mort subite", 6, blondCategory));
            _Beers.Add(new Beer("La lancelot", 4.2, blondCategory));
            _Beers.Add(new Beer("La morgane", 5.5, blondCategory));

            /// <summary>
            /// 
            /// </summary>

            Category bitterCategory = _Categories
                .First(category => category.Name == "Brune");

            _Beers.Add(new Beer("Leffe rituelle", 12, bitterCategory));
            _Beers.Add(new Beer("Bavaria", 9, bitterCategory));
            _Beers.Add(new Beer("DrewDog IPA Dunk", 5, bitterCategory));
            _Beers.Add(new Beer("Guinnes", 5, bitterCategory));
            _Beers.Add(new Beer("Stephanus", 5, bitterCategory));


            /// <summary>
            /// 
            /// </summary>

            Category AmberCategory = _Categories
                .First(category => category.Name == "Ambrée");

            _Beers.Add(new Beer("Leffe ambrée", 6, AmberCategory));
            _Beers.Add(new Beer("Kwak", 5, AmberCategory));
            _Beers.Add(new Beer("Queue de charrue", 7.7, AmberCategory));

            #endregion

            #endregion

            #region Exemple de requêtes linQ

            //Nombre de bière total

            _Beers.Count();

            _Beers.ForEach(beer => Console.WriteLine(beer.Name));
            //Attend la saisie d'une touch

            Console.ReadKey();
            Console.WriteLine("1 - Nombre de bière : " + _Beers.Count().ToString());
            //La somme des degrées des bières brunes

            _Beers
                .Where(beer => beer.Category.Name == "Brune")
                .Sum(beer => beer.Degrees).ToString();

            Console.ReadKey();
            //La liste des catégories en passant par les bières


            _Beers
                .Select(beer => beer.Category)
                .Distinct() //enleve les doublon
                .ToList() //on les mets en format list
                .ForEach(category => Console.WriteLine(category.Name));

            Console.ReadKey();

            //La liste des bières blondes

            _Beers
                .Where(beer => beer.Category.Name == "Blonde")
                .ToList()
                .ForEach(beer => Console.WriteLine(beer.Name));

            //La liste des bières à 6°

            _Beers
                .Where(beer => beer.Degrees == 6)
                .ToList()
                .ForEach(beer => Console.WriteLine(beer.Degrees));

            //Les bière les plus forte

            List<Beer> beers = _Beers
                .Where(beer => beer.Degrees >= _Beers
                    .Select(beerTemp => beerTemp.Degrees)
                    .Max()
                ).ToList();


            Console.WriteLine("Les bières les plus fortes (" + _Beers
                .Max(beer => beer.Degrees) + "°) :");
            beers.ForEach(beer => Console.WriteLine(beer.Name));

            #endregion
            #endregion

            #region  Présentation EF
            MegaCastingEntities entities = new MegaCastingEntities();
            entities.Offers
                .Where(offer => offer.City == "Laval");

            #endregion 

        }
    }
}
