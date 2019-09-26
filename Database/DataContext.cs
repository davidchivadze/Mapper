using Microsoft.EntityFrameworkCore;
using Models.EntityModels.Auth;
using Models.EntityModels.HR;
using Models.EntityModels.Shared;
using Models.EntityModels.ExcelLoan;
using System;

namespace Database
{
    public class DataContext:DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=localhost\\MSSQLDavid;Database=ExcelMapper;Integrated Security=True");
        }


        public DbSet<User> User { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<DutyStation> DutyStations { get; set; }
        public DbSet<EmployeeJobData> EmployeeJobDatas { get; set; }
        public DbSet<EmployeeMobileNumber> EmployeeMobileNumbers { get; set; }
        public DbSet<EmployeePerson> EmployeePersons { get; set; }
        public DbSet<EmployeePossition> EmployeePossitions { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<ManagerAgreementType> ManagerAgreementTypes { get; set; }
        public DbSet<MobileNumberType> MobileNumberTypes { get; set; }
        public DbSet<OrganizationEntity> OrganizationEntities { get; set; }
        public DbSet<UploadFile> UploadFileEntities { get; set; }
        public DbSet<UploadFileType> UploadFileTypeEntities { get; set; }
        public DbSet<FileMapping> FileMappings { get; set; }
        public DbSet<ReadFiles> ReadFiles { get; set; }
        public DbSet<UnplanedExcelData> UnplanedExcelDatas { get; set; }
        public DbSet<VariableType> VariableTypes { get; set; }
        public DbSet<ReadFileStatus> ReadFileStatuses { get; set; }
    }
}
