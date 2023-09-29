using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Persistences.Context.Configurations
{
    public class UsersBranchOfficeConfiguration : IEntityTypeConfiguration<UsersBranchOffice>
    {
        public void Configure(EntityTypeBuilder<UsersBranchOffice> builder)
        {
            builder.HasKey(e => e.UserBranchOfficeId).HasName("PK__UsersBra__7D1E804A4A3179A2");

            builder.HasOne(d => d.BranchOffice).WithMany(p => p.UsersBranchOffices)
                .HasForeignKey(d => d.BranchOfficeId)
                .HasConstraintName("FK__UsersBran__Branc__70DDC3D8");

            builder.HasOne(d => d.User).WithMany(p => p.UsersBranchOffices)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UsersBran__UserI__71D1E811");
        }
    }
}
