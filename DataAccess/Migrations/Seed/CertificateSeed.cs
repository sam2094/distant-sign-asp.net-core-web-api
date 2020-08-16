using Common.Enums.DatabaseEnums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using System;

namespace DataAccess.Migrations.Seed
{
    public class CertificateSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<Certificate> builder)
        {
            DateTime date = DateTime.Now;
            DateTime expireDate = DateTime.Now.AddMonths(10);

            builder.HasData(
                new Certificate()
                {
                    Id = 1,
                    PersonId = 1,
                    OrganizationId = 1,
                    CertificateTypeId = (byte) CertificateTypes.CITIZEN,
                    CertificateStatusId = (byte)CertificateStatuses.ACTIVE,
                    AuthCertThumbPrint = "AAAAAAAAAAAAAA",
                    AuthCertSerialNumber = "11111111111",
                    SignCertThumbPrint = "AAAAAAAAAAAAA",
                    SignCertSerialNumber = "1111111111",
                    Price = 38,
                    ExpireDate = expireDate,
                    AddedDate = date,
                },

               new Certificate()
               {
                   Id = 2,
                   PersonId = 2,
                   OrganizationId = 1,
                   CertificateTypeId = (byte)CertificateTypes.GOVERNMENT,
                   CertificateStatusId = (byte)CertificateStatuses.ACTIVE,
                   AuthCertThumbPrint = "AAAAAAAAAAAAAA",
                   AuthCertSerialNumber = "11111111111",
                   SignCertThumbPrint = "AAAAAAAAAAAAA",
                   SignCertSerialNumber = "1111111111",
                   Price = 38,
                   ExpireDate = expireDate,
                   AddedDate = date,
               },

               new Certificate()
               {
                   Id = 3,
                   PersonId = 3,
                   OrganizationId = 1,
                   CertificateTypeId = (byte)CertificateTypes.LEGAL,
                   CertificateStatusId = (byte)CertificateStatuses.ACTIVE,
                   AuthCertThumbPrint = "AAAAAAAAAAAAAA",
                   AuthCertSerialNumber = "11111111111",
                   SignCertThumbPrint = "AAAAAAAAAAAAA",
                   SignCertSerialNumber = "1111111111",
                   Price = 50,
                   ExpireDate = expireDate,
                   AddedDate = date,
               },
               new Certificate()
               {
                   Id = 4,
                   PersonId = 4,
                   OrganizationId = 1,
                   CertificateTypeId = (byte)CertificateTypes.OWNER,
                   CertificateStatusId = (byte)CertificateStatuses.ACTIVE,
                   AuthCertThumbPrint = "AAAAAAAAAAAAAA",
                   AuthCertSerialNumber = "11111111111",
                   SignCertThumbPrint = "AAAAAAAAAAAAA",
                   SignCertSerialNumber = "1111111111",
                   Price = 38,
                   ExpireDate = expireDate,
                   AddedDate = date,
               },
               new Certificate()
               {
                   Id = 5,
                   PersonId = 5,
                   OrganizationId = 1,
                   CertificateTypeId = (byte)CertificateTypes.CITIZEN,
                   CertificateStatusId = (byte)CertificateStatuses.ACTIVE,
                   AuthCertThumbPrint = "AAAAAAAAAAAAAA",
                   AuthCertSerialNumber = "11111111111",
                   SignCertThumbPrint = "AAAAAAAAAAAAA",
                   SignCertSerialNumber = "1111111111",
                   Price = 18,
                   ExpireDate = expireDate,
                   AddedDate = date,
               },
               new Certificate()
               {
                   Id = 6,
                   PersonId = 6,
                   OrganizationId = 2,
                   CertificateTypeId = (byte)CertificateTypes.GOVERNMENT,
                   CertificateStatusId = (byte)CertificateStatuses.ACTIVE,
                   AuthCertThumbPrint = "AAAAAAAAAAAAAA",
                   AuthCertSerialNumber = "11111111111",
                   SignCertThumbPrint = "AAAAAAAAAAAAA",
                   SignCertSerialNumber = "1111111111",
                   Price = 38,
                   ExpireDate = expireDate,
                   AddedDate = date,
               },
               new Certificate()
               {
                   Id = 7,
                   PersonId = 7,
                   OrganizationId = 2,
                   CertificateTypeId = (byte)CertificateTypes.CITIZEN,
                   CertificateStatusId = (byte)CertificateStatuses.ACTIVE,
                   AuthCertThumbPrint = "AAAAAAAAAAAAAA",
                   AuthCertSerialNumber = "11111111111",
                   SignCertThumbPrint = "AAAAAAAAAAAAA",
                   SignCertSerialNumber = "1111111111",
                   Price = 38,
                   ExpireDate = expireDate,
                   AddedDate = date,
               },
               new Certificate()
               {
                   Id = 8,
                   PersonId = 8,
                   OrganizationId = 2,
                   CertificateTypeId = (byte)CertificateTypes.CITIZEN,
                   CertificateStatusId = (byte)CertificateStatuses.ACTIVE,
                   AuthCertThumbPrint = "AAAAAAAAAAAAAA",
                   AuthCertSerialNumber = "11111111111",
                   SignCertThumbPrint = "AAAAAAAAAAAAA",
                   SignCertSerialNumber = "1111111111",
                   Price = 38,
                   ExpireDate = expireDate,
                   AddedDate = date,
               },
               new Certificate()
               {
                   Id = 9,
                   PersonId = 9,
                   OrganizationId = 3,
                   CertificateTypeId = (byte)CertificateTypes.CITIZEN,
                   CertificateStatusId = (byte)CertificateStatuses.ACTIVE,
                   AuthCertThumbPrint = "AAAAAAAAAAAAAA",
                   AuthCertSerialNumber = "11111111111",
                   SignCertThumbPrint = "AAAAAAAAAAAAA",
                   SignCertSerialNumber = "1111111111",
                   Price = 48,
                   ExpireDate = expireDate,
                   AddedDate = date,
               },
               new Certificate()
               {
                   Id = 10,
                   PersonId = 10,
                   OrganizationId = 3,
                   CertificateTypeId = (byte)CertificateTypes.LEGAL,
                   CertificateStatusId = (byte)CertificateStatuses.ACTIVE,
                   AuthCertThumbPrint = "AAAAAAAAAAAAAA",
                   AuthCertSerialNumber = "11111111111",
                   SignCertThumbPrint = "AAAAAAAAAAAAA",
                   SignCertSerialNumber = "1111111111",
                   Price = 28,
                   ExpireDate = expireDate,
                   AddedDate = date,
               }
            ) ;
        }
    }
}
