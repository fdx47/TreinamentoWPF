using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreinamentoWPF.Migrations
{
    /// <inheritdoc />
    public partial class init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_CustomFields_CustomFieldsId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Margins_MarginId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_PurchaseClassifications_PurchaseClassificationId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Suppliers_SupplierId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomFields_CustomFieldsApi2_CustomFieldApi2Id",
                table: "CustomFields");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomFields_CustomFieldsApi_CustomFieldApiId",
                table: "CustomFields");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Suppliers",
                type: "varchar(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Suppliers",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Label",
                table: "PurchaseClassifications",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "PurchaseClassifications",
                type: "int",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<decimal>(
                name: "PurchaseUnitPriceVatExclude",
                table: "Margins",
                type: "decimal(20,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MarkupPercent",
                table: "Margins",
                type: "decimal(20,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MarginPercent",
                table: "Margins",
                type: "decimal(20,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Coefficient",
                table: "Margins",
                type: "decimal(20,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Margins",
                type: "decimal(20,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "CustomFieldsApi2",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Label",
                table: "CustomFieldsApi2",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "CustomFieldsApi",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Label",
                table: "CustomFieldsApi",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CustomFieldApiId",
                table: "CustomFields",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomFieldApi2Id",
                table: "CustomFields",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "Articles",
                type: "double(20,4)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double(20,4)");

            migrationBuilder.AlterColumn<int>(
                name: "Vat",
                table: "Articles",
                type: "int",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Articles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseClassificationId",
                table: "Articles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PictureLink",
                table: "Articles",
                type: "varchar(180)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(180)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "MarginId",
                table: "Articles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomFieldsId",
                table: "Articles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_CustomFields_CustomFieldsId",
                table: "Articles",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Margins_MarginId",
                table: "Articles",
                column: "MarginId",
                principalTable: "Margins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_PurchaseClassifications_PurchaseClassificationId",
                table: "Articles",
                column: "PurchaseClassificationId",
                principalTable: "PurchaseClassifications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Suppliers_SupplierId",
                table: "Articles",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFields_CustomFieldsApi2_CustomFieldApi2Id",
                table: "CustomFields",
                column: "CustomFieldApi2Id",
                principalTable: "CustomFieldsApi2",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFields_CustomFieldsApi_CustomFieldApiId",
                table: "CustomFields",
                column: "CustomFieldApiId",
                principalTable: "CustomFieldsApi",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_CustomFields_CustomFieldsId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Margins_MarginId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_PurchaseClassifications_PurchaseClassificationId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Suppliers_SupplierId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomFields_CustomFieldsApi2_CustomFieldApi2Id",
                table: "CustomFields");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomFields_CustomFieldsApi_CustomFieldApiId",
                table: "CustomFields");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Suppliers",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Code",
                keyValue: null,
                column: "Code",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Suppliers",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PurchaseClassifications",
                keyColumn: "Label",
                keyValue: null,
                column: "Label",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Label",
                table: "PurchaseClassifications",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "PurchaseClassifications",
                type: "int",
                maxLength: 11,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PurchaseUnitPriceVatExclude",
                table: "Margins",
                type: "decimal(20,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MarkupPercent",
                table: "Margins",
                type: "decimal(20,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MarginPercent",
                table: "Margins",
                type: "decimal(20,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Coefficient",
                table: "Margins",
                type: "decimal(20,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Margins",
                type: "decimal(20,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(20,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CustomFieldsApi2",
                keyColumn: "Value",
                keyValue: null,
                column: "Value",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "CustomFieldsApi2",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "CustomFieldsApi2",
                keyColumn: "Label",
                keyValue: null,
                column: "Label",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Label",
                table: "CustomFieldsApi2",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "CustomFieldsApi",
                keyColumn: "Value",
                keyValue: null,
                column: "Value",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "CustomFieldsApi",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "CustomFieldsApi",
                keyColumn: "Label",
                keyValue: null,
                column: "Label",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Label",
                table: "CustomFieldsApi",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CustomFieldApiId",
                table: "CustomFields",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomFieldApi2Id",
                table: "CustomFields",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "Articles",
                type: "double(20,4)",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double(20,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Vat",
                table: "Articles",
                type: "int",
                maxLength: 11,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseClassificationId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "PictureLink",
                keyValue: null,
                column: "PictureLink",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "PictureLink",
                table: "Articles",
                type: "varchar(180)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(180)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "MarginId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomFieldsId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_CustomFields_CustomFieldsId",
                table: "Articles",
                column: "CustomFieldsId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Margins_MarginId",
                table: "Articles",
                column: "MarginId",
                principalTable: "Margins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_PurchaseClassifications_PurchaseClassificationId",
                table: "Articles",
                column: "PurchaseClassificationId",
                principalTable: "PurchaseClassifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Suppliers_SupplierId",
                table: "Articles",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFields_CustomFieldsApi2_CustomFieldApi2Id",
                table: "CustomFields",
                column: "CustomFieldApi2Id",
                principalTable: "CustomFieldsApi2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFields_CustomFieldsApi_CustomFieldApiId",
                table: "CustomFields",
                column: "CustomFieldApiId",
                principalTable: "CustomFieldsApi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
