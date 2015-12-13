
using System.Data.Entity.ModelConfiguration;

namespace TrackableClassLibrary.Entities.Service.Net45.Models.Mapping
{
    public class SoftwareTypeMap : EntityTypeConfiguration<SoftwareType>
    {
        public SoftwareTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Description)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("SoftwareTypes");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");

            // Tracking Properties
			this.Ignore(t => t.TrackingState);
			this.Ignore(t => t.ModifiedProperties);
			this.Ignore(t => t.EntityIdentifier);
        }
    }
}
