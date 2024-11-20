using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoCycleAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Email = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    CPF = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Username = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false),
                    Score = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    UserId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.CPF);
                    table.ForeignKey(
                        name: "FK_Profiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Street = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    AdditionalInfo = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: true),
                    Number = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    City = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    State = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    ZipCode = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    ProfileCPF = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_Profiles_ProfileCPF",
                        column: x => x.ProfileCPF,
                        principalTable: "Profiles",
                        principalColumn: "CPF",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telephones",
                columns: table => new
                {
                    TelephoneId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DDD = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: false),
                    Number = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: false),
                    ProfileCPF = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephones", x => x.TelephoneId);
                    table.ForeignKey(
                        name: "FK_Telephones_Profiles_ProfileCPF",
                        column: x => x.ProfileCPF,
                        principalTable: "Profiles",
                        principalColumn: "CPF",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usages",
                columns: table => new
                {
                    UsageId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    PickupDatetime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ReturnDatetime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Duration = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    Score = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ProfileCPF = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usages", x => x.UsageId);
                    table.ForeignKey(
                        name: "FK_Usages_Profiles_ProfileCPF",
                        column: x => x.ProfileCPF,
                        principalTable: "Profiles",
                        principalColumn: "CPF",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Amount = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    Type = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: false),
                    UsageId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Usages_UsageId",
                        column: x => x.UsageId,
                        principalTable: "Usages",
                        principalColumn: "UsageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ProfileCPF",
                table: "Addresses",
                column: "ProfileCPF");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UsageId",
                table: "Payments",
                column: "UsageId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId",
                table: "Profiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Telephones_ProfileCPF",
                table: "Telephones",
                column: "ProfileCPF");

            migrationBuilder.CreateIndex(
                name: "IX_Usages_ProfileCPF",
                table: "Usages",
                column: "ProfileCPF");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Telephones");

            migrationBuilder.DropTable(
                name: "Usages");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
