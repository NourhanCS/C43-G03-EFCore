using EF_Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Configurations
{
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>


    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(I => I.Salary)
                .HasColumnType("decimal(18,2)");

            builder.Property(I => I.HourRate).HasColumnType("decimal(18,3)");

            builder.Property(i => i.Address).HasDefaultValue("cairo");
        }
    }


}
