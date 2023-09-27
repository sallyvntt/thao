using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Group3.Migrations
{
    /// <inheritdoc />
    public partial class s123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BrandMst",
                columns: table => new
                {
                    Brand_ID = table.Column<string>(type: "nchar(10)", nullable: false),
                    Brand_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandMst", x => x.Brand_ID);
                });

            migrationBuilder.CreateTable(
                name: "CatMst",
                columns: table => new
                {
                    Cat_ID = table.Column<string>(type: "nchar(10)", nullable: false),
                    Cat_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatMst", x => x.Cat_ID);
                });

            migrationBuilder.CreateTable(
                name: "CertifyMst",
                columns: table => new
                {
                    Certify_ID = table.Column<string>(type: "nchar(10)", nullable: false),
                    Certify_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertifyMst", x => x.Certify_ID);
                });

            migrationBuilder.CreateTable(
                name: "DimInfoMst",
                columns: table => new
                {
                    DimID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimSubType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimCrt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimPrice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DimImg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimInfoMst", x => x.DimID);
                });

            migrationBuilder.CreateTable(
                name: "DimQltyMst",
                columns: table => new
                {
                    DimQlty_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimQlty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimQltyMst", x => x.DimQlty_ID);
                });

            migrationBuilder.CreateTable(
                name: "DimQltySubMst",
                columns: table => new
                {
                    DimSubType_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DimQlty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimQltySubMst", x => x.DimSubType_ID);
                });

            migrationBuilder.CreateTable(
                name: "GoldKrtMst",
                columns: table => new
                {
                    GoldType_ID = table.Column<string>(type: "nchar(10)", nullable: false),
                    Gold_Crt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldKrtMst", x => x.GoldType_ID);
                });

            migrationBuilder.CreateTable(
                name: "JewelTypeMst",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Jewellery_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JewelTypeMst", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProdMst",
                columns: table => new
                {
                    Prod_ID = table.Column<string>(type: "nchar(10)", nullable: false),
                    Prod_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdMst", x => x.Prod_ID);
                });

            migrationBuilder.CreateTable(
                name: "StoneQltyMst",
                columns: table => new
                {
                    StoneQlty_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StoneQlty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneQltyMst", x => x.StoneQlty_ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cat_ID = table.Column<string>(type: "nchar(10)", nullable: false),
                    Type_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand_ID = table.Column<string>(type: "nchar(10)", nullable: false),
                    Size_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_BrandMst_Brand_ID",
                        column: x => x.Brand_ID,
                        principalTable: "BrandMst",
                        principalColumn: "Brand_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_CatMst_Cat_ID",
                        column: x => x.Cat_ID,
                        principalTable: "CatMst",
                        principalColumn: "Cat_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemMst",
                columns: table => new
                {
                    Style_Code = table.Column<string>(type: "varchar(50)", nullable: false),
                    Pairs = table.Column<decimal>(type: "numeric(3,0)", nullable: false),
                    Brand_ID = table.Column<string>(type: "nchar(10)", nullable: false),
                    Quantity = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Cat_ID = table.Column<string>(type: "nchar(10)", nullable: false),
                    Prod_Quality = table.Column<string>(type: "varchar(50)", nullable: false),
                    Certify_ID = table.Column<string>(type: "nchar(10)", nullable: false),
                    Prod_ID = table.Column<string>(type: "nchar(10)", nullable: false),
                    GoldType_ID = table.Column<string>(type: "nchar(10)", nullable: false),
                    Gold_Wt = table.Column<decimal>(type: "numeric(10,3)", nullable: false),
                    Stone_Wt = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Net_Gold = table.Column<decimal>(type: "numeric(10,3)", nullable: false),
                    Wstg_Per = table.Column<decimal>(type: "numeric(10,3)", nullable: false),
                    Wstg = table.Column<decimal>(type: "numeric(10,3)", nullable: false),
                    Tot_Gross_Wt = table.Column<decimal>(type: "numeric(10,3)", nullable: false),
                    Gold_Rate = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Gold_Amt = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Gold_Making = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Stone_Making = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Other_Making = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Tot_Making = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    MRP = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMst", x => x.Style_Code);
                    table.ForeignKey(
                        name: "FK_ItemMst_BrandMst_Brand_ID",
                        column: x => x.Brand_ID,
                        principalTable: "BrandMst",
                        principalColumn: "Brand_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemMst_CatMst_Cat_ID",
                        column: x => x.Cat_ID,
                        principalTable: "CatMst",
                        principalColumn: "Cat_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemMst_CertifyMst_Certify_ID",
                        column: x => x.Certify_ID,
                        principalTable: "CertifyMst",
                        principalColumn: "Certify_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemMst_GoldKrtMst_GoldType_ID",
                        column: x => x.GoldType_ID,
                        principalTable: "GoldKrtMst",
                        principalColumn: "GoldType_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemMst_ProdMst_Prod_ID",
                        column: x => x.Prod_ID,
                        principalTable: "ProdMst",
                        principalColumn: "Prod_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DimMst",
                columns: table => new
                {
                    DimMst_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Style_Code = table.Column<string>(type: "varchar(50)", nullable: false),
                    DimQlty_ID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    DimSubType_ID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Dim_Crt = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Dim_Pcs = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Dim_Gm = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Dim_Size = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Dim_Rate = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Dim_Amt = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimMst", x => x.DimMst_ID);
                    table.ForeignKey(
                        name: "FK_DimMst_DimQltyMst_DimQlty_ID",
                        column: x => x.DimQlty_ID,
                        principalTable: "DimQltyMst",
                        principalColumn: "DimQlty_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DimMst_DimQltySubMst_DimSubType_ID",
                        column: x => x.DimSubType_ID,
                        principalTable: "DimQltySubMst",
                        principalColumn: "DimSubType_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DimMst_ItemMst_Style_Code",
                        column: x => x.Style_Code,
                        principalTable: "ItemMst",
                        principalColumn: "Style_Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoneMst",
                columns: table => new
                {
                    StoneMst_ID = table.Column<int>(type: "int", nullable: false),
                    Style_Code = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    StoneQlty_ID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Stone_Gm = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Stone_Pcs = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Stone_Crt = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Stone_Rate = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Stone_Amt = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneMst", x => x.StoneMst_ID);
                    table.ForeignKey(
                        name: "FK_StoneMst_ItemMst_Style_Code",
                        column: x => x.Style_Code,
                        principalTable: "ItemMst",
                        principalColumn: "Style_Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoneMst_StoneQltyMst_StoneQlty_ID",
                        column: x => x.StoneQlty_ID,
                        principalTable: "StoneQltyMst",
                        principalColumn: "StoneQlty_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Email", "Password", "PhoneNumber", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "", "superadmin@gmail.com", "123", "", true, "admin" },
                    { 2, "", "supertest@gmail.com", "123", "", false, "test" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DimMst_DimQlty_ID",
                table: "DimMst",
                column: "DimQlty_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DimMst_DimSubType_ID",
                table: "DimMst",
                column: "DimSubType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DimMst_Style_Code",
                table: "DimMst",
                column: "Style_Code");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMst_Brand_ID",
                table: "ItemMst",
                column: "Brand_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMst_Cat_ID",
                table: "ItemMst",
                column: "Cat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMst_Certify_ID",
                table: "ItemMst",
                column: "Certify_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMst_GoldType_ID",
                table: "ItemMst",
                column: "GoldType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMst_Prod_ID",
                table: "ItemMst",
                column: "Prod_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Brand_ID",
                table: "Product",
                column: "Brand_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Cat_ID",
                table: "Product",
                column: "Cat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StoneMst_StoneQlty_ID",
                table: "StoneMst",
                column: "StoneQlty_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StoneMst_Style_Code",
                table: "StoneMst",
                column: "Style_Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "DimInfoMst");

            migrationBuilder.DropTable(
                name: "DimMst");

            migrationBuilder.DropTable(
                name: "JewelTypeMst");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "StoneMst");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "DimQltyMst");

            migrationBuilder.DropTable(
                name: "DimQltySubMst");

            migrationBuilder.DropTable(
                name: "ItemMst");

            migrationBuilder.DropTable(
                name: "StoneQltyMst");

            migrationBuilder.DropTable(
                name: "BrandMst");

            migrationBuilder.DropTable(
                name: "CatMst");

            migrationBuilder.DropTable(
                name: "CertifyMst");

            migrationBuilder.DropTable(
                name: "GoldKrtMst");

            migrationBuilder.DropTable(
                name: "ProdMst");
        }
    }
}
