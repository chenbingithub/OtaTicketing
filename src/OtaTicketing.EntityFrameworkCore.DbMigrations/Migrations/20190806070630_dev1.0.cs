using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OtaTicketing.Migrations
{
    public partial class dev10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppAgencyType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    AgencyTypeName = table.Column<string>(maxLength: 50, nullable: false),
                    DefaultAgencyType = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<int>(nullable: false),
                    OutTicketType = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAgencyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppPark",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ParkCode = table.Column<short>(nullable: false),
                    ParkName = table.Column<string>(maxLength: 40, nullable: false),
                    AccountName = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 20, nullable: true),
                    Fax = table.Column<string>(maxLength: 20, nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(maxLength: 20, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    SerialNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPark", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAgency",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    AccountId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    AgencyTypeId = table.Column<int>(nullable: false),
                    MainAgencyUserId = table.Column<long>(nullable: true),
                    ParentAgencyId = table.Column<int>(nullable: true),
                    AgencyName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(maxLength: 20, nullable: true),
                    Tel = table.Column<string>(maxLength: 20, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAgency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppAgency_AppAgencyType_AgencyTypeId",
                        column: x => x.AgencyTypeId,
                        principalTable: "AppAgencyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppAgency_AppAgency_ParentAgencyId",
                        column: x => x.ParentAgencyId,
                        principalTable: "AppAgency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppAgency_AgencyTypeId",
                table: "AppAgency",
                column: "AgencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppAgency_ParentAgencyId",
                table: "AppAgency",
                column: "ParentAgencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppAgency");

            migrationBuilder.DropTable(
                name: "AppPark");

            migrationBuilder.DropTable(
                name: "AppAgencyType");
        }
    }
}
