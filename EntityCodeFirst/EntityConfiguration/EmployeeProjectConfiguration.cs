﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EntityCodeFirst.Entities;

namespace EntityCodeFirst.EntityConfiguration
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(p => p.EmployeeProjectId);
            builder.Property(p => p.EmployeeProjectId).HasColumnName("EmployeeProjectId");
            builder.Property(p => p.Rate).IsRequired().HasColumnType("money").HasColumnName("Rate");
            builder.HasOne(d => d.Employee)
                .WithMany(p => p.EmployeeProject)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(d => d.Project)
                .WithMany(p => p.EmployeeProject)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
