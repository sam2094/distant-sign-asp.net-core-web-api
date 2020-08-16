using Microsoft.EntityFrameworkCore;
using DataAccess.Database.EntityConfiguration;
using Models.Entities;

namespace DataAccess.Database
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options)
			: base(options)
		{
		}

		public virtual DbSet<Branch> Branches { get; set; }
		public virtual DbSet<BranchUser> BranchUsers { get; set; }
		public virtual DbSet<Certificate> Certificates { get; set; }
		public virtual DbSet<CertificateStatus> CertificateStatuses { get; set; }
		public virtual DbSet<CertificateTimeLog> CertificateTimeLogs { get; set; }
		public virtual DbSet<CertificateType> GetCertificateTypes { get; set; }
		public virtual DbSet<ChangesLog> GetChangesLogs { get; set; }
		public virtual DbSet<CitizenType> CitizenTypes { get; set; }
		public virtual DbSet<Claim> Claims { get; set; }
		public virtual DbSet<Coupon> Coupons { get; set; }
		public virtual DbSet<Discount> Discounts { get; set; }
		public virtual DbSet<DiscountType> DiscountTypes { get; set; }
		public virtual DbSet<Employee> Employees { get; set; }
		public virtual DbSet<ExceptionLog> ExceptionLogs { get; set; }
		public virtual DbSet<GenderType> GenderTypes { get; set; }
		public virtual DbSet<LogType> LogTypes { get; set; }
		public virtual DbSet<OperationPriceType> OperationPriceTypes { get; set; }
		public virtual DbSet<Organization> Organizations { get; set; }
		public virtual DbSet<OrganizationDiscount> OrganizationDiscounts { get; set; }
		public virtual DbSet<OtpCode> OtpCodes { get; set; }
		public virtual DbSet<OtpCodeStatus> OtpCodeStatuses { get; set; }
		public virtual DbSet<Person> Persons { get; set; }
		public virtual DbSet<PersonOrganization> PersonOrganizations { get; set; }
		public virtual DbSet<PersonStatus> PersonStatuses { get; set; }
		public virtual DbSet<PinCode> PinCodes { get; set; }
		public virtual DbSet<Position> Positions { get; set; }
		public virtual DbSet<Price> Prices { get; set; }
		public virtual DbSet<Role> Roles { get; set; }
		public virtual DbSet<RoleClaim> RoleClaims { get; set; }
		public virtual DbSet<SignOperation> SignOperations { get; set; }
		public virtual DbSet<SignTimeLog> SignTimeLogs { get; set; }
		public virtual DbSet<SmsLog> SmsLogs { get; set; }
		public virtual DbSet<TemporaryPerson> TemporaryPersons { get; set; }
		public virtual DbSet<Token> Tokens { get; set; }
		public virtual DbSet<TokenStatus> TokenStatuses { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<UserStatus> UserStatuses { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserStatusConfiguration());
			modelBuilder.ApplyConfiguration(new TokenStatusConfiguration());
			modelBuilder.ApplyConfiguration(new PersonStatusConfiguration());
			modelBuilder.ApplyConfiguration(new OtpCodeStatusConfiguration());
			modelBuilder.ApplyConfiguration(new CertificateStatusConfiguration());
			modelBuilder.ApplyConfiguration(new OperationPriceTypeConfiguration());
			modelBuilder.ApplyConfiguration(new LogTypeConfiguration());
			modelBuilder.ApplyConfiguration(new GenderTypeConfiguration());
			modelBuilder.ApplyConfiguration(new DiscountTypeConfiguration());
			modelBuilder.ApplyConfiguration(new CitizenTypeConfiguration());
			modelBuilder.ApplyConfiguration(new CertificateTypeConfiguration());
			modelBuilder.ApplyConfiguration(new DiscountConfiguration());
			modelBuilder.ApplyConfiguration(new RoleConfiguration());
			modelBuilder.ApplyConfiguration(new ClaimConfiguration());
			modelBuilder.ApplyConfiguration(new RoleClaimConfiguration());
			modelBuilder.ApplyConfiguration(new UserConfiguration());
			modelBuilder.ApplyConfiguration(new OrganizationConfiguration());
			modelBuilder.ApplyConfiguration(new BranchConfiguration());
			modelBuilder.ApplyConfiguration(new BranchUserConfiguration());
			modelBuilder.ApplyConfiguration(new PersonConfiguration());
			modelBuilder.ApplyConfiguration(new CertificateConfiguration());
			// bellow valid position
			modelBuilder.ApplyConfiguration(new CertificateTimeLogConfiguration());
			modelBuilder.ApplyConfiguration(new ChangesLogConfiguration());
			modelBuilder.ApplyConfiguration(new CouponConfiguration());
			modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
			modelBuilder.ApplyConfiguration(new ExceptionLogConfiguration());
			modelBuilder.ApplyConfiguration(new OrganizationDiscountConfiguration());
			modelBuilder.ApplyConfiguration(new OtpCodeConfiguration());
			modelBuilder.ApplyConfiguration(new PersonOrganizationConfiguration());
			modelBuilder.ApplyConfiguration(new PinCodeConfiguration());
			modelBuilder.ApplyConfiguration(new PositionConfiguration());
			modelBuilder.ApplyConfiguration(new PriceConfiguration());
			modelBuilder.ApplyConfiguration(new SignOperationConfiguration());
			modelBuilder.ApplyConfiguration(new SignTimeLogConfiguration());
			modelBuilder.ApplyConfiguration(new SmsLogConfiguration());
			modelBuilder.ApplyConfiguration(new TemporaryPersonConfiguration());
			modelBuilder.ApplyConfiguration(new TokenConfiguration());
		}
	}
}
