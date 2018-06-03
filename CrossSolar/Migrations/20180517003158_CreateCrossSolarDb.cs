using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CrossSolar.Migrations
{
    public partial class CreateCrossSolarDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                 "OneHourElectricitys",
                 table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy", 
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    DateTime = table.Column<DateTime>(),
                    KiloWatt = table.Column<long>(),
                    PanelId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    //table.PrimaryKey("PK_OneHourElectricitys", x => x.Id);
                    table.ForeignKey("FK_OneHourElectricitys_Panel", 
                        x => x.PanelId, 
                        "Panels", 
                        "Id");
                });
            //no bug
            migrationBuilder.CreateTable(
                "Panels",
                table => new
                {
                    Id = table.Column<int>()
                        .Annotation("SqlServer:ValueGenerationStrategy", 
                            SqlServerValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(),
                    Longitude = table.Column<double>(),
                    Serial = table.Column<string>(maxLength: 255)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panels",
                        x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "OneHourElectricitys");

            migrationBuilder.DropTable(
                "Panels");
        }
    }
}
