using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using System;

namespace DataAccess.Migrations.Seed
{
    public class BranchSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<Branch> builder)
        {
            DateTime date = DateTime.Now;

            builder.HasData(
                new Branch()
                {
                    Id = 1,
                    OrganizationId = 1,
                    Name = "SXM",
                    Address = "Address SXM",
                    AddedDate = date,
                },

               new Branch()
               {
                   Id = 2,
                   OrganizationId = 1,
                   Name = "PS",
                   Address = "Address PS",
                   AddedDate = date,
               },

                new Branch()
                {
                    Id = 3,
                    OrganizationId = 2,
                    Name = "28 May filiali",
                    Address = "28 May",
                    AddedDate = date,
                },

                 new Branch()
                 {
                     Id = 4,
                     OrganizationId = 2,
                     Name = "Sahil filiali",
                     Address = "Sahil",
                     AddedDate = date,
                 },
                  new Branch()
                  {
                      Id = 5,
                      OrganizationId = 3,
                      Name = "Bash Ofis",
                      Address = "Nerimanov kucesi",
                      AddedDate = date,
                  },

                  new Branch()
                  {
                      Id = 6,
                      OrganizationId = 3,
                      Name = "Gence filiali",
                      Address = "Gence sheheri",
                      AddedDate = date,
                  }
            );
        }
    }
}
