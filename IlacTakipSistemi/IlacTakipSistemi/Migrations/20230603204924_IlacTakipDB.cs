using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IlacTakipSistemi.Migrations
{
    public partial class IlacTakipDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblIlac",
                columns: table => new
                {
                    ilacID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ilacAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gunlukAdet = table.Column<int>(type: "int", nullable: false),
                    ilacTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kullaniciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblIlac", x => x.ilacID);
                });

            migrationBuilder.CreateTable(
                name: "tblIlacTakip",
                columns: table => new
                {
                    ilacTakipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ilacAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblIlacTakip", x => x.ilacTakipID);
                });

            migrationBuilder.CreateTable(
                name: "tblKullanici",
                columns: table => new
                {
                    kullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullaniciGirisKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kullaniciAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kullaniciTcNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kullaniciYas = table.Column<int>(type: "int", nullable: false),
                    kullaniciCinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblKullanici", x => x.kullaniciID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblIlac_ilacID",
                table: "tblIlac",
                column: "ilacID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblIlacTakip_ilacTakipID",
                table: "tblIlacTakip",
                column: "ilacTakipID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblKullanici_kullaniciID",
                table: "tblKullanici",
                column: "kullaniciID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblIlac");

            migrationBuilder.DropTable(
                name: "tblIlacTakip");

            migrationBuilder.DropTable(
                name: "tblKullanici");
        }
    }
}
