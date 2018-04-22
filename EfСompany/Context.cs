namespace EfСompany
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        
        public Context()
            : base("name=Context")
        {
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Collaborator> Collaborators { get; set; }
    }

    
}