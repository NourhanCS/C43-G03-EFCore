using EF_Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
       
            public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);
            builder.Property(D => D.HiringDate).HasComputedColumnSql("GETDATE()");

            // one to many
            builder.HasMany(D => D.Instructors)
                .WithOne(I => I.WorkForDepartment)
                .IsRequired(false).HasForeignKey(i => i.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            //one to one
            builder.HasOne(D =>D.Manager)
                .WithOne(E => E.ManageDepartment)
                .HasForeignKey<Department>(D => D.ManagerId)
                .IsRequired(false);



        }
    }
}
