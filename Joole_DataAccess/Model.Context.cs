//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Joole_DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JooleDBEntities1 : DbContext
    {
        public JooleDBEntities1()
            : base("name=JooleDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ProjtoProd> ProjtoProds { get; set; }
    }
}
