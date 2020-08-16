using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using System;

namespace DataAccess.Migrations.Seed
{
    public class OrganizationSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<Organization> builder)
        {
            DateTime date = DateTime.Now;

            builder.HasData(
                new Organization()
                {
                    Id = 1,
                    DiscountId = 1,
                    Name = "MHM",
                    Voen = "11111",
                    Account = 1,
                    AddedDate = date,
                },

                new Organization()
                {
                    Id = 2,
                    DiscountId = 1,
                    Name = "Kapital Bank",
                    Voen = "222222",
                    Account = 2,
                    AddedDate = date,
                },

                new Organization()
                {
                    Id = 3,
                    DiscountId = 1,
                    Name = "Pasha Bank",
                    Voen = "333333",
                    Account = 1,
                    AddedDate = date,
                }
            );
        }
    }
}
