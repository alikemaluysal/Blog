using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable("Posts").HasKey(p => p.Id);

        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Title).HasColumnName("Title");
        builder.Property(p => p.Content).HasColumnName("Content");
        builder.Property(p => p.UserId).HasColumnName("UserId");
        builder.Property(p => p.CategoryId).HasColumnName("CategoryId");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);

        //builder.HasMany(c => c.Comments).WithOne(p => p.Post).OnDelete(DeleteBehavior.NoAction);

    }
}