using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;

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

            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "C#",
                    Description = "C# Programlama Dili ile İlgili En Güncel Bilgiler",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Initial Create",
                    ModifiedByName = "Initial Create",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Note = "C# Blog Kategorisi",
                },
                new Category
                {
                    Id = 2,
                    Name = "C++",
                    Description = "C++ Programlama Dili ile İlgili En Güncel Bilgiler",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Initial Create",
                    ModifiedByName = "Initial Create",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Note = "C++ Blog Kategorisi",
                },
                new Category
                {
                    Id = 3,
                    Name = "Java Script",
                    Description = "Java Script Programlama Dili ile İlgili En Güncel Bilgiler",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "Initial Create",
                    ModifiedByName = "Initial Create",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Note = "Java Script Blog Kategorisi",
                }

            );


        }
    }
}

/*
	Article nesnemiz üzerinde yaptığımız ilişkileri burada yapmamıza gerek yok. herhangi bir Id (UserId, ArticleId vb.) barındırmadığı için ihtiyaç duymuyoruz		
 */

