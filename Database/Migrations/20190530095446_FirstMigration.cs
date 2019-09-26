using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DutyStations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShortName = table.Column<string>(maxLength: 255, nullable: false),
                    DutyStationName = table.Column<string>(maxLength: 255, nullable: false),
                    DutyStationAddress = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DutyStations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePossitions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    Description_en = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePossitions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ManagerAgreementTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Description_en = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerAgreementTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MobileNumberTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Description_en = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileNumberTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationEntities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    Description_en = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationEntities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReadFileStatuses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadFileStatuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleName = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UploadFileType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    FilesPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadFileType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 250, nullable: false),
                    LastName = table.Column<string>(maxLength: 250, nullable: false),
                    PIN = table.Column<string>(maxLength: 11, nullable: false),
                    Address = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(maxLength: 250, nullable: false),
                    Password = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VariableTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariableTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeMobileNumbers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: true),
                    NumberTypeID = table.Column<int>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMobileNumbers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmployeeMobileNumbers_MobileNumberTypes_NumberTypeID",
                        column: x => x.NumberTypeID,
                        principalTable: "MobileNumberTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReadFiles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FileName = table.Column<string>(nullable: true),
                    UploadFileTypeID = table.Column<int>(nullable: false),
                    ReadFileStatusID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadFiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReadFiles_ReadFileStatuses_ReadFileStatusID",
                        column: x => x.ReadFileStatusID,
                        principalTable: "ReadFileStatuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReadFiles_UploadFileType_UploadFileTypeID",
                        column: x => x.UploadFileTypeID,
                        principalTable: "UploadFileType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UploadFiles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UploadFileData = table.Column<byte[]>(nullable: true),
                    UploadFileTypeID = table.Column<int>(nullable: false),
                    UploadDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsImported = table.Column<bool>(nullable: false),
                    FileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadFiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UploadFiles_UploadFileType_UploadFileTypeID",
                        column: x => x.UploadFileTypeID,
                        principalTable: "UploadFileType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileMapping",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FileTypeID = table.Column<int>(nullable: false),
                    SheetName = table.Column<string>(nullable: true),
                    Cell = table.Column<string>(nullable: true),
                    VariableName = table.Column<string>(nullable: true),
                    VariableTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileMapping", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FileMapping_UploadFileType_FileTypeID",
                        column: x => x.FileTypeID,
                        principalTable: "UploadFileType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileMapping_VariableTypes_VariableTypeID",
                        column: x => x.VariableTypeID,
                        principalTable: "VariableTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePersons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PIN = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    BirthPlace = table.Column<string>(nullable: true),
                    EmployeeImage = table.Column<byte[]>(nullable: true),
                    EmployeMobileID = table.Column<string>(nullable: true),
                    IPPhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    GenderID = table.Column<int>(nullable: false),
                    EmployeeMobileNumberID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePersons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmployeePersons_EmployeeMobileNumbers_EmployeeMobileNumberID",
                        column: x => x.EmployeeMobileNumberID,
                        principalTable: "EmployeeMobileNumbers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeePersons_Genders_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Genders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnplanedExcelDatas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReadFileID = table.Column<int>(nullable: false),
                    VariableName = table.Column<string>(nullable: true),
                    ValueNvarchar = table.Column<string>(nullable: true),
                    ValueInt = table.Column<int>(nullable: false),
                    ValueDecimal = table.Column<decimal>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnplanedExcelDatas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UnplanedExcelDatas_ReadFiles_ReadFileID",
                        column: x => x.ReadFileID,
                        principalTable: "ReadFiles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeJobDatas",
                columns: table => new
                {
                    EmployeePersonID = table.Column<int>(nullable: false),
                    HireDate = table.Column<DateTime>(nullable: false),
                    ManagerAgreementTypeID = table.Column<int>(nullable: false),
                    DutyStationID = table.Column<int>(nullable: false),
                    EmployeePossitionID = table.Column<int>(nullable: false),
                    ChangeDate = table.Column<DateTime>(nullable: false),
                    ProbationExpirationDate = table.Column<DateTime>(nullable: false),
                    IsTemporaryEmployee = table.Column<bool>(nullable: false),
                    ManagerID = table.Column<int>(nullable: false),
                    OrganizationEntityID = table.Column<int>(nullable: false),
                    TerminationDate = table.Column<DateTime>(nullable: false),
                    ConsiderOveruse = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeJobDatas", x => x.EmployeePersonID);
                    table.ForeignKey(
                        name: "FK_EmployeeJobDatas_DutyStations_DutyStationID",
                        column: x => x.DutyStationID,
                        principalTable: "DutyStations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeJobDatas_EmployeePersons_EmployeePersonID",
                        column: x => x.EmployeePersonID,
                        principalTable: "EmployeePersons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeJobDatas_EmployeePossitions_EmployeePossitionID",
                        column: x => x.EmployeePossitionID,
                        principalTable: "EmployeePossitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeJobDatas_ManagerAgreementTypes_ManagerAgreementTypeID",
                        column: x => x.ManagerAgreementTypeID,
                        principalTable: "ManagerAgreementTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeJobDatas_OrganizationEntities_OrganizationEntityID",
                        column: x => x.OrganizationEntityID,
                        principalTable: "OrganizationEntities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJobDatas_DutyStationID",
                table: "EmployeeJobDatas",
                column: "DutyStationID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJobDatas_EmployeePossitionID",
                table: "EmployeeJobDatas",
                column: "EmployeePossitionID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJobDatas_ManagerAgreementTypeID",
                table: "EmployeeJobDatas",
                column: "ManagerAgreementTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJobDatas_OrganizationEntityID",
                table: "EmployeeJobDatas",
                column: "OrganizationEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMobileNumbers_NumberTypeID",
                table: "EmployeeMobileNumbers",
                column: "NumberTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePersons_EmployeeMobileNumberID",
                table: "EmployeePersons",
                column: "EmployeeMobileNumberID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePersons_GenderID",
                table: "EmployeePersons",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_FileMapping_FileTypeID",
                table: "FileMapping",
                column: "FileTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_FileMapping_VariableTypeID",
                table: "FileMapping",
                column: "VariableTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ReadFiles_ReadFileStatusID",
                table: "ReadFiles",
                column: "ReadFileStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ReadFiles_UploadFileTypeID",
                table: "ReadFiles",
                column: "UploadFileTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UnplanedExcelDatas_ReadFileID",
                table: "UnplanedExcelDatas",
                column: "ReadFileID");

            migrationBuilder.CreateIndex(
                name: "IX_UploadFiles_UploadFileTypeID",
                table: "UploadFiles",
                column: "UploadFileTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserID",
                table: "UserRoles",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeJobDatas");

            migrationBuilder.DropTable(
                name: "FileMapping");

            migrationBuilder.DropTable(
                name: "UnplanedExcelDatas");

            migrationBuilder.DropTable(
                name: "UploadFiles");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "DutyStations");

            migrationBuilder.DropTable(
                name: "EmployeePersons");

            migrationBuilder.DropTable(
                name: "EmployeePossitions");

            migrationBuilder.DropTable(
                name: "ManagerAgreementTypes");

            migrationBuilder.DropTable(
                name: "OrganizationEntities");

            migrationBuilder.DropTable(
                name: "VariableTypes");

            migrationBuilder.DropTable(
                name: "ReadFiles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "EmployeeMobileNumbers");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "ReadFileStatuses");

            migrationBuilder.DropTable(
                name: "UploadFileType");

            migrationBuilder.DropTable(
                name: "MobileNumberTypes");

            migrationBuilder.InsertData(
                 table: "Roles",
                 columns: new[] { "ID", "RoleName", "Description" },
                 values: new object[] { new[] { "1", "Home", "მთავარი გვერდი" } }
                 );

            migrationBuilder.InsertData(
                table: "UploadFileType",
                columns: new[] { "ID", "Description", "FilesPath" },
                values: new object[]
                {
                    new[]{"1", "სამომხმარებლოს სესხის ანალიზის ფორმა", "/Files/ConsumerLoan" },
                    new[]{"2", "ბიზნეს ანალიზის ფორმა", "/Files/Busines" },
                    new[]{"3", "აგრო რეზიუმეს ფორმა", "/Files/Agro" }
                }
                );
        }
    }
}
