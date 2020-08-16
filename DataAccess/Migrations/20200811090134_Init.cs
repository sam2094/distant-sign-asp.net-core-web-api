using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.EnsureSchema(
                name: "status");

            migrationBuilder.EnsureSchema(
                name: "log");

            migrationBuilder.EnsureSchema(
                name: "type");

            migrationBuilder.CreateTable(
                name: "Claims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: true),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemporaryPersons",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pin = table.Column<string>(maxLength: 20, nullable: false),
                    PersonTypeId = table.Column<int>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemporaryPersons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CertificateTimeLogs",
                schema: "log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pin = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    RequestBegin = table.Column<DateTime>(nullable: false),
                    RequestEnd = table.Column<DateTime>(nullable: false),
                    IamasBegin = table.Column<DateTime>(nullable: false),
                    IamasEnd = table.Column<DateTime>(nullable: false),
                    RACABegin = table.Column<DateTime>(nullable: false),
                    RACAEnd = table.Column<DateTime>(nullable: false),
                    PersonalizationBegin = table.Column<DateTime>(nullable: false),
                    PersonalizationEnd = table.Column<DateTime>(nullable: false),
                    SmsBegin = table.Column<DateTime>(nullable: false),
                    SmsEnd = table.Column<DateTime>(nullable: false),
                    TotalRequestTime = table.Column<double>(nullable: false),
                    IamasTime = table.Column<double>(nullable: false),
                    RACATime = table.Column<double>(nullable: false),
                    PersonalizationTime = table.Column<double>(nullable: false),
                    SmsTime = table.Column<double>(nullable: false),
                    Guid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateTimeLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChangesLogs",
                schema: "log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogTypeId = table.Column<byte>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    ChangedDate = table.Column<DateTime>(nullable: false),
                    From = table.Column<string>(nullable: false),
                    To = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangesLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionLogs",
                schema: "log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(maxLength: 200, nullable: false),
                    Content = table.Column<string>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SignTimeLogs",
                schema: "log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pin = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    RequestBegin = table.Column<DateTime>(nullable: false),
                    RequestEnd = table.Column<DateTime>(nullable: false),
                    TotalTime = table.Column<double>(nullable: false),
                    Guid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignTimeLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CertificateStatuses",
                schema: "status",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtpCodeStatuses",
                schema: "status",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtpCodeStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonStatuses",
                schema: "status",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TokenStatuses",
                schema: "status",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokenStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserStatuses",
                schema: "status",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CertificateTypes",
                schema: "type",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CitizenTypes",
                schema: "type",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitizenTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscountTypes",
                schema: "type",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenderTypes",
                schema: "type",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogTypes",
                schema: "type",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationPriceTypes",
                schema: "type",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationPriceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolesClaims",
                schema: "dbo",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false),
                    ClaimId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesClaims", x => new { x.RoleId, x.ClaimId });
                    table.ForeignKey(
                        name: "FK_RolesClaims_Claims_ClaimId",
                        column: x => x.ClaimId,
                        principalSchema: "dbo",
                        principalTable: "Claims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolesClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountTypeId = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    DiscountValue = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounts_DiscountTypes_DiscountTypeId",
                        column: x => x.DiscountTypeId,
                        principalSchema: "type",
                        principalTable: "DiscountTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitizenTypeId = table.Column<byte>(nullable: false),
                    GenderTypeId = table.Column<byte>(nullable: false),
                    PersonStatusId = table.Column<byte>(nullable: false),
                    Pin = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Serial = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 50, nullable: false),
                    Patronymic = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_CitizenTypes_CitizenTypeId",
                        column: x => x.CitizenTypeId,
                        principalSchema: "type",
                        principalTable: "CitizenTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_GenderTypes_GenderTypeId",
                        column: x => x.GenderTypeId,
                        principalSchema: "type",
                        principalTable: "GenderTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_PersonStatuses_PersonStatusId",
                        column: x => x.PersonStatusId,
                        principalSchema: "status",
                        principalTable: "PersonStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    StatusId = table.Column<byte>(nullable: false),
                    GenderTypeId = table.Column<byte>(nullable: false),
                    CitizenTypeId = table.Column<byte>(nullable: false),
                    Pin = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<byte[]>(nullable: false),
                    Salt = table.Column<byte[]>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    LastLoginDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_CitizenTypes_CitizenTypeId",
                        column: x => x.CitizenTypeId,
                        principalSchema: "type",
                        principalTable: "CitizenTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_GenderTypes_GenderTypeId",
                        column: x => x.GenderTypeId,
                        principalSchema: "type",
                        principalTable: "GenderTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "Roles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_UserStatuses_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "status",
                        principalTable: "UserStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Voen = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Account = table.Column<int>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalSchema: "dbo",
                        principalTable: "Discounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tokens",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    TokenStatusId = table.Column<byte>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tokens_TokenStatuses_TokenStatusId",
                        column: x => x.TokenStatusId,
                        principalSchema: "status",
                        principalTable: "TokenStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tokens_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 250, nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branches_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalSchema: "dbo",
                        principalTable: "Organizations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    CertificateStatusId = table.Column<byte>(nullable: false),
                    CertificateTypeId = table.Column<byte>(nullable: false),
                    AuthCertThumbPrint = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    AuthCertSerialNumber = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    SignCertThumbPrint = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    SignCertSerialNumber = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ExpireDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificates_CertificateStatuses_CertificateStatusId",
                        column: x => x.CertificateStatusId,
                        principalSchema: "status",
                        principalTable: "CertificateStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Certificates_CertificateTypes_CertificateTypeId",
                        column: x => x.CertificateTypeId,
                        principalSchema: "type",
                        principalTable: "CertificateTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Certificates_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalSchema: "dbo",
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Certificates_Persons_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "dbo",
                        principalTable: "Persons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountId = table.Column<int>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    CertificateTypeId = table.Column<byte>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    BeginDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coupons_CertificateTypes_CertificateTypeId",
                        column: x => x.CertificateTypeId,
                        principalSchema: "type",
                        principalTable: "CertificateTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Coupons_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalSchema: "dbo",
                        principalTable: "Discounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Coupons_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalSchema: "dbo",
                        principalTable: "Organizations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrganizationsDiscounts",
                schema: "dbo",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(nullable: false),
                    DiscountId = table.Column<int>(nullable: false),
                    BeginDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationsDiscounts", x => new { x.OrganizationId, x.DiscountId });
                    table.ForeignKey(
                        name: "FK_OrganizationsDiscounts_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalSchema: "dbo",
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizationsDiscounts_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalSchema: "dbo",
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationId = table.Column<int>(nullable: false),
                    OperationPriceTypeId = table.Column<byte>(nullable: false),
                    CertificateTypeId = table.Column<byte>(nullable: false),
                    Value = table.Column<decimal>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prices_CertificateTypes_CertificateTypeId",
                        column: x => x.CertificateTypeId,
                        principalSchema: "type",
                        principalTable: "CertificateTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Prices_OperationPriceTypes_OperationPriceTypeId",
                        column: x => x.OperationPriceTypeId,
                        principalSchema: "type",
                        principalTable: "OperationPriceTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Prices_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalSchema: "dbo",
                        principalTable: "Organizations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BranchUsers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchUsers_Branches_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "dbo",
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BranchUsers_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SignOperations",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    DiscountId = table.Column<int>(nullable: false),
                    CouponId = table.Column<long>(nullable: false),
                    SignedDate = table.Column<DateTime>(nullable: false),
                    FileName = table.Column<string>(nullable: false),
                    SignSerial = table.Column<string>(maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    CalculatedPrice = table.Column<decimal>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignOperations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignOperations_Branches_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "dbo",
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SmsLogs",
                schema: "log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    SendDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SmsLogs_Branches_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "dbo",
                        principalTable: "Branches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: false),
                    CertificateId = table.Column<int>(nullable: false),
                    StatusId = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Certificates_CertificateId",
                        column: x => x.CertificateId,
                        principalSchema: "dbo",
                        principalTable: "Certificates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalSchema: "dbo",
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_Positions_OrganizationId",
                        column: x => x.OrganizationId,
                        principalSchema: "dbo",
                        principalTable: "Positions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_Persons_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "dbo",
                        principalTable: "Persons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OtpCodes",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateId = table.Column<int>(nullable: false),
                    OtpCodeStatusId = table.Column<byte>(nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtpCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtpCodes_Certificates_CertificateId",
                        column: x => x.CertificateId,
                        principalSchema: "dbo",
                        principalTable: "Certificates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OtpCodes_OtpCodeStatuses_OtpCodeStatusId",
                        column: x => x.OtpCodeStatusId,
                        principalSchema: "status",
                        principalTable: "OtpCodeStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PinCodes",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(maxLength: 50, nullable: false),
                    CertificateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PinCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PinCodes_Certificates_CertificateId",
                        column: x => x.CertificateId,
                        principalSchema: "dbo",
                        principalTable: "Certificates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PersonsOrganizations",
                schema: "dbo",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    BranchUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonsOrganizations", x => new { x.PersonId, x.OrganizationId });
                    table.ForeignKey(
                        name: "FK_PersonsOrganizations_BranchUsers_BranchUserId",
                        column: x => x.BranchUserId,
                        principalSchema: "dbo",
                        principalTable: "BranchUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonsOrganizations_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalSchema: "dbo",
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonsOrganizations_Persons_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "dbo",
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Claims",
                columns: new[] { "Id", "AddedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1416, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get roles", "CAN_GET_ROLES" },
                    { 1402, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can update user information", "CAN_UPDATE_USER" },
                    { 1403, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get users", "CAN_GET_USERS" },
                    { 1404, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can set or modify role on user", "CAN_SET_OR_MODIFY_ROLE_ON_USER" },
                    { 1405, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get user by id", "CAN_GET_USER_BY_ID" },
                    { 1406, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get user by username", "CAN_GET_USER_BY_USERNAME" },
                    { 1407, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get remote operator", "CAN_GET_REMOTE_OPERATOR" },
                    { 1408, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can update username", "CAN_UPDATE_USERNAME" },
                    { 1409, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can change password", "CAN_CHANGE_PASSWORD" },
                    { 1401, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can block a user", "CAN_BLOCK_USER" },
                    { 1410, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get users for dropdown", "CAN_GET_USERS_FOR_DROPDOWN" },
                    { 1412, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get user statuses", "CAN_GET_USER_STATUSES" },
                    { 1413, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get citizen types", "CAN_GET_CITIZEN_TYPES" },
                    { 1414, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get person statuses", "CAN_GET_PERSON_STATUSES" },
                    { 1415, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get claims", "CAN_GET_CLAIMS" },
                    { 1903, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can add branch", "CAN_ADD_BRANCH" },
                    { 1500, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can statistic by organization", "CAN_GET_STATISTIC_BY_ORGANIZATION" },
                    { 1501, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get common statistics", "CAN_GET_COMMON_STATISTICS" },
                    { 1900, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can add organization", "CAN_ADD_ORGANIZATION" },
                    { 1411, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get gender types", "CAN_GET_GENDER_TYPES" },
                    { 1400, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can add a new user", "CAN_ADD_USER" },
                    { 1204, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get log types", "CAN_GET_LOG_TYPES" },
                    { 1203, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get token statuses", "CAN_GET_TOKEN_STATUSES" },
                    { 1906, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get discounts", "CAN_GET_DISCOUNTS" },
                    { 1905, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can update branch", "CAN_GET_BRANCHES" },
                    { 1904, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can update branch", "CAN_UPDATE_BRANCH" },
                    { 1000, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can create citizen certificate", "CAN_CREATE_CITIZEN_CERTIFICATE" },
                    { 1901, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can update organization", "CAN_UPDATE_ORGANIZATION" },
                    { 1002, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can create owner certificate", "CAN_CREATE_OWNER_CERTIFICATE" },
                    { 1003, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can create government certificate", "CAN_CREATE_GOVERNMENT_CERTIFICATE" },
                    { 1001, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can create legal certificate", "CAN_CREATE_LEGAL_CERTIFICATE" },
                    { 1005, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get certificate statuses", "CAN_GET_CERTIFICATE_STATUSES" },
                    { 1006, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get certificate types", "CAN_GET_CERTIFICATE_TYPES" },
                    { 1007, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can sign", "CAN_SIGN" },
                    { 1200, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get discount types", "CAN_GET_DISCOUNT_TYPES" },
                    { 1201, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get OTP code statuses", "CAN_GET_OTP_CODE_STATUSES" },
                    { 1202, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get operation price types", "CAN_GET_OPERATION_PRICE_TYPES" },
                    { 1004, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can activate certificate", "CAN_ACTIVATE_CERTIFICATE" },
                    { 1902, new DateTime(2020, 8, 11, 13, 1, 33, 191, DateTimeKind.Local).AddTicks(1429), "Can get organizations", "CAN_GET_ORGANIZATIONS" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Roles",
                columns: new[] { "Id", "AddedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1000, new DateTime(2020, 8, 11, 13, 1, 33, 185, DateTimeKind.Local).AddTicks(9096), "Super Admin", "SUPER_ADMIN" },
                    { 2000, new DateTime(2020, 8, 11, 13, 1, 33, 185, DateTimeKind.Local).AddTicks(9096), "Organization Admin", "ORG_ADMIN" },
                    { 2001, new DateTime(2020, 8, 11, 13, 1, 33, 185, DateTimeKind.Local).AddTicks(9096), "Manager", "MANAGER" },
                    { 2002, new DateTime(2020, 8, 11, 13, 1, 33, 185, DateTimeKind.Local).AddTicks(9096), "Operator", "OPERATOR" },
                    { 2003, new DateTime(2020, 8, 11, 13, 1, 33, 185, DateTimeKind.Local).AddTicks(9096), "Seller", "SELLER" }
                });

            migrationBuilder.InsertData(
                schema: "status",
                table: "CertificateStatuses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (byte)1, "Actived", "ACTIVE" },
                    { (byte)2, "Blocked", "BLOCKED" }
                });

            migrationBuilder.InsertData(
                schema: "status",
                table: "OtpCodeStatuses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (byte)2, "Used", "USED" },
                    { (byte)1, "Active", "ACTIVE" }
                });

            migrationBuilder.InsertData(
                schema: "status",
                table: "PersonStatuses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (byte)2, "Blocked", "BLOCKED" },
                    { (byte)1, "Actived", "ACTIVE" }
                });

            migrationBuilder.InsertData(
                schema: "status",
                table: "TokenStatuses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (byte)2, "Blocked", "BLOCKED" },
                    { (byte)1, "Active", "ACTIVE" }
                });

            migrationBuilder.InsertData(
                schema: "status",
                table: "UserStatuses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (byte)2, "Blocked", "BLOCKED" },
                    { (byte)1, "Active", "ACTIVE" }
                });

            migrationBuilder.InsertData(
                schema: "type",
                table: "CertificateTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (byte)1, "Citizen", "CITIZEN" },
                    { (byte)2, "Legal", "LEGAL" },
                    { (byte)3, "Government", "GOVERNMENT" },
                    { (byte)5, "Owner", "OWNER" }
                });

            migrationBuilder.InsertData(
                schema: "type",
                table: "CitizenTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (byte)3, "Temporary resident", "TEMPORARY_RESIDENT" },
                    { (byte)2, "Permanent resident", "PERMANENT_RESIDENT" },
                    { (byte)1, "Azerbaijani", "AZERBAIJANI" }
                });

            migrationBuilder.InsertData(
                schema: "type",
                table: "DiscountTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (byte)1, "Percent", "PERCENT" },
                    { (byte)2, "Amount", "AMOUNT" }
                });

            migrationBuilder.InsertData(
                schema: "type",
                table: "GenderTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (byte)1, "Female", "FEMALE" },
                    { (byte)2, "Male", "MALE" }
                });

            migrationBuilder.InsertData(
                schema: "type",
                table: "LogTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (byte)8, "Change Pin Code error", "CHANGE_PIN_CODE_ERROR" },
                    { (byte)1, "Change Role", "CHANGE_ROLE" },
                    { (byte)7, "Create certificate finish", "CREATE_CERTIFICATE_FINISH" },
                    { (byte)2, "Change Number", "CHANGE_NUMBER" },
                    { (byte)4, "Send SMS", "SEND_SMS" },
                    { (byte)5, "Sign", "SIGN" },
                    { (byte)11, "Create certificate finish error", "CREATE_CERTIFICATE_FINISH_ERROR" },
                    { (byte)6, "Create certificate start", "CREATE_CERTIFICATE_START" },
                    { (byte)9, "Send SMS error", "SEND_SMS_ERROR" },
                    { (byte)3, "Change Pin Code", "CHANGE_PIN_CODE" },
                    { (byte)10, "Create certificate start error", "CREATE_CERTIFICATE_START_ERROR" }
                });

            migrationBuilder.InsertData(
                schema: "type",
                table: "OperationPriceTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { (byte)2, "Certificate", "CERTIFICATE" },
                    { (byte)1, "Sign", "SIGN" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Discounts",
                columns: new[] { "Id", "DiscountTypeId", "DiscountValue", "Name" },
                values: new object[] { 1, (byte)1, 1m, "NO_DISCOUNT" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Persons",
                columns: new[] { "Id", "AddedDate", "CitizenTypeId", "Email", "GenderTypeId", "Name", "Patronymic", "PersonStatusId", "Phone", "Pin", "Serial", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 11, 13, 1, 33, 323, DateTimeKind.Local).AddTicks(8556), (byte)1, "email@gmail.com", (byte)2, "Samir", "Elmar", (byte)1, "+994111111", "60LWSDF", "0686874", "Hasanov" },
                    { 2, new DateTime(2020, 8, 11, 13, 1, 33, 323, DateTimeKind.Local).AddTicks(8556), (byte)1, "email@gmail.com", (byte)2, "Seymir", "Huseyn", (byte)1, "+994111111", "20LWSDF", "8956874", "Muradov" },
                    { 3, new DateTime(2020, 8, 11, 13, 1, 33, 323, DateTimeKind.Local).AddTicks(8556), (byte)1, "email@gmail.com", (byte)2, "Elbrus", "Elmar", (byte)1, "+994111111", "60LWGFHT", "068687456", "Hesenov" },
                    { 4, new DateTime(2020, 8, 11, 13, 1, 33, 323, DateTimeKind.Local).AddTicks(8556), (byte)1, "email@gmail.com", (byte)2, "Shaxin", "Eldar", (byte)1, "+994111111", "78TYGFHT", "0686265", "Hesenov" },
                    { 5, new DateTime(2020, 8, 11, 13, 1, 33, 323, DateTimeKind.Local).AddTicks(8556), (byte)1, "email@gmail.com", (byte)2, "Asif", "Tofiq", (byte)1, "+994111111", "89IUYFHT", "87825878", "Rzayev" },
                    { 6, new DateTime(2020, 8, 11, 13, 1, 33, 323, DateTimeKind.Local).AddTicks(8556), (byte)1, "email@gmail.com", (byte)2, "Arif", "Elmar", (byte)1, "+994111111", "895LOI8", "454575757", "Quliyev" },
                    { 7, new DateTime(2020, 8, 11, 13, 1, 33, 323, DateTimeKind.Local).AddTicks(8556), (byte)1, "email@gmail.com", (byte)2, "Zaur", "Haci", (byte)1, "+994111111", "RTY7895", "4545478", "Melikov" },
                    { 8, new DateTime(2020, 8, 11, 13, 1, 33, 323, DateTimeKind.Local).AddTicks(8556), (byte)1, "email@gmail.com", (byte)2, "Ferid", "Veli", (byte)1, "+994111111", "85RTY45", "545645767", "Ismayilov" },
                    { 9, new DateTime(2020, 8, 11, 13, 1, 33, 323, DateTimeKind.Local).AddTicks(8556), (byte)1, "email@gmail.com", (byte)2, "Eldar", "Harun", (byte)1, "+994111111", "89LDJF788", "86786567", "Hesenov" },
                    { 10, new DateTime(2020, 8, 11, 13, 1, 33, 323, DateTimeKind.Local).AddTicks(8556), (byte)1, "email@gmail.com", (byte)2, "Kamil", "Ilqar", (byte)1, "+994111111", "98JUF232", "456786786", "Memmedov" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RolesClaims",
                columns: new[] { "RoleId", "ClaimId" },
                values: new object[,]
                {
                    { 1000, 1906 },
                    { 1000, 1905 },
                    { 1000, 1904 },
                    { 1000, 1903 },
                    { 1000, 1902 },
                    { 1000, 1416 },
                    { 1000, 1900 },
                    { 1000, 1501 },
                    { 1000, 1500 },
                    { 2000, 1203 },
                    { 1000, 1901 },
                    { 2000, 1405 },
                    { 2000, 1416 },
                    { 2000, 1412 },
                    { 2000, 1413 },
                    { 2000, 1415 },
                    { 1000, 1415 },
                    { 2000, 1500 },
                    { 2000, 1501 },
                    { 2001, 1405 },
                    { 2001, 1411 },
                    { 2001, 1412 },
                    { 2001, 1413 },
                    { 2001, 1415 },
                    { 2000, 1411 },
                    { 1000, 1414 },
                    { 1000, 1410 },
                    { 1000, 1412 },
                    { 1000, 1000 },
                    { 1000, 1001 },
                    { 1000, 1002 },
                    { 1000, 1003 },
                    { 1000, 1004 },
                    { 1000, 1005 },
                    { 1000, 1006 },
                    { 1000, 1007 },
                    { 1000, 1200 },
                    { 1000, 1201 },
                    { 1000, 1413 },
                    { 1000, 1203 },
                    { 1000, 1202 },
                    { 1000, 1400 },
                    { 1000, 1411 },
                    { 1000, 1409 },
                    { 1000, 1204 },
                    { 1000, 1407 },
                    { 1000, 1406 },
                    { 1000, 1408 },
                    { 1000, 1404 },
                    { 1000, 1403 },
                    { 1000, 1402 },
                    { 1000, 1401 },
                    { 1000, 1405 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Users",
                columns: new[] { "Id", "AddedDate", "CitizenTypeId", "Email", "FullName", "GenderTypeId", "LastLoginDate", "Password", "PhoneNumber", "Pin", "RoleId", "Salt", "StatusId", "Username" },
                values: new object[,]
                {
                    { 5, new DateTime(2020, 8, 11, 13, 1, 33, 227, DateTimeKind.Local).AddTicks(8804), (byte)1, null, "Rauf Quliyev", (byte)2, new DateTime(2020, 8, 11, 13, 1, 33, 227, DateTimeKind.Local).AddTicks(8804), new byte[] { 234, 202, 187, 230, 14, 107, 194, 209, 102, 205, 249, 209, 54, 83, 54, 70, 15, 58, 17, 72, 209, 248, 9, 92, 43, 83, 39, 87, 175, 192, 208, 128, 163, 179, 161, 87, 147, 173, 60, 38, 214, 111, 102, 204, 75, 173, 92, 4, 242, 129, 209, 125, 151, 149, 119, 4, 149, 29, 192, 65, 23, 44, 219, 116 }, "555555", "70YWUJP", 2003, new byte[] { 213, 178, 216, 56, 8, 206, 13, 120, 94, 251, 195, 33, 47, 250, 219, 209, 39, 82, 118, 150, 145, 190, 219, 50, 57, 127, 33, 81, 142, 102, 57, 23, 135, 126, 29, 209, 133, 152, 76, 176, 67, 113, 251, 52, 154, 79, 175, 123, 104, 148, 179, 152, 167, 164, 114, 165, 111, 232, 81, 237, 199, 175, 124, 70 }, (byte)1, "e" },
                    { 1, new DateTime(2020, 8, 11, 13, 1, 33, 227, DateTimeKind.Local).AddTicks(8804), (byte)1, null, "Samir Hasanov", (byte)2, new DateTime(2020, 8, 11, 13, 1, 33, 227, DateTimeKind.Local).AddTicks(8804), new byte[] { 234, 202, 187, 230, 14, 107, 194, 209, 102, 205, 249, 209, 54, 83, 54, 70, 15, 58, 17, 72, 209, 248, 9, 92, 43, 83, 39, 87, 175, 192, 208, 128, 163, 179, 161, 87, 147, 173, 60, 38, 214, 111, 102, 204, 75, 173, 92, 4, 242, 129, 209, 125, 151, 149, 119, 4, 149, 29, 192, 65, 23, 44, 219, 116 }, "11111", "60LWSJG", 1000, new byte[] { 213, 178, 216, 56, 8, 206, 13, 120, 94, 251, 195, 33, 47, 250, 219, 209, 39, 82, 118, 150, 145, 190, 219, 50, 57, 127, 33, 81, 142, 102, 57, 23, 135, 126, 29, 209, 133, 152, 76, 176, 67, 113, 251, 52, 154, 79, 175, 123, 104, 148, 179, 152, 167, 164, 114, 165, 111, 232, 81, 237, 199, 175, 124, 70 }, (byte)1, "a" },
                    { 2, new DateTime(2020, 8, 11, 13, 1, 33, 227, DateTimeKind.Local).AddTicks(8804), (byte)1, null, "Ramiz Aliyev", (byte)2, new DateTime(2020, 8, 11, 13, 1, 33, 227, DateTimeKind.Local).AddTicks(8804), new byte[] { 234, 202, 187, 230, 14, 107, 194, 209, 102, 205, 249, 209, 54, 83, 54, 70, 15, 58, 17, 72, 209, 248, 9, 92, 43, 83, 39, 87, 175, 192, 208, 128, 163, 179, 161, 87, 147, 173, 60, 38, 214, 111, 102, 204, 75, 173, 92, 4, 242, 129, 209, 125, 151, 149, 119, 4, 149, 29, 192, 65, 23, 44, 219, 116 }, "22222", "70YWUJP", 2000, new byte[] { 213, 178, 216, 56, 8, 206, 13, 120, 94, 251, 195, 33, 47, 250, 219, 209, 39, 82, 118, 150, 145, 190, 219, 50, 57, 127, 33, 81, 142, 102, 57, 23, 135, 126, 29, 209, 133, 152, 76, 176, 67, 113, 251, 52, 154, 79, 175, 123, 104, 148, 179, 152, 167, 164, 114, 165, 111, 232, 81, 237, 199, 175, 124, 70 }, (byte)1, "b" },
                    { 3, new DateTime(2020, 8, 11, 13, 1, 33, 227, DateTimeKind.Local).AddTicks(8804), (byte)1, null, "Aydan Memmedova", (byte)1, new DateTime(2020, 8, 11, 13, 1, 33, 227, DateTimeKind.Local).AddTicks(8804), new byte[] { 234, 202, 187, 230, 14, 107, 194, 209, 102, 205, 249, 209, 54, 83, 54, 70, 15, 58, 17, 72, 209, 248, 9, 92, 43, 83, 39, 87, 175, 192, 208, 128, 163, 179, 161, 87, 147, 173, 60, 38, 214, 111, 102, 204, 75, 173, 92, 4, 242, 129, 209, 125, 151, 149, 119, 4, 149, 29, 192, 65, 23, 44, 219, 116 }, "33333", "70YWUJP", 2001, new byte[] { 213, 178, 216, 56, 8, 206, 13, 120, 94, 251, 195, 33, 47, 250, 219, 209, 39, 82, 118, 150, 145, 190, 219, 50, 57, 127, 33, 81, 142, 102, 57, 23, 135, 126, 29, 209, 133, 152, 76, 176, 67, 113, 251, 52, 154, 79, 175, 123, 104, 148, 179, 152, 167, 164, 114, 165, 111, 232, 81, 237, 199, 175, 124, 70 }, (byte)1, "c" },
                    { 4, new DateTime(2020, 8, 11, 13, 1, 33, 227, DateTimeKind.Local).AddTicks(8804), (byte)1, null, "Kamil Huseynov", (byte)2, new DateTime(2020, 8, 11, 13, 1, 33, 227, DateTimeKind.Local).AddTicks(8804), new byte[] { 234, 202, 187, 230, 14, 107, 194, 209, 102, 205, 249, 209, 54, 83, 54, 70, 15, 58, 17, 72, 209, 248, 9, 92, 43, 83, 39, 87, 175, 192, 208, 128, 163, 179, 161, 87, 147, 173, 60, 38, 214, 111, 102, 204, 75, 173, 92, 4, 242, 129, 209, 125, 151, 149, 119, 4, 149, 29, 192, 65, 23, 44, 219, 116 }, "444444", "70YWUJP", 2002, new byte[] { 213, 178, 216, 56, 8, 206, 13, 120, 94, 251, 195, 33, 47, 250, 219, 209, 39, 82, 118, 150, 145, 190, 219, 50, 57, 127, 33, 81, 142, 102, 57, 23, 135, 126, 29, 209, 133, 152, 76, 176, 67, 113, 251, 52, 154, 79, 175, 123, 104, 148, 179, 152, 167, 164, 114, 165, 111, 232, 81, 237, 199, 175, 124, 70 }, (byte)1, "d" },
                    { 6, new DateTime(2020, 8, 11, 13, 1, 33, 227, DateTimeKind.Local).AddTicks(8804), (byte)1, null, "Nermin Rzayeva", (byte)1, new DateTime(2020, 8, 11, 13, 1, 33, 227, DateTimeKind.Local).AddTicks(8804), new byte[] { 234, 202, 187, 230, 14, 107, 194, 209, 102, 205, 249, 209, 54, 83, 54, 70, 15, 58, 17, 72, 209, 248, 9, 92, 43, 83, 39, 87, 175, 192, 208, 128, 163, 179, 161, 87, 147, 173, 60, 38, 214, 111, 102, 204, 75, 173, 92, 4, 242, 129, 209, 125, 151, 149, 119, 4, 149, 29, 192, 65, 23, 44, 219, 116 }, "666666", "70YWUJP", 2001, new byte[] { 213, 178, 216, 56, 8, 206, 13, 120, 94, 251, 195, 33, 47, 250, 219, 209, 39, 82, 118, 150, 145, 190, 219, 50, 57, 127, 33, 81, 142, 102, 57, 23, 135, 126, 29, 209, 133, 152, 76, 176, 67, 113, 251, 52, 154, 79, 175, 123, 104, 148, 179, 152, 167, 164, 114, 165, 111, 232, 81, 237, 199, 175, 124, 70 }, (byte)1, "f" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Organizations",
                columns: new[] { "Id", "Account", "AddedDate", "DiscountId", "Name", "Voen" },
                values: new object[] { 1, 1, new DateTime(2020, 8, 11, 13, 1, 33, 311, DateTimeKind.Local).AddTicks(5038), 1, "MHM", "11111" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Organizations",
                columns: new[] { "Id", "Account", "AddedDate", "DiscountId", "Name", "Voen" },
                values: new object[] { 2, 2, new DateTime(2020, 8, 11, 13, 1, 33, 311, DateTimeKind.Local).AddTicks(5038), 1, "Kapital Bank", "222222" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Organizations",
                columns: new[] { "Id", "Account", "AddedDate", "DiscountId", "Name", "Voen" },
                values: new object[] { 3, 1, new DateTime(2020, 8, 11, 13, 1, 33, 311, DateTimeKind.Local).AddTicks(5038), 1, "Pasha Bank", "333333" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Branches",
                columns: new[] { "Id", "AddedDate", "Address", "Name", "OrganizationId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 11, 13, 1, 33, 315, DateTimeKind.Local).AddTicks(3839), "Address SXM", "SXM", 1 },
                    { 2, new DateTime(2020, 8, 11, 13, 1, 33, 315, DateTimeKind.Local).AddTicks(3839), "Address PS", "PS", 1 },
                    { 3, new DateTime(2020, 8, 11, 13, 1, 33, 315, DateTimeKind.Local).AddTicks(3839), "28 May", "28 May filiali", 2 },
                    { 4, new DateTime(2020, 8, 11, 13, 1, 33, 315, DateTimeKind.Local).AddTicks(3839), "Sahil", "Sahil filiali", 2 },
                    { 5, new DateTime(2020, 8, 11, 13, 1, 33, 315, DateTimeKind.Local).AddTicks(3839), "Nerimanov kucesi", "Bash Ofis", 3 },
                    { 6, new DateTime(2020, 8, 11, 13, 1, 33, 315, DateTimeKind.Local).AddTicks(3839), "Gence sheheri", "Gence filiali", 3 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Certificates",
                columns: new[] { "Id", "AddedDate", "AuthCertSerialNumber", "AuthCertThumbPrint", "CertificateStatusId", "CertificateTypeId", "ExpireDate", "OrganizationId", "PersonId", "Price", "SignCertSerialNumber", "SignCertThumbPrint" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3398), "11111111111", "AAAAAAAAAAAAAA", (byte)1, (byte)1, new DateTime(2021, 6, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3405), 1, 1, 38m, "1111111111", "AAAAAAAAAAAAA" },
                    { 2, new DateTime(2020, 8, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3398), "11111111111", "AAAAAAAAAAAAAA", (byte)1, (byte)3, new DateTime(2021, 6, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3405), 1, 2, 38m, "1111111111", "AAAAAAAAAAAAA" },
                    { 3, new DateTime(2020, 8, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3398), "11111111111", "AAAAAAAAAAAAAA", (byte)1, (byte)2, new DateTime(2021, 6, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3405), 1, 3, 50m, "1111111111", "AAAAAAAAAAAAA" },
                    { 4, new DateTime(2020, 8, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3398), "11111111111", "AAAAAAAAAAAAAA", (byte)1, (byte)5, new DateTime(2021, 6, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3405), 1, 4, 38m, "1111111111", "AAAAAAAAAAAAA" },
                    { 5, new DateTime(2020, 8, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3398), "11111111111", "AAAAAAAAAAAAAA", (byte)1, (byte)1, new DateTime(2021, 6, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3405), 1, 5, 18m, "1111111111", "AAAAAAAAAAAAA" },
                    { 6, new DateTime(2020, 8, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3398), "11111111111", "AAAAAAAAAAAAAA", (byte)1, (byte)3, new DateTime(2021, 6, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3405), 2, 6, 38m, "1111111111", "AAAAAAAAAAAAA" },
                    { 7, new DateTime(2020, 8, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3398), "11111111111", "AAAAAAAAAAAAAA", (byte)1, (byte)1, new DateTime(2021, 6, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3405), 2, 7, 38m, "1111111111", "AAAAAAAAAAAAA" },
                    { 8, new DateTime(2020, 8, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3398), "11111111111", "AAAAAAAAAAAAAA", (byte)1, (byte)1, new DateTime(2021, 6, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3405), 2, 8, 38m, "1111111111", "AAAAAAAAAAAAA" },
                    { 9, new DateTime(2020, 8, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3398), "11111111111", "AAAAAAAAAAAAAA", (byte)1, (byte)1, new DateTime(2021, 6, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3405), 3, 9, 48m, "1111111111", "AAAAAAAAAAAAA" },
                    { 10, new DateTime(2020, 8, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3398), "11111111111", "AAAAAAAAAAAAAA", (byte)1, (byte)2, new DateTime(2021, 6, 11, 13, 1, 33, 334, DateTimeKind.Local).AddTicks(3405), 3, 10, 28m, "1111111111", "AAAAAAAAAAAAA" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BranchUsers",
                columns: new[] { "Id", "AddedDate", "BranchId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 11, 13, 1, 33, 317, DateTimeKind.Local).AddTicks(9635), 1, 1 },
                    { 2, new DateTime(2020, 8, 11, 13, 1, 33, 317, DateTimeKind.Local).AddTicks(9635), 1, 2 },
                    { 3, new DateTime(2020, 8, 11, 13, 1, 33, 317, DateTimeKind.Local).AddTicks(9635), 2, 3 },
                    { 4, new DateTime(2020, 8, 11, 13, 1, 33, 317, DateTimeKind.Local).AddTicks(9635), 3, 4 },
                    { 5, new DateTime(2020, 8, 11, 13, 1, 33, 317, DateTimeKind.Local).AddTicks(9635), 3, 5 },
                    { 6, new DateTime(2020, 8, 11, 13, 1, 33, 317, DateTimeKind.Local).AddTicks(9635), 5, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branches_OrganizationId",
                schema: "dbo",
                table: "Branches",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchUsers_BranchId",
                schema: "dbo",
                table: "BranchUsers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchUsers_UserId",
                schema: "dbo",
                table: "BranchUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_CertificateStatusId",
                schema: "dbo",
                table: "Certificates",
                column: "CertificateStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_CertificateTypeId",
                schema: "dbo",
                table: "Certificates",
                column: "CertificateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_OrganizationId",
                schema: "dbo",
                table: "Certificates",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_PersonId",
                schema: "dbo",
                table: "Certificates",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_CertificateTypeId",
                schema: "dbo",
                table: "Coupons",
                column: "CertificateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_DiscountId",
                schema: "dbo",
                table: "Coupons",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_OrganizationId",
                schema: "dbo",
                table: "Coupons",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_DiscountTypeId",
                schema: "dbo",
                table: "Discounts",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CertificateId",
                schema: "dbo",
                table: "Employees",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_OrganizationId",
                schema: "dbo",
                table: "Employees",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PersonId",
                schema: "dbo",
                table: "Employees",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_DiscountId",
                schema: "dbo",
                table: "Organizations",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationsDiscounts_DiscountId",
                schema: "dbo",
                table: "OrganizationsDiscounts",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_OtpCodes_CertificateId",
                schema: "dbo",
                table: "OtpCodes",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_OtpCodes_OtpCodeStatusId",
                schema: "dbo",
                table: "OtpCodes",
                column: "OtpCodeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CitizenTypeId",
                schema: "dbo",
                table: "Persons",
                column: "CitizenTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_GenderTypeId",
                schema: "dbo",
                table: "Persons",
                column: "GenderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonStatusId",
                schema: "dbo",
                table: "Persons",
                column: "PersonStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonsOrganizations_BranchUserId",
                schema: "dbo",
                table: "PersonsOrganizations",
                column: "BranchUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonsOrganizations_OrganizationId",
                schema: "dbo",
                table: "PersonsOrganizations",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_PinCodes_CertificateId",
                schema: "dbo",
                table: "PinCodes",
                column: "CertificateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prices_CertificateTypeId",
                schema: "dbo",
                table: "Prices",
                column: "CertificateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_OperationPriceTypeId",
                schema: "dbo",
                table: "Prices",
                column: "OperationPriceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_OrganizationId",
                schema: "dbo",
                table: "Prices",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesClaims_ClaimId",
                schema: "dbo",
                table: "RolesClaims",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_SignOperations_BranchId",
                schema: "dbo",
                table: "SignOperations",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_TokenStatusId",
                schema: "dbo",
                table: "Tokens",
                column: "TokenStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_UserId",
                schema: "dbo",
                table: "Tokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CitizenTypeId",
                schema: "dbo",
                table: "Users",
                column: "CitizenTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GenderTypeId",
                schema: "dbo",
                table: "Users",
                column: "GenderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                schema: "dbo",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StatusId",
                schema: "dbo",
                table: "Users",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SmsLogs_BranchId",
                schema: "log",
                table: "SmsLogs",
                column: "BranchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupons",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OrganizationsDiscounts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OtpCodes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PersonsOrganizations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PinCodes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Prices",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RolesClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SignOperations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TemporaryPersons",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Tokens",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CertificateTimeLogs",
                schema: "log");

            migrationBuilder.DropTable(
                name: "ChangesLogs",
                schema: "log");

            migrationBuilder.DropTable(
                name: "ExceptionLogs",
                schema: "log");

            migrationBuilder.DropTable(
                name: "SignTimeLogs",
                schema: "log");

            migrationBuilder.DropTable(
                name: "SmsLogs",
                schema: "log");

            migrationBuilder.DropTable(
                name: "LogTypes",
                schema: "type");

            migrationBuilder.DropTable(
                name: "Positions",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OtpCodeStatuses",
                schema: "status");

            migrationBuilder.DropTable(
                name: "BranchUsers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Certificates",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OperationPriceTypes",
                schema: "type");

            migrationBuilder.DropTable(
                name: "Claims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TokenStatuses",
                schema: "status");

            migrationBuilder.DropTable(
                name: "Branches",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CertificateStatuses",
                schema: "status");

            migrationBuilder.DropTable(
                name: "CertificateTypes",
                schema: "type");

            migrationBuilder.DropTable(
                name: "Persons",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Organizations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserStatuses",
                schema: "status");

            migrationBuilder.DropTable(
                name: "CitizenTypes",
                schema: "type");

            migrationBuilder.DropTable(
                name: "GenderTypes",
                schema: "type");

            migrationBuilder.DropTable(
                name: "PersonStatuses",
                schema: "status");

            migrationBuilder.DropTable(
                name: "Discounts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DiscountTypes",
                schema: "type");
        }
    }
}
