using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace api.Models
{
    public partial class NSS_ProductionContext : DbContext
    {
        public NSS_ProductionContext()
        {
        }

        public NSS_ProductionContext(DbContextOptions<NSS_ProductionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BudgetExpenditure> BudgetExpenditure { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Commodities> Commodities { get; set; }
        public virtual DbSet<Csdsupplier> Csdsuppliers { get; set; }
        public virtual DbSet<CsdsuppliersV2> CsdsuppliersV2 { get; set; }
        public virtual DbSet<Directors> Directors { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<IntegrationLog> IntegrationLog { get; set; }
        public virtual DbSet<Municipalities> Municipalities { get; set; }
        public virtual DbSet<Npovendors2> Npovendors2 { get; set; }
        public virtual DbSet<Npovendors3> Npovendors3 { get; set; }
        public virtual DbSet<Parameter> Parameter { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }
        public virtual DbSet<Suburbs> Suburbs { get; set; }
        public virtual DbSet<SupplierCommodityIndex> SupplierCommodityIndex { get; set; }
        public virtual DbSet<WalkerIndex> WalkerIndex { get; set; }
        public virtual DbSet<WalkerOrderHeaders> WalkerOrderHeaders { get; set; }
        public virtual DbSet<WalkerVendors> WalkerVendors { get; set; }

        // Unable to generate entity type for table 'dbo.suppliers100$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Unregistered03'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Unregistered07'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Unregistered10'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CiproTest'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\;Database=NSS_Production;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<BudgetExpenditure>(entity =>
            {
                entity.Property(e => e.April).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AssetsCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.August).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AvailableBudget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Commitment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentBudget).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.December).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.February).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FundCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.InfrastructureCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ItemLevel3).HasMaxLength(50);

                entity.Property(e => e.ItemLevel4).HasMaxLength(50);

                entity.Property(e => e.January).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.July).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.June).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.March).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.May).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.November).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ObjectiveCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectiveLevel4).HasMaxLength(50);

                entity.Property(e => e.October).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProgrammeLevel5).HasMaxLength(50);

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.RegionalCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsibilityCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.September).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubProgrammeLevel6).HasMaxLength(50);

                entity.Property(e => e.TotalExpenditure).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityCode).HasMaxLength(6);

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.MunicipalityCode).HasMaxLength(3);
            });

            modelBuilder.Entity<Commodities>(entity =>
            {
                entity.HasKey(e => e.CommodityId);

                entity.Property(e => e.CommodityCode).HasMaxLength(8);

                entity.Property(e => e.CommodityName).HasMaxLength(50);
            });

            modelBuilder.Entity<Csdsupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.ToTable("CSDSuppliers");

                entity.HasIndex(e => e.IntegrationId)
                    .HasName("IX_IntegrationId");

                entity.HasIndex(e => e.SupplierNumber)
                    .HasName("IX_CSDSuppliers")
                    .IsUnique();

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.AccountNumber).HasMaxLength(15);

                entity.Property(e => e.AddressLine1).HasMaxLength(150);

                entity.Property(e => e.AddressLine2).HasMaxLength(150);

                entity.Property(e => e.BankAccountStatusCode).HasMaxLength(2);

                entity.Property(e => e.BankAccountTypeCode).HasMaxLength(3);

                entity.Property(e => e.BankName).HasMaxLength(3);

                entity.Property(e => e.BranchNumber).HasMaxLength(8);

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.CompanyReg).HasMaxLength(50);

                entity.Property(e => e.ContactCellphoneNumber).HasMaxLength(50);

                entity.Property(e => e.ContactEmailAddress).HasMaxLength(150);

                entity.Property(e => e.ContactName).HasMaxLength(150);

                entity.Property(e => e.ContactSurname).HasMaxLength(150);

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasMaxLength(30);

                entity.Property(e => e.DistrictName).HasMaxLength(50);

                entity.Property(e => e.EditDate).HasMaxLength(30);

                entity.Property(e => e.IdtypeCode)
                    .HasColumnName("IDTypeCode")
                    .HasMaxLength(3);

                entity.Property(e => e.IsActive).HasMaxLength(5);

                entity.Property(e => e.LegalName).HasMaxLength(150);

                entity.Property(e => e.MunicipalityName).HasMaxLength(50);

                entity.Property(e => e.PostalCode).HasMaxLength(4);

                entity.Property(e => e.ProvinceName).HasMaxLength(150);

                entity.Property(e => e.SourceFile).HasMaxLength(150);

                entity.Property(e => e.SuburbName).HasMaxLength(50);

                entity.Property(e => e.SupplierNumber).HasMaxLength(11);

                entity.Property(e => e.TradingName).HasMaxLength(150);

                entity.Property(e => e.ValidAddress).HasMaxLength(3);

                entity.Property(e => e.WardName).HasMaxLength(50);
            });

            modelBuilder.Entity<CsdsuppliersV2>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.ToTable("CSDSuppliersV2");

                entity.HasIndex(e => e.SupplierNumber)
                    .HasName("IX_SupplierNumber");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.AccountNumber).HasMaxLength(15);

                entity.Property(e => e.AddressLine1).HasMaxLength(150);

                entity.Property(e => e.AddressLine2).HasMaxLength(150);

                entity.Property(e => e.BankAccountStatusCode).HasMaxLength(2);

                entity.Property(e => e.BankAccountTypeCode).HasMaxLength(3);

                entity.Property(e => e.BankName).HasMaxLength(3);

                entity.Property(e => e.BranchNumber).HasMaxLength(8);

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.CompanyReg).HasMaxLength(50);

                entity.Property(e => e.ContactCellphoneNumber).HasMaxLength(50);

                entity.Property(e => e.ContactEmailAddress).HasMaxLength(150);

                entity.Property(e => e.ContactName).HasMaxLength(150);

                entity.Property(e => e.ContactSurname).HasMaxLength(150);

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasMaxLength(30);

                entity.Property(e => e.DistrictName).HasMaxLength(50);

                entity.Property(e => e.EditDate).HasMaxLength(30);

                entity.Property(e => e.GovernmentEmployee)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdtypeCode)
                    .HasColumnName("IDTypeCode")
                    .HasMaxLength(3);

                entity.Property(e => e.IsActive).HasMaxLength(5);

                entity.Property(e => e.IsValidCertificate).HasMaxLength(5);

                entity.Property(e => e.LegalName).HasMaxLength(150);

                entity.Property(e => e.MunicipalityName).HasMaxLength(50);

                entity.Property(e => e.PostalCode).HasMaxLength(4);

                entity.Property(e => e.ProvinceName).HasMaxLength(150);

                entity.Property(e => e.RestrictedSupplier).HasMaxLength(5);

                entity.Property(e => e.SourceFile).HasMaxLength(150);

                entity.Property(e => e.SuburbName).HasMaxLength(50);

                entity.Property(e => e.SupplierNumber).HasMaxLength(11);

                entity.Property(e => e.SupplierSubType).HasMaxLength(3);

                entity.Property(e => e.SupplierType).HasMaxLength(3);

                entity.Property(e => e.TradingName).HasMaxLength(150);

                entity.Property(e => e.ValidAddress).HasMaxLength(3);

                entity.Property(e => e.WardName).HasMaxLength(50);
            });

            modelBuilder.Entity<Directors>(entity =>
            {
                entity.HasKey(e => e.DirectorId);

                entity.HasIndex(e => e.Idnumber)
                    .HasName("IX_IDNumber");

                entity.HasIndex(e => e.SupplierNumber)
                    .HasName("IX_SupplierNumber");

                entity.Property(e => e.DirectorStatusTypeCode).HasMaxLength(1);

                entity.Property(e => e.Employee).HasMaxLength(150);

                entity.Property(e => e.Idnumber)
                    .HasColumnName("IDNumber")
                    .HasMaxLength(13);

                entity.Property(e => e.IsActive).HasMaxLength(5);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SupplierNumber).HasMaxLength(11);

                entity.Property(e => e.Surname).HasMaxLength(50);
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.HasKey(e => e.DistrictId);

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.DistrictCode).HasMaxLength(3);

                entity.Property(e => e.DistrictName).HasMaxLength(50);

                entity.Property(e => e.ProvinceCode).HasMaxLength(1);
            });

            modelBuilder.Entity<IntegrationLog>(entity =>
            {
                entity.Property(e => e.DateIndexed).HasMaxLength(50);

                entity.Property(e => e.DateInterfaced).HasMaxLength(50);

                entity.Property(e => e.DateProcessed).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(50);
            });

            modelBuilder.Entity<Municipalities>(entity =>
            {
                entity.HasKey(e => e.MunicipalityId);

                entity.Property(e => e.MunicipalityId).HasColumnName("MunicipalityID");

                entity.Property(e => e.DistrictCode).HasMaxLength(3);

                entity.Property(e => e.MunicipalityCode).HasMaxLength(3);

                entity.Property(e => e.MunicipalityName).HasMaxLength(50);
            });

            modelBuilder.Entity<Npovendors2>(entity =>
            {
                entity.ToTable("NPOVendors2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber).HasMaxLength(255);

                entity.Property(e => e.AccountType).HasMaxLength(255);

                entity.Property(e => e.Address1).HasMaxLength(255);

                entity.Property(e => e.Address2).HasMaxLength(255);

                entity.Property(e => e.Address3).HasMaxLength(255);

                entity.Property(e => e.Address4).HasMaxLength(255);

                entity.Property(e => e.BankCode).HasMaxLength(255);

                entity.Property(e => e.BranchCode).HasMaxLength(255);

                entity.Property(e => e.CompReg).HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.IdtypeCode)
                    .HasColumnName("IDTypeCode")
                    .HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.SupplierCode).HasMaxLength(255);

                entity.Property(e => e.Tel)
                    .HasColumnName("TEL")
                    .HasMaxLength(255);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorCode).HasMaxLength(255);

                entity.Property(e => e.VendorName).HasMaxLength(255);
            });

            modelBuilder.Entity<Npovendors3>(entity =>
            {
                entity.ToTable("NPOVendors3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber).HasMaxLength(255);

                entity.Property(e => e.AccountType).HasMaxLength(255);

                entity.Property(e => e.Address1).HasMaxLength(255);

                entity.Property(e => e.Address2).HasMaxLength(255);

                entity.Property(e => e.Address3).HasMaxLength(255);

                entity.Property(e => e.Address4).HasMaxLength(255);

                entity.Property(e => e.BankCode).HasMaxLength(255);

                entity.Property(e => e.BranchCode).HasMaxLength(255);

                entity.Property(e => e.CompReg).HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.IdtypeCode)
                    .HasColumnName("IDTypeCode")
                    .HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.SupplierCode).HasMaxLength(255);

                entity.Property(e => e.Tel)
                    .HasColumnName("TEL")
                    .HasMaxLength(255);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorCode).HasMaxLength(255);

                entity.Property(e => e.VendorName).HasMaxLength(255);
            });

            modelBuilder.Entity<Provinces>(entity =>
            {
                entity.HasKey(e => e.ProvinceId);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.ProvinceCode).HasMaxLength(1);

                entity.Property(e => e.ProvinceName).HasMaxLength(50);
            });

            modelBuilder.Entity<Suburbs>(entity =>
            {
                entity.HasKey(e => e.SuburbId);

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.CityCode).HasMaxLength(6);

                entity.Property(e => e.SuburbCode).HasMaxLength(9);

                entity.Property(e => e.SuburbName).HasMaxLength(50);
            });

            modelBuilder.Entity<SupplierCommodityIndex>(entity =>
            {
                entity.HasKey(e => e.Scid);

                entity.Property(e => e.Scid).HasColumnName("SCID");

                entity.Property(e => e.CommodityItem).HasMaxLength(8);

                entity.Property(e => e.SupplierNumber).HasMaxLength(11);
            });

            modelBuilder.Entity<WalkerIndex>(entity =>
            {
                entity.HasIndex(e => e.SupplierNumber)
                    .HasName("IX_SupplierNumber");

                entity.Property(e => e.AccountNumber).HasMaxLength(30);

                entity.Property(e => e.AccountTypeCode).HasMaxLength(15);

                entity.Property(e => e.AddressLine1).HasMaxLength(50);

                entity.Property(e => e.AddressLine2).HasMaxLength(50);

                entity.Property(e => e.AddressLine3).HasMaxLength(50);

                entity.Property(e => e.AddressLine4).HasMaxLength(50);

                entity.Property(e => e.AddressLine5).HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(25);

                entity.Property(e => e.BranchNumber).HasMaxLength(15);

                entity.Property(e => e.CityName).HasMaxLength(30);

                entity.Property(e => e.CompanyReg).HasMaxLength(50);

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasMaxLength(30);

                entity.Property(e => e.Editdate).HasMaxLength(30);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.HoldingCompany).HasMaxLength(60);

                entity.Property(e => e.IdtypeCode)
                    .HasColumnName("IDTypeCode")
                    .HasMaxLength(30);

                entity.Property(e => e.IndustryClassification).HasMaxLength(10);

                entity.Property(e => e.InterfaceStatus).HasMaxLength(10);

                entity.Property(e => e.InterfaceStatusDate).HasMaxLength(20);

                entity.Property(e => e.LegalName).HasMaxLength(60);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.SupplierNumber).HasMaxLength(11);

                entity.Property(e => e.TelNo).HasMaxLength(20);

                entity.Property(e => e.TradingName).HasMaxLength(60);

                entity.Property(e => e.VendorCode).HasMaxLength(9);

                entity.Property(e => e.ZipCode).HasMaxLength(10);
            });

            modelBuilder.Entity<WalkerOrderHeaders>(entity =>
            {
                entity.Property(e => e.AuthDate).HasColumnType("date");

                entity.Property(e => e.CaptureDate).HasColumnType("date");

                entity.Property(e => e.GrossValue).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PaidValue).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WalkerVendors>(entity =>
            {
                entity.HasKey(e => e.VendorId);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.AccountType).HasMaxLength(50);

                entity.Property(e => e.Address1).HasMaxLength(150);

                entity.Property(e => e.Address2).HasMaxLength(150);

                entity.Property(e => e.Address3).HasMaxLength(150);

                entity.Property(e => e.BankCode).HasMaxLength(50);

                entity.Property(e => e.BranchCode).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.CompReg).HasMaxLength(21);

                entity.Property(e => e.Created).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.IdtypeCode)
                    .HasColumnName("IDTypeCode")
                    .HasMaxLength(10);

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.SupplierCode).HasMaxLength(50);

                entity.Property(e => e.TelNo).HasMaxLength(50);

                entity.Property(e => e.Updated).HasMaxLength(50);

                entity.Property(e => e.VendorCode).HasMaxLength(50);

                entity.Property(e => e.VendorName).HasMaxLength(150);
            });
        }
    }
}
