using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using System;

namespace DataAccess.Migrations.Seed
{
    public class BranchUserSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<BranchUser> builder)
        {
            DateTime date = DateTime.Now;

            builder.HasData(
                new BranchUser()
                {
                    Id = 1,
                    UserId = 1,
                    BranchId = 1,
                    AddedDate = date,
                },

               new BranchUser()
               {
                   Id = 2,
                   UserId = 2,
                   BranchId = 1,
                   AddedDate = date,
               },

                new BranchUser()
                {
                    Id = 3,
                    UserId = 3,
                    BranchId = 2,
                    AddedDate = date,
                },

                 new BranchUser()
                 {
                     Id = 4,
                     UserId = 4,
                     BranchId = 3,
                     AddedDate = date,
                 },
                   new BranchUser()
                   {
                       Id = 5,
                       UserId = 5,
                       BranchId = 3,
                       AddedDate = date,
                   },

                  new BranchUser()
                  {
                      Id = 6,
                      UserId = 6,
                      BranchId = 5,
                      AddedDate = date,
                  }
            );
        }
    }
}