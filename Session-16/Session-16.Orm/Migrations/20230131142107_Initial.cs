using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session16.Orm.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CarServiceCenter",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SettingsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarServiceCenter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarServiceCenter_Settings_SettingsID",
                        column: x => x.SettingsID,
                        principalTable: "Settings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CarRegistrationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CarServiceCenterID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Car_CarServiceCenter_CarServiceCenterID",
                        column: x => x.CarServiceCenterID,
                        principalTable: "CarServiceCenter",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    TIN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CarServiceCenterID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customer_CarServiceCenter_CarServiceCenterID",
                        column: x => x.CarServiceCenterID,
                        principalTable: "CarServiceCenter",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalaryPerMonth = table.Column<decimal>(type: "decimal(10,2)", precision: 10, nullable: false),
                    CarServiceCenterID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Manager_CarServiceCenter_CarServiceCenterID",
                        column: x => x.CarServiceCenterID,
                        principalTable: "CarServiceCenter",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MonthlyLedger",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Income = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Expenses = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CarServiceCenterID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyLedger", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonthlyLedger_CarServiceCenter_CarServiceCenterID",
                        column: x => x.CarServiceCenterID,
                        principalTable: "CarServiceCenter",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Service Task",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Hours = table.Column<decimal>(type: "decimal(10,2)", precision: 10, nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    CarServiceCenterID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Task", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Service Task_CarServiceCenter_CarServiceCenterID",
                        column: x => x.CarServiceCenterID,
                        principalTable: "CarServiceCenter",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Engineer",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ManagerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalaryPerMonth = table.Column<decimal>(type: "decimal(10,2)", precision: 10, nullable: false),
                    CarServiceCenterID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engineer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Engineer_CarServiceCenter_CarServiceCenterID",
                        column: x => x.CarServiceCenterID,
                        principalTable: "CarServiceCenter",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Engineer_Manager_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "Manager",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ManagerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,2)", precision: 10, nullable: false),
                    CarServiceCenterID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transactions_CarServiceCenter_CarServiceCenterID",
                        column: x => x.CarServiceCenterID,
                        principalTable: "CarServiceCenter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Car_ID",
                        column: x => x.ID,
                        principalTable: "Car",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Customer_ID",
                        column: x => x.ID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Manager_ID",
                        column: x => x.ID,
                        principalTable: "Manager",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "transactionLine",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceTaskID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EngineerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Hours = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CarServiceCenterID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionsID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactionLine", x => x.ID);
                    table.ForeignKey(
                        name: "FK_transactionLine_CarServiceCenter_CarServiceCenterID",
                        column: x => x.CarServiceCenterID,
                        principalTable: "CarServiceCenter",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_transactionLine_Engineer_EngineerID",
                        column: x => x.EngineerID,
                        principalTable: "Engineer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactionLine_Service Task_ServiceTaskID",
                        column: x => x.ServiceTaskID,
                        principalTable: "Service Task",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactionLine_Transactions_TransactionsID",
                        column: x => x.TransactionsID,
                        principalTable: "Transactions",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarServiceCenterID",
                table: "Car",
                column: "CarServiceCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_CarServiceCenter_SettingsID",
                table: "CarServiceCenter",
                column: "SettingsID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CarServiceCenterID",
                table: "Customer",
                column: "CarServiceCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_Engineer_CarServiceCenterID",
                table: "Engineer",
                column: "CarServiceCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_Engineer_ManagerID",
                table: "Engineer",
                column: "ManagerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Manager_CarServiceCenterID",
                table: "Manager",
                column: "CarServiceCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyLedger_CarServiceCenterID",
                table: "MonthlyLedger",
                column: "CarServiceCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_Service Task_CarServiceCenterID",
                table: "Service Task",
                column: "CarServiceCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_transactionLine_CarServiceCenterID",
                table: "transactionLine",
                column: "CarServiceCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_transactionLine_EngineerID",
                table: "transactionLine",
                column: "EngineerID");

            migrationBuilder.CreateIndex(
                name: "IX_transactionLine_ServiceTaskID",
                table: "transactionLine",
                column: "ServiceTaskID");

            migrationBuilder.CreateIndex(
                name: "IX_transactionLine_TransactionsID",
                table: "transactionLine",
                column: "TransactionsID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CarServiceCenterID",
                table: "Transactions",
                column: "CarServiceCenterID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyLedger");

            migrationBuilder.DropTable(
                name: "transactionLine");

            migrationBuilder.DropTable(
                name: "Engineer");

            migrationBuilder.DropTable(
                name: "Service Task");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "CarServiceCenter");

            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
