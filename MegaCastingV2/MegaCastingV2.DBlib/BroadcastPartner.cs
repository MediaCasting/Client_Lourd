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
    
    public partial class BroadcastPartner
    {
        public long Identifier { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Nullable<int> Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public Nullable<long> IdentifierCity { get; set; }
    
        public virtual City City { get; set; }
    }
}
