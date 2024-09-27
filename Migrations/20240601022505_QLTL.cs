using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLTL.Migrations
{
    /// <inheritdoc />
    public partial class QLTL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHUCVU",
                columns: table => new
                {
                    MACV = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LUONG = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHUCVU", x => x.MACV);
                });

            migrationBuilder.CreateTable(
                name: "PHONGBAN",
                columns: table => new
                {
                    MAPB = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHONGBAN", x => x.MAPB);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    MANV = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MAPB = table.Column<long>(type: "bigint", nullable: false),
                    MACV = table.Column<long>(type: "bigint", nullable: false),
                    THUMBNAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BIRTHDAY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GENDER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NGAYVAOLAM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PHONE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHANVIEN", x => x.MANV);
                    table.ForeignKey(
                        name: "FK_NHANVIEN_CHUCVU_MACV",
                        column: x => x.MACV,
                        principalTable: "CHUCVU",
                        principalColumn: "MACV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NHANVIEN_PHONGBAN_MAPB",
                        column: x => x.MAPB,
                        principalTable: "PHONGBAN",
                        principalColumn: "MAPB",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CHAMCONG",
                columns: table => new
                {
                    MACC = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MANV = table.Column<long>(type: "bigint", nullable: false),
                    NGAYCONG = table.Column<int>(type: "int", nullable: false),
                    NGHIHL = table.Column<int>(type: "int", nullable: false),
                    THANG = table.Column<int>(type: "int", nullable: false),
                    NAM = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAMCONG", x => x.MACC);
                    table.ForeignKey(
                        name: "FK_CHAMCONG_NHANVIEN_MANV",
                        column: x => x.MANV,
                        principalTable: "NHANVIEN",
                        principalColumn: "MANV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KHENTHUONGKYLUAT",
                columns: table => new
                {
                    MAKHENTHUONGKILUAT = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MANV = table.Column<long>(type: "bigint", nullable: false),
                    THUONGPHAT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LYDO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NGAYAPDUNG = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SOTIEN = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHENTHUONGKYLUAT", x => x.MAKHENTHUONGKILUAT);
                    table.ForeignKey(
                        name: "FK_KHENTHUONGKYLUAT_NHANVIEN_MANV",
                        column: x => x.MANV,
                        principalTable: "NHANVIEN",
                        principalColumn: "MANV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHAMCONG_MANV",
                table: "CHAMCONG",
                column: "MANV");

            migrationBuilder.CreateIndex(
                name: "IX_KHENTHUONGKYLUAT_MANV",
                table: "KHENTHUONGKYLUAT",
                column: "MANV");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_MACV",
                table: "NHANVIEN",
                column: "MACV");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_MAPB",
                table: "NHANVIEN",
                column: "MAPB");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHAMCONG");

            migrationBuilder.DropTable(
                name: "KHENTHUONGKYLUAT");

            migrationBuilder.DropTable(
                name: "NHANVIEN");

            migrationBuilder.DropTable(
                name: "CHUCVU");

            migrationBuilder.DropTable(
                name: "PHONGBAN");
        }
    }
}
