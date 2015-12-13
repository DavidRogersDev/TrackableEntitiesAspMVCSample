
using System.Data.Entity.ModelConfiguration;

namespace TrackableClassLibrary.Entities.Service.Net45.Models.Mapping
{
    public class SoftwareMap : EntityTypeConfiguration<Software>
    {
        public SoftwareMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Softwares");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.SoftwareType_Id).HasColumnName("SoftwareType_Id");

            // Tracking Properties
			this.Ignore(t => t.TrackingState);
			this.Ignore(t => t.ModifiedProperties);
			this.Ignore(t => t.EntityIdentifier);

            // Relationships
            this.HasOptional(t => t.SoftwareType)
                .WithMany(t => t.Softwares)
                .HasForeignKey(d => d.SoftwareType_Id);

        }
    }
}
