using System.Data.Entity;
using TrackableClassLibrary.Entities.Service.Net45.Models.Mapping;

namespace TrackableClassLibrary.Entities.Service.Net45.Models
{
    public partial class LicensingContext : DbContext
    {
        static LicensingContext()
        {
            Database.SetInitializer(new NullDatabaseInitializer<LicensingContext>());
        }

        public LicensingContext()
            : base("Name=LicensingContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<LicenceAllocation> LicenceAllocations { get; set; }
        public DbSet<Licence> Licences { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<SoftwareFile> SoftwareFiles { get; set; }
        public DbSet<Software> Softwares { get; set; }
        public DbSet<SoftwareType> SoftwareTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LicenceAllocationMap());
            modelBuilder.Configurations.Add(new LicenceMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new SoftwareFileMap());
            modelBuilder.Configurations.Add(new SoftwareMap());
            modelBuilder.Configurations.Add(new SoftwareTypeMap());
            ModelCreating(modelBuilder);
        }

        partial void ModelCreating(DbModelBuilder modelBuilder);
    }
}
