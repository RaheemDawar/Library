//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryProject.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.BookPlaces = new HashSet<BookPlace>();
            this.IssuedBooks = new HashSet<IssuedBook>();
        }
    
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookDescription { get; set; }
        public string BookArthor { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<int> FK_BookCatagory { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookPlace> BookPlaces { get; set; }
        public virtual Catagory Catagory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssuedBook> IssuedBooks { get; set; }
    }
}
