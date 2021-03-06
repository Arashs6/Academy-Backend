using Academy.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Persistence.EF
{
    public class CourseCategoryMapping : IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.ToTable("CourseCategories").HasKey(a => a.Id);
            builder.Property(a => a.Title);
            builder.HasMany(a => a.Children)
                .WithOne(a => a.Parent)
                .HasForeignKey(a => a.ParentId);
        }
    }
}