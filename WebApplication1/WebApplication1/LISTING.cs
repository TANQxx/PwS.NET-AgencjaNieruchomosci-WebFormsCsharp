//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class LISTING
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LISTING()
        {
            this.LISTING_IMG = new HashSet<LISTING_IMG>();
        }
    
        public int LISTING_ID { get; set; }
        public string HLCN { get; set; }
        public Nullable<decimal> HOUSE_PRICE { get; set; }
        public Nullable<decimal> BATHROOMS { get; set; }
        public Nullable<decimal> BEDROOMS { get; set; }
        public string HOME_LOCATION { get; set; }
        public string CONTACT_NAME { get; set; }
        public string E_MAIL_CONTACT { get; set; }
        public string PHONE_CONTACT { get; set; }
        public string ADDRESS { get; set; }
        public string SQUARE_FEET { get; set; }
        public Nullable<System.DateTime> YEAR_BUILD { get; set; }
        public string LOT_SIZE { get; set; }
        public string GARAGE { get; set; }
        public string NOTES { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LISTING_IMG> LISTING_IMG { get; set; }
    }
}
