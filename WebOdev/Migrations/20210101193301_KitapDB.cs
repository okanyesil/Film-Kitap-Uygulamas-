using Microsoft.EntityFrameworkCore.Migrations;

namespace WebOdev.Migrations
{
    public partial class KitapDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    kategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kategoriAdi = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.kategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Yazar",
                columns: table => new
                {
                    yazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yazarAdi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    yazarSoyadi = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazar", x => x.yazarID);
                });

            migrationBuilder.CreateTable(
                name: "Yorum",
                columns: table => new
                {
                    yorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yorum = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => x.yorumID);
                });

            migrationBuilder.CreateTable(
                name: "Kitap",
                columns: table => new
                {
                    kitapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kitapAdi = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    yazarID = table.Column<int>(type: "int", nullable: true),
                    kategoryID = table.Column<int>(type: "int", nullable: true),
                    yorumID = table.Column<int>(type: "int", nullable: true),
                    resimUrl = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    puan = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitap", x => x.kitapID);
                    table.ForeignKey(
                        name: "FK_Kitap_Kategori",
                        column: x => x.kategoryID,
                        principalTable: "Kategori",
                        principalColumn: "kategoriID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kitap_Yazar",
                        column: x => x.yazarID,
                        principalTable: "Yazar",
                        principalColumn: "yazarID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kitap_Yorum",
                        column: x => x.yorumID,
                        principalTable: "Yorum",
                        principalColumn: "yorumID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_kategoryID",
                table: "Kitap",
                column: "kategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_yazarID",
                table: "Kitap",
                column: "yazarID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_yorumID",
                table: "Kitap",
                column: "yorumID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitap");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Yazar");

            migrationBuilder.DropTable(
                name: "Yorum");
        }
    }
}
