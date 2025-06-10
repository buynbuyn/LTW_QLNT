using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLNT.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmailEmployee = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Role = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Dosage = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Unit = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ManufactureID = table.Column<int>(type: "int", nullable: false),
                    ProductImage = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Manufacturers_ManufactureID",
                        column: x => x.ManufactureID,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    TotalCartPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartID);
                    table.ForeignKey(
                        name: "FK_Carts_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ProductDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ProductDetailID);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartDetails",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => new { x.CartID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_CartDetails_Carts_CartID",
                        column: x => x.CartID,
                        principalTable: "Carts",
                        principalColumn: "CartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    QuantityOrder = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name", "Order", "Status" },
                values: new object[,]
                {
                    { 1, "Thuốc điều trị", 1, true },
                    { 2, "Vitamin & Thực phẩm chức năng", 2, true },
                    { 3, "Thiết bị y tế", 3, true },
                    { 4, "Vật dụng cá nhân", 4, true },
                    { 5, "Chăm sóc da & mỹ phẩm", 5, true }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "CustomerName", "Email", "Gender", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "267 Đường Nguyễn Huệ, Quận 1, TP.HCM", "Nguyễn Văn Trỗi", "troinguyen@gmail.com", "Nam", "0901234567" },
                    { 2, "41 Phạm Văn Hai, Tân Bình, TP.HCM", "Trần Thị Tuyết Mai", "maitran@gmail.com", "Nữ", "0937654321" },
                    { 3, "68 Nơ Trang Long, Quận Bình Thạnh, TP.HCM", "Lê Tấn Lộc", "locle@gmail.com", "Nam", "0912345678" },
                    { 4, "620 Huỳnh Tấn Phát, Quận 7, TP.HCM", "Phạm Thanh Bình", "binhpham@gmail.com", "Nữ", "0978123456" },
                    { 5, "186 Lê Văn Sỹ, Quận Tân Bình, TP.HCM", "Đặng Quang Huy", "huydang@gmail.com", "Nam", "0945678912" },
                    { 6, "40 Đường Tân Vĩnh, Quận 4, TP.HCM", "Bùi Phương Linh", "linhbui@gmail.com", "Nữ", "0998765432" },
                    { 7, "147 Đường Nguyễn Kiệm, Quận Phú Nhuận, TP.HCM", "Hoàng Gia Bảo", "hoangbao@gmail.com", "Nam", "0954321789" },
                    { 8, "258 Lê Đình Cẩn, Quận Bình Tân, TP.HCM", "Vũ Minh Anh", "vuanh@gmail.com", "Nữ", "0912348765" },
                    { 9, "369 Đường Trần Não, Quận 2, TP.HCM", "Trịnh Minh Khoa", "trinhkhoa@gmail.com", "Nam", "0987651234" },
                    { 10, "741 Đường Mạc Thiên Tích, Quận 5, TP.HCM", "Mai Tuyết Nhi", "mainhi@gmail.com", "Nữ", "0965432871" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "EmailEmployee", "EmployeeName", "Gender", "HireDate", "PhoneNumber", "Position", "Salary" },
                values: new object[,]
                {
                    { 1, "kiettran@gmail.com", "Trần Diệp Anh Kiệt", "Nam", new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0901234567", "Quản lý", 20000000m },
                    { 2, "vuphung@gmail.com", "Phùng Minh Vũ", "Nam", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0937654321", "Giám sát ca", 18000000m },
                    { 3, "leminh@gmail.com", "Lê Nhật Minh", "Nam", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", "Nhân viên", 15000000m },
                    { 4, "phamchi@gmail.com", "Phạm Mai Chi", "Nữ", new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "0978123456", "Nhân viên", 15000000m },
                    { 5, "dangnam@gmail.com", "Đặng Nhật Quang", "Nam", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0945678912", "Nhân viên", 15000000m },
                    { 6, "buitrang@gmail.com", "Bùi Thị Thùy Trang", "Nữ", new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0998765432", "Nhân viên", 15000000m }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerID", "Address", "Email", "ManufacturerName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "123 Đường ABC, Quận 1, TP.HCM", "contact@duocphamvn.com", "Công ty Dược phẩm Việt Nam", "0901234567" },
                    { 2, "456 Đường XYZ, Quận 3, TP.HCM", "info@dongyvn.com", "Nhà thuốc Đông Y Truyền Thống", "0937654321" },
                    { 3, "789 Đường MNO, Quận Bình Thạnh, TP.HCM", "support@duocphaminternational.com", "Công ty Dược phẩm Quốc Tế", "0912345678" },
                    { 4, "321 Đường PQR, Quận 7, TP.HCM", "info@myphamthiennhien.com", "Công ty Mỹ phẩm Thiên Nhiên", "0978123456" },
                    { 5, "654 Đường STU, Quận Tân Bình, TP.HCM", "contact@thietbiyte.com", "Nhà máy Sản xuất Thiết bị Y Tế", "0945678912" },
                    { 6, "987 Đường UVW, Quận 5, TP.HCM", "support@vitaminTPCN.com", "Công ty Sản xuất Vitamin & TPCN", "0987654321" },
                    { 7, "741 Đường XYZ, Quận 10, TP.HCM", "info@duocphamdongduong.com", "Công ty TNHH Dược phẩm Đông Dương", "0976543210" },
                    { 8, "852 Đường RST, Quận Gò Vấp, TP.HCM", "contact@duocphamquocgia.com", "Tập đoàn Dược phẩm Quốc Gia", "0965432189" },
                    { 9, "963 Đường LMN, Quận 2, TP.HCM", "info@myphamcaocap.com", "Nhà máy Sản xuất Mỹ phẩm Cao Cấp", "0954321897" },
                    { 10, "159 Đường OPQ, Quận 9, TP.HCM", "support@duocphamankhang.com", "Công ty TNHH Dược phẩm An Khang", "0943216789" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "FullName", "Password", "Role", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, "uyenle@gmail.com", "Lê Phạm Bảo Uyên", "admin1", "2", true, "admin1" },
                    { 2, "kienpham@gmail.com", "Phạm Hữu Kiên", "admin2", "2", true, "admin2" },
                    { 3, "huynhnguyen@gmail.com", "Nguyễn Hoàng Huynh", "admin3", "2", true, "admin3" },
                    { 4, "kiettran@gmail.com", "Trần Diệp Anh Kiệt", "employee1", "1", true, "employee1" },
                    { 5, "vuphung@gmail.com", "Phùng Minh Vũ", "employee2", "1", true, "employee2" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Amount", "CustomerID", "OrderDate", "Status", "UserID" },
                values: new object[,]
                {
                    { 1, 500000m, 1, new DateTime(2025, 6, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), "Đã thanh toán", 2 },
                    { 2, 750000m, 3, new DateTime(2025, 6, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), "Chờ xử lý", 1 },
                    { 3, 300000m, 2, new DateTime(2025, 6, 3, 18, 45, 0, 0, DateTimeKind.Unspecified), "Đang giao", 2 },
                    { 4, 900000m, 4, new DateTime(2025, 6, 4, 12, 10, 0, 0, DateTimeKind.Unspecified), "Đã hủy", 3 },
                    { 5, 450000m, 5, new DateTime(2025, 6, 5, 9, 5, 0, 0, DateTimeKind.Unspecified), "Hoàn tất", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Dosage", "ManufactureID", "Price", "ProductImage", "ProductName", "Unit" },
                values: new object[,]
                {
                    { 1, 1, "500mg", 1, 150000m, "paracetamol.jpg", "Paracetamol", "Hộp" },
                    { 2, 1, "500mg", 2, 120000m, "amoxicillin.jpg", "Amoxicillin", "Hộp" },
                    { 3, 1, "400mg", 3, 130000m, "ibuprofen.jpg", "Ibuprofen", "Hộp" },
                    { 4, 1, "850mg", 4, 180000m, "metformin.jpg", "Metformin", "Hộp" },
                    { 5, 1, "500mg", 5, 200000m, "ciprofloxacin.jpg", "Ciprofloxacin", "Hộp" },
                    { 6, 2, "250mg", 6, 75000m, "vitaminC.jpg", "Vitamin C", "Chai" },
                    { 7, 2, "1000mg", 7, 200000m, "omega3.jpg", "Omega-3 Dầu Cá", "Lọ" },
                    { 8, 2, "5000mg", 8, 250000m, "collagen.jpg", "Collagen Peptide", "Hộp" },
                    { 9, 2, "50mg", 9, 90000m, "zinc.jpg", "Kẽm Gluconate", "Hộp" },
                    { 10, 2, "100mg", 10, 110000m, "magieB6.jpg", "Magie B6", "Hộp" },
                    { 11, 3, "Model XYZ", 1, 500000m, "maydo.jpg", "Máy đo huyết áp", "Chiếc" },
                    { 12, 3, "Model ABC", 2, 120000m, "nhietke.jpg", "Nhiệt kế điện tử", "Chiếc" },
                    { 13, 3, "Model DEF", 3, 550000m, "duonghuyet.jpg", "Máy đo đường huyết", "Chiếc" },
                    { 14, 3, "Model KLM", 4, 200000m, "ongnghe.jpg", "Ống nghe y tế", "Chiếc" },
                    { 15, 3, "50 miếng", 5, 80000m, "banggac.jpg", "Băng gạc y tế", "Hộp" },
                    { 16, 4, "250ml", 6, 65000m, "gelruatay.jpg", "Gel rửa tay kháng khuẩn", "Chai" },
                    { 17, 4, "30ml", 7, 50000m, "daugioxanh.jpg", "Dầu gió xanh", "Chai" },
                    { 18, 4, "50 cái", 8, 100000m, "khautrang.jpg", "Khẩu trang y tế", "Hộp" },
                    { 19, 4, "100 miếng", 9, 40000m, "bongtaytrang.jpg", "Bông tẩy trang", "Hộp" },
                    { 20, 4, "500ml", 10, 90000m, "nuocsucmieng.jpg", "Nước súc miệng sát khuẩn", "Chai" },
                    { 21, 5, "50g", 1, 180000m, "kemchongnang.jpg", "Kem chống nắng SPF50+", "Tuýp" },
                    { 22, 5, "150ml", 2, 200000m, "suaruamat.jpg", "Sữa rửa mặt dịu nhẹ", "Chai" },
                    { 23, 5, "5 miếng", 3, 120000m, "matna.jpg", "Mặt nạ dưỡng da", "Hộp" },
                    { 24, 5, "30ml", 4, 350000m, "tinhchatduongtrang.jpg", "Tinh chất dưỡng trắng", "Chai" },
                    { 25, 5, "50ml", 5, 400000m, "serum.jpg", "Serum chống lão hóa", "Chai" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderID", "ProductID", "PaymentMethod", "QuantityOrder", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, "Cash", 2, 150000m },
                    { 1, 5, "Cash", 1, 200000m },
                    { 2, 3, "Credit Card", 3, 130000m },
                    { 2, 7, "Credit Card", 2, 200000m },
                    { 3, 2, "Bank Transfer", 1, 120000m },
                    { 3, 9, "Bank Transfer", 5, 90000m },
                    { 4, 4, "Cash", 2, 180000m },
                    { 4, 8, "Cash", 1, 250000m },
                    { 5, 6, "Credit Card", 4, 75000m },
                    { 5, 10, "Credit Card", 3, 110000m }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailID", "Description", "ExpirationDate", "ProductID", "StockQuantity" },
                values: new object[,]
                {
                    { 1, "Thuốc giảm đau, hạ sốt Paracetamol 500mg.", new DateTime(2026, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100 },
                    { 2, "Kháng sinh Amoxicillin 500mg, dùng để điều trị nhiễm khuẩn.", new DateTime(2027, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 80 },
                    { 3, "Thuốc chống viêm, giảm đau Ibuprofen 400mg.", new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 120 },
                    { 4, "Thuốc trị tiểu đường Metformin 850mg.", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 90 },
                    { 5, "Kháng sinh Ciprofloxacin 500mg điều trị nhiễm trùng đường tiết niệu.", new DateTime(2027, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 60 },
                    { 6, "Viên uống Vitamin C giúp tăng cường hệ miễn dịch.", new DateTime(2026, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 150 },
                    { 7, "Viên uống dầu cá Omega-3 giúp hỗ trợ tim mạch.", new DateTime(2028, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 70 },
                    { 8, "Collagen Peptide giúp làm đẹp da và tăng độ đàn hồi.", new DateTime(2026, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 50 },
                    { 9, "Viên uống kẽm giúp tăng cường sức đề kháng và hỗ trợ da.", new DateTime(2027, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 90 },
                    { 10, "Magie B6 giúp hỗ trợ thần kinh và giảm căng thẳng.", new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 100 },
                    { 11, "Máy đo huyết áp điện tử Model XYZ, tiện lợi và chính xác cao.", new DateTime(2028, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 50 },
                    { 12, "Nhiệt kế điện tử Model ABC, đo nhanh và chuẩn xác.", new DateTime(2027, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 100 },
                    { 13, "Máy đo đường huyết Model DEF dành cho người bị tiểu đường.", new DateTime(2029, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 40 },
                    { 14, "Ống nghe y tế Model KLM, giúp bác sĩ chuẩn đoán bệnh chính xác.", new DateTime(2026, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 75 },
                    { 15, "Băng gạc y tế 50 miếng, cần thiết trong sơ cứu và y tế.", new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 200 },
                    { 16, "Gel rửa tay kháng khuẩn 250ml, giúp diệt khuẩn hiệu quả.", new DateTime(2025, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 300 },
                    { 17, "Dầu gió xanh 30ml, giảm đau và thư giãn cơ bắp.", new DateTime(2027, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 150 },
                    { 18, "Khẩu trang y tế 50 cái, bảo vệ sức khỏe mỗi ngày.", new DateTime(2026, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 500 },
                    { 19, "Bông tẩy trang 100 miếng, mềm mịn và an toàn cho da.", new DateTime(2027, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 250 },
                    { 20, "Nước súc miệng sát khuẩn 500ml, giúp bảo vệ răng miệng.", new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 100 },
                    { 21, "Kem chống nắng SPF50+, bảo vệ da khỏi tia UV.", new DateTime(2027, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 80 },
                    { 22, "Sữa rửa mặt dịu nhẹ 150ml, giúp làm sạch sâu.", new DateTime(2026, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 120 },
                    { 23, "Mặt nạ dưỡng da 5 miếng, cấp ẩm và làm sáng da.", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 200 },
                    { 24, "Tinh chất dưỡng trắng 30ml, giúp làm đều màu da.", new DateTime(2026, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 60 },
                    { 25, "Serum chống lão hóa 50ml, giúp giảm nếp nhăn và trẻ hóa da.", new DateTime(2028, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 90 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_ProductID",
                table: "CartDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomerID",
                table: "Carts",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserID",
                table: "Carts",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductID",
                table: "ProductDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufactureID",
                table: "Products",
                column: "ManufactureID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartDetails");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
