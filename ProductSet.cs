//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductSet()
        {
            this.CustomSet = new HashSet<CustomSet>();
            this.StorageSet = new HashSet<StorageSet>();
        }
    
        public int Id { get; set; }
        public int IdProvider { get; set; }
        public string Provider { get; set; }
        public string Product { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<int> Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomSet> CustomSet { get; set; }
        public virtual ProviderSet ProviderSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StorageSet> StorageSet { get; set; }
    }
}