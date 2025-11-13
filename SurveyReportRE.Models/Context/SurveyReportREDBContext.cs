using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using SurveyReportRE.Models.Migration.Business.MasterData;
using SurveyReportRE.Models.Migration.Config;
using SurveyReportRE.Models.Migration.Business.HumanResource;
using SurveyReportRE.Models.Migration.Business.Form;
using SurveyReportRE.Models.Migration.Business.Data;
using SurveyReportRE.Models.Migration.Business.Workflow;
using Microsoft.Identity.Client;
namespace SurveyReportRE.Models
{
    //public partial class SurveyReportREDBContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>, ICloneable
    public partial class SurveyReportREDBContext : IdentityDbContext< User,Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>, ICloneable
	{
		public LoggingUser LoggingUser { get; set; } = new LoggingUser();

		public SurveyReportREDBContext(DbContextOptions<SurveyReportREDBContext> options) : base(options)
		{
			Database.SetCommandTimeout(1800);
			this.Options = options;
		}

		public object Clone()
		{
			return this.MemberwiseClone();
		}

		public DbContextOptions<SurveyReportREDBContext> Options
		{
			get;
		}


		#region Report 
		//public DbSet<Report> Report { get; set; }
		#endregion

		#region TMIV
		public DbSet<Employee>  Employee { get; set; }
		public DbSet<Wording> Wording { get; set; }
		public DbSet<Client> Client { get; set; }
		public DbSet<Location> Location { get; set; }
		public DbSet<Menu> Menu { get; set; }
		public DbSet<DataGridConfig> DataGridConfig { get; set; }
		public DbSet<EnumData> EnumData { get; set; }
		public DbSet<SysTable> SysTable { get; set; }
		public DbSet<ClientLocationDetail> ClientLocationDetail { get; set; }
		public DbSet<Survey> Survey { get; set; }
		public DbSet<Attachment> Attachment {get;set;}
		public DbSet<FormatCodeNo> FormatCodeNo {get;set;}
		public DbSet<MailTemplate> MailTemplate {get;set;}
		public DbSet<UrlCall> UrlCall {get;set;}
		public DbSet<DataGridConfigDynamic> DataGridConfigDynamic { get;set;}
		public DbSet<UserWorkflow> UserWorkflow { get;set;}
		public DbSet<InstanceWorkflow> InstanceWorkflow {get;set;}
		public DbSet<StepsWorkflow> StepsWorkflow {get;set;}
		public DbSet<FileEncrypt> FileEncrypt {get;set;}
		public DbSet<UsersCache> UsersCache {get;set;}
		public DbSet<ClientBrowserError> ClientBrowserError {get;set;}
		public DbSet<UsersSession> UsersSession {get;set;}
		public DbSet<MailQueue> MailQueue {get;set;}
		public DbSet<QueryLog> QueryLog { get; set; }
		public DbSet<Constant> Constant { get; set; }
		public DbSet<PendingJoget> PendingJoget { get; set; }
		public DbSet<PolicyIssuanceRequest> PolicyIssuanceRequest { get; set; }
		public DbSet<PolicyIssuanceProcess> PolicyIssuanceProcess { get; set; }
		public DbSet<RecordIdTracking> RecordIdTracking { get; set; }
		public DbSet<ReinsurranceQuarterly> ReinsurranceQuarterly { get; set; }
		public DbSet<QuotationProcess> QuotationProcess { get; set; }
		public DbSet<QuotationRequest> QuotationRequest { get; set; }
		public DbSet<RecordWorkflow> RecordWorkflow { get; set; }
		public DbSet<SystemProperties> SystemProperties { get; set; }

		#endregion

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Role>().ToTable("AspNetRoles");
			modelBuilder.Entity<UserClaim>().ToTable("AspNetUserClaims");
			modelBuilder.Entity<UserLogin>().ToTable("AspNetUserLogins");
			modelBuilder.Entity<UserRole>().ToTable("AspNetUserRoles");
			//modelBuilder.Entity<User>().ToTable("AspNetUsers");
			modelBuilder.Entity<Users>().ToTable("Users");
			modelBuilder.Entity<Roles>().ToTable("Roles");
			modelBuilder.Entity<UserRoles>().ToTable("UserRoles");
			var aspNetNames = new string[] { "SurveyReportRE.Models.User", "SurveyReportRE.Models.Role", "SurveyReportRE.Models.UserClaim", "SurveyReportRE.Models.UserRole", "SurveyReportRE.Models.UserLogin", "SurveyReportRE.Models.RoleClaim", "SurveyReportRE.Models.UserToken" };
			var models = modelBuilder.Model.GetEntityTypes().Where(x => !aspNetNames.Contains(x.Name));


			foreach (var p in models
			   .SelectMany(t => t.GetProperties())
			   .Where(p => p.ClrType == typeof(string) && p.GetMaxLength() == null))
			{

				if (p.Name.Contains("Url") == true || p.Name.Contains("URL") == true)
					p.SetMaxLength(2000);
				else if (p.Name.Contains("Note") || p.Name.Contains("Remark") || p.Name.Contains("Comment"))
					p.SetMaxLength(400);
				else if (p.Name.Contains("Desc") || p.Name == "access_token" || p.Name == "refresh_token")
					p.SetMaxLength(4000);
				else
					p.SetMaxLength(120);
			}


			foreach (var property in models
				.SelectMany(t => t.GetProperties())
				.Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
			{
				property.SetColumnType("decimal(28, 9)");
			}


			foreach (var property in models
				.SelectMany(t => t.GetProperties())
				.Where(p => p.ClrType == typeof(bool) || p.ClrType == typeof(bool?)))
			{
				property.SetDefaultValueSql("0");
			}


			foreach (var p in models.SelectMany(t => t.GetProperties()).Where(p => p.Name == "Guid"))
			{
				p.SetDefaultValueSql("NEWID()");
			}
			foreach (var p in models.SelectMany(t => t.GetProperties()).Where(p => p.Name == "IsActive" || p.Name == "Active"))
			{
				p.SetDefaultValueSql("1");
			}
			foreach (var p in models.SelectMany(t => t.GetProperties()).Where(p => p.Name == "CreatedDate"))
			{
				p.SetDefaultValueSql("GETDATE()");
			}


			HandleAdminsModel(modelBuilder);
			HandleIdentityModel(modelBuilder);
			HandleEmployeeModel(modelBuilder);

		}

		private void HandleAdminsModel(ModelBuilder modelBuilder)
		{



		}

		private void HandleIdentityModel(ModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<User>().Property(p => p.ConcurrencyStamp).IsConcurrencyToken(false);
			modelBuilder.Entity<Role>().Property(p => p.ConcurrencyStamp).IsConcurrencyToken(false);

			//modelBuilder.Entity<User>().HasKey(u => u.Id);
			modelBuilder.Entity<Role>().HasKey(u => u.Id);
		}

		private void HandleEmployeeModel(ModelBuilder modelBuilder)
		{

		}

		private void HandleOKRModel(ModelBuilder modelBuilder)
		{
			;
		}
	}
}
