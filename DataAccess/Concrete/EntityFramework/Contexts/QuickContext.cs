using Entities.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Concrete.EntityFramework.Contexts
{
	public class QuickContext : DbContext
	{
		//public QuickContext(DbContextOptions<QuickContext> options) : base(options)
		//{
		//}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-JARFS2I\MSSQLSERVER01;Database=Quick;Integrated Security=True;TrustServerCertificate=True;");
		}




		//public DbSet<PolicyCoverage> PolicyCoverages { get; set; }
		public DbSet<Coverage> Coverage { get; set; }
		public DbSet<Customer> Customer { get; set; }
		public DbSet<City> City { get; set; }
		public DbSet<Payment> Payment { get; set; }
		public DbSet<Declaration> Declaration { get; set; }
		public DbSet<DeclarationPerson> Declaration_Person { get; set; }
		public DbSet<Policy> Policy { get; set; }
		public DbSet<PolicyCoverage> Policy_Coverage { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// City tablosunun birincil anahtarını tanımlar
			modelBuilder.Entity<City>()
				.HasKey(c => c.City_Id);

			// Customer tablosunun birincil anahtarını tanımlar
			modelBuilder.Entity<Customer>()
				.HasKey(c => c.Customer_No);

			//Coverage tablosunun birincil anahtarını tanımlar
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Coverage>().HasKey(c => c.Coverage_Code);
			//Payment tablosunun birincil anahtarını tanımlar
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Payment>().HasKey(p => p.Payment_Id);
			//Declaration tablosunun birincil anahtarını tanımlar
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Declaration>().HasKey(d => d.Declaration_Id);

			//Declaration Person tablosunun birincil anahtarını tanımlar
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<DeclarationPerson>()
	.HasKey(d => new { d.Declaration_Id, d.Customer_No });

			//Policy tablosunun birincil anahtarını tanımlar
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Policy>()
	.HasKey(p => p.Policy_No);
			//Policy Coverage tablosunun birincil anahtarını tanımlar
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<PolicyCoverage>()
	.HasKey(p => new { p.Policy_No, p.Coverage_Code });


		}

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	// Foreign key relationships
		//	modelBuilder.Entity<Policy>()
		//		.HasOne(p => p.Insured)
		//		.WithMany(c => c.InsuredPolicies)
		//		.HasForeignKey(p => p.Insured_No);

		//	modelBuilder.Entity<Policy>()
		//		.HasOne(p => p.Policyholder)
		//		.WithMany(c => c.PolicyholderPolicies)
		//		.HasForeignKey(p => p.Policyholder_No);

		//	modelBuilder.Entity<PolicyCoverage>()
		//		.HasKey(pc => new { pc.Policy_No, pc.Coverage_Code });

		//	modelBuilder.Entity<PolicyCoverage>()
		//		.HasOne(pc => pc.Policy)
		//		.WithMany(p => p.PolicyCoverages)
		//		.HasForeignKey(pc => pc.Policy_No);

		//	modelBuilder.Entity<PolicyCoverage>()
		//		.HasOne(pc => pc.Coverage)
		//		.WithMany(c => c.PolicyCoverages)
		//		.HasForeignKey(pc => pc.Coverage_Code);

		//	modelBuilder.Entity<Payment>()
		//		.HasOne(p => p.Policy)
		//		.WithMany()
		//		.HasForeignKey(p => p.Policy_No);

		//	modelBuilder.Entity<Payment>()
		//		.HasOne(p => p.Customer)
		//		.WithMany(c => c.Payments)
		//		.HasForeignKey(p => p.Customer_No);

		//	modelBuilder.Entity<DeclarationPerson>()
		//		.HasKey(dp => new { dp.Declaration_Id, dp.Customer_No });

		//	modelBuilder.Entity<DeclarationPerson>()
		//		.HasOne(dp => dp.Declaration)
		//		.WithMany()
		//		.HasForeignKey(dp => dp.Declaration_Id);

		//	modelBuilder.Entity<DeclarationPerson>()
		//		.HasOne(dp => dp.Customer)
		//		.WithMany(c => c.DeclarationPersons)
		//		.HasForeignKey(dp => dp.Customer_No);

		//	base.OnModelCreating(modelBuilder);
		//}
		//}

	}
}
