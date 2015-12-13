
using System.Data.Entity.ModelConfiguration;

namespace TrackableClassLibrary.Entities.Service.Net45.Models.Mapping
{
    public class SoftwareFileMap : EntityTypeConfiguration<SoftwareFile>
    {
        public SoftwareFileMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("SoftwareFiles");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.FileType).HasColumnName("FileType");
            this.Property(t => t.SoftwareId).HasColumnName("SoftwareId");

            // Tracking Properties
			this.Ignore(t => t.TrackingState);
			this.Ignore(t => t.ModifiedProperties);
			this.Ignore(t => t.EntityIdentifier);

            // Relationships
            this.HasRequired(t => t.Software)
                .WithMany(t => t.SoftwareFiles)
                .HasForeignKey(d => d.SoftwareId);

        }
    }
}
