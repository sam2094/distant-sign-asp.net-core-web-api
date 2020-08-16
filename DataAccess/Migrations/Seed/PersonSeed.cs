using Common.Enums.DatabaseEnums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using System;

namespace DataAccess.Migrations.Seed
{
    public class PersonSeed : BaseSeed
    {
        public static void Seed(EntityTypeBuilder<Person> builder)
        {
            DateTime date = DateTime.Now;

            builder.HasData(
                new Person()
                {
                    Id = 1,
                    CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
                    GenderTypeId = (byte)GenderTypes.MALE,
                    PersonStatusId = (byte)PersonStatuses.ACTIVE,
                    Pin = "60LWSDF",
                    Serial = "0686874",
                    Name = "Samir",
                    Surname = "Hasanov",
                    Patronymic = "Elmar",
                    Phone = "+994111111",
                    Email = "email@gmail.com",
                    AddedDate = date,
                },

                new Person()
                {
                    Id = 2,
                    CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
                    GenderTypeId = (byte)GenderTypes.MALE,
                    PersonStatusId = (byte)PersonStatuses.ACTIVE,
                    Pin = "20LWSDF",
                    Serial = "8956874",
                    Name = "Seymir",
                    Surname = "Muradov",
                    Patronymic = "Huseyn",
                    Phone = "+994111111",
                    Email = "email@gmail.com",
                    AddedDate = date,
                },

                new Person()
                {
                    Id = 3,
                    CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
                    GenderTypeId = (byte)GenderTypes.MALE,
                    PersonStatusId = (byte)PersonStatuses.ACTIVE,
                    Pin = "60LWGFHT",
                    Serial = "068687456",
                    Name = "Elbrus",
                    Surname = "Hesenov",
                    Patronymic = "Elmar",
                    Phone = "+994111111",
                    Email = "email@gmail.com",
                    AddedDate = date,
                },
                  new Person()
                  {
                      Id = 4,
                      CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
                      GenderTypeId = (byte)GenderTypes.MALE,
                      PersonStatusId = (byte)PersonStatuses.ACTIVE,
                      Pin = "78TYGFHT",
                      Serial = "0686265",
                      Name = "Shaxin",
                      Surname = "Hesenov",
                      Patronymic = "Eldar",
                      Phone = "+994111111",
                      Email = "email@gmail.com",
                      AddedDate = date,
                  },
                    new Person()
                    {
                        Id = 5,
                        CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
                        GenderTypeId = (byte)GenderTypes.MALE,
                        PersonStatusId = (byte)PersonStatuses.ACTIVE,
                        Pin = "89IUYFHT",
                        Serial = "87825878",
                        Name = "Asif",
                        Surname = "Rzayev",
                        Patronymic = "Tofiq",
                        Phone = "+994111111",
                        Email = "email@gmail.com",
                        AddedDate = date,
                    },
                    new Person()
                    {
                        Id = 6,
                        CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
                        GenderTypeId = (byte)GenderTypes.MALE,
                        PersonStatusId = (byte)PersonStatuses.ACTIVE,
                        Pin = "895LOI8",
                        Serial = "454575757",
                        Name = "Arif",
                        Surname = "Quliyev",
                        Patronymic = "Elmar",
                        Phone = "+994111111",
                        Email = "email@gmail.com",
                        AddedDate = date,
                    },
                        new Person()
                        {
                            Id = 7,
                            CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
                            GenderTypeId = (byte)GenderTypes.MALE,
                            PersonStatusId = (byte)PersonStatuses.ACTIVE,
                            Pin = "RTY7895",
                            Serial = "4545478",
                            Name = "Zaur",
                            Surname = "Melikov",
                            Patronymic = "Haci",
                            Phone = "+994111111",
                            Email = "email@gmail.com",
                            AddedDate = date,
                        },
                          new Person()
                          {
                              Id = 8,
                              CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
                              GenderTypeId = (byte)GenderTypes.MALE,
                              PersonStatusId = (byte)PersonStatuses.ACTIVE,
                              Pin = "85RTY45",
                              Serial = "545645767",
                              Name = "Ferid",
                              Surname = "Ismayilov",
                              Patronymic = "Veli",
                              Phone = "+994111111",
                              Email = "email@gmail.com",
                              AddedDate = date,
                          },
                            new Person()
                            {
                                Id = 9,
                                CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
                                GenderTypeId = (byte)GenderTypes.MALE,
                                PersonStatusId = (byte)PersonStatuses.ACTIVE,
                                Pin = "89LDJF788",
                                Serial = "86786567",
                                Name = "Eldar",
                                Surname = "Hesenov",
                                Patronymic = "Harun",
                                Phone = "+994111111",
                                Email = "email@gmail.com",
                                AddedDate = date,
                            },
                      new Person()
                      {
                          Id = 10,
                          CitizenTypeId = (byte)CitizenTypes.AZERBAIJANI,
                          GenderTypeId = (byte)GenderTypes.MALE,
                          PersonStatusId = (byte)PersonStatuses.ACTIVE,
                          Pin = "98JUF232",
                          Serial = "456786786",
                          Name = "Kamil",
                          Surname = "Memmedov",
                          Patronymic = "Ilqar",
                          Phone = "+994111111",
                          Email = "email@gmail.com",
                          AddedDate = date,
                      }

            );
        }
    }
}
