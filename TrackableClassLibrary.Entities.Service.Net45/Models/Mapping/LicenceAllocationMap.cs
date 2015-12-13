
using System.Data.Entity.ModelConfiguration;

namespace TrackableClassLibrary.Entities.Service.Net45.Models.Mapping
{
    public class LicenceAllocationMap : EntityTypeConfiguration<LicenceAllocation>
    {
        public LicenceAllocationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("LicenceAllocations");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.LicenceId).HasColumnName("LicenceId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");

            // Tracking Properties
			this.Ignore(t => t.TrackingState);
			this.Ignore(t => t.ModifiedProperties);
			this.Ignore(t => t.EntityIdentifier);

            // Relationships
            this.HasRequired(t => t.Licence)
                .WithMany(t => t.LicenceAllocations)
                .HasForeignKey(d => d.LicenceId);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.LicenceAllocations)
                .HasForeignKey(d => d.PersonId);

        }
    }
}
