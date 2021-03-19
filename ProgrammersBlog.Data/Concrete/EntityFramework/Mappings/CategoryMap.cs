using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
	public class CategoryMap : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Id).ValueGeneratedOnAdd();
			builder.Property(c => c.Name).IsRequired(true);
			builder.Property(c => c.Name).HasMaxLength(70);
			builder.Property(c => c.Description).HasMaxLength(70);
			builder.Property(c => c.CreatedByName).IsRequired(true);
			builder.Property(c => c.CreatedByName).HasMaxLength(50);
			builder.Property(c => c.ModifiedByName).IsRequired(true);
			builder.Property(c => c.ModifiedByName).HasMaxLength(50);
			builder.Property(c => c.CreatedDate).IsRequired(true);
			builder.Property(c => c.ModifiedDate).IsRequired(true);
			builder.Property(c => c.IsActive).IsRequired(true);
			builder.Property(c => c.IsDeleted).IsRequired(true);
			builder.Property(c => c.Note).HasMaxLength(500);

			builder.ToTable("Categories");

			
		}
	}
}

/*
	Article nesnemiz üzerinde yaptığımız ilişkileri burada yapmamıza gerek yok. herhangi bir Id (UserId, ArticleId vb.) barındırmadığı için ihtiyaç duymuyoruz		
 */

