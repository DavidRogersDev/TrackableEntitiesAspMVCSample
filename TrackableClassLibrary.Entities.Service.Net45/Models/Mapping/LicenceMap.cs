
using System.Data.Entity.ModelConfiguration;

namespace TrackableClassLibrary.Entities.Service.Net45.Models.Mapping
{
    public class LicenceMap : EntityTypeConfiguration<Licence>
    {
        public LicenceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.LicenceKey)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Licences");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.LicenceKey).HasColumnName("LicenceKey");
            this.Property(t => t.SoftwareId).HasColumnName("SoftwareId");

            // Tracking Properties
			this.Ignore(t => t.TrackingState);
			this.Ignore(t => t.ModifiedProperties);
			this.Ignore(t => t.EntityIdentifier);

            // Relationships
            this.HasRequired(t => t.Software)
                .WithMany(t => t.Licences)
                .HasForeignKey(d => d.SoftwareId);

        }
    }
}
