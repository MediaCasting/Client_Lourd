﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MegaCastingV2.DBlib
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MegaCastingEntities : DbContext
    {
        public MegaCastingEntities()
            : base("name=MegaCastingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<ArtistOffer> ArtistOffers { get; set; }
        public virtual DbSet<BroadcastPartner> BroadcastPartners { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<ContractType> ContractTypes { get; set; }
        public virtual DbSet<DomainJob> DomainJobs { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Messagerie> Messageries { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<Pack> Packs { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
    }
}
