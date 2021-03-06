﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Venue
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Venue()
    {
        this.VenueLogins = new HashSet<VenueLogin>();
    }

    public int VenueKey { get; set; }
    public string VenueName { get; set; }
    public string VenueAddress { get; set; }
    public string VenueCity { get; set; }
    public string VenueState { get; set; }
    public string VenueZipCode { get; set; }
    public string VenuePhone { get; set; }
    public string VenueEmail { get; set; }
    public string VenueWebPage { get; set; }
    public Nullable<int> VenueAgeRestriction { get; set; }
    public Nullable<System.DateTime> VenueDateAdded { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<VenueLogin> VenueLogins { get; set; }
}

public partial class VenueLogin
{
    public int VenueLoginKey { get; set; }
    public Nullable<int> VenueKey { get; set; }
    public string VenueLoginUserName { get; set; }
    public string VenueLoginPasswordPlain { get; set; }
    public int VenueLoginRandom { get; set; }
    public byte[] VenueLoginHashed { get; set; }
    public Nullable<System.DateTime> VenueLoginDateAdded { get; set; }

    public virtual Venue Venue { get; set; }
}
