//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class UserOffer
    {
        public long Identifier { get; set; }
        public long IdentifierUser { get; set; }
        public long IdentifierOffer { get; set; }
    
        public virtual Offer Offer { get; set; }
        public virtual User User { get; set; }
    }
}
