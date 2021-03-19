﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
	public class UserMap : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasKey(u => u.Id);
			builder.Property(u => u.Id).ValueGeneratedOnAdd();

			builder.Property(u => u.Email).IsRequired(true);
			builder.Property(u => u.Email).HasMaxLength(50);
			builder.HasIndex(u => u.Email).IsUnique(true);      // ikinci kaydı kabul etmeyecek
			builder.Property(u => u.UserName).IsRequired(true);
			builder.Property(u => u.UserName).HasMaxLength(20);
			builder.HasIndex(u => u.UserName).IsUnique(true);
			builder.Property(u => u.PasswordHash).IsRequired(true);
			builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");
			builder.Property(u => u.Description).HasMaxLength(500);
			builder.Property(u => u.FirstName).IsRequired(true);
			builder.Property(u => u.FirstName).HasMaxLength(30);
			builder.Property(u => u.LastName).IsRequired(true);
			builder.Property(u => u.LastName).HasMaxLength(30);
			builder.Property(u => u.Picture).IsRequired(true);
			builder.Property(u => u.Picture).HasMaxLength(250);

			builder.Property(r => r.CreatedByName).IsRequired(true);
			builder.Property(r => r.CreatedByName).HasMaxLength(50);
			builder.Property(r => r.ModifiedByName).IsRequired(true);
			builder.Property(r => r.ModifiedByName).HasMaxLength(50);
			builder.Property(r => r.CreatedDate).IsRequired(true);
			builder.Property(r => r.ModifiedDate).IsRequired(true);
			builder.Property(r => r.IsActive).IsRequired(true);
			builder.Property(r => r.IsDeleted).IsRequired(true);
			builder.Property(r => r.Note).HasMaxLength(500);

			builder.HasOne<Role>(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);

			builder.ToTable("Users");
		}
	}
}
