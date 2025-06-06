using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QLNT.models;
using System.Configuration;

namespace QLNT.Data
{
    public class EFDbContext : DbContext
    {
        // Khai báo các bảng
        internal DbSet<User> Users { get; set; }
        internal DbSet<Employee> Employees { get; set; }
        internal DbSet<Customer> Customers { get; set; }
        internal DbSet<Category> Categories { get; set; }
        internal DbSet<Cart> Carts { get; set; }
        internal DbSet<CartDetail> CartDetails { get; set; }
        internal DbSet<Order> Orders { get; set; }
        internal DbSet<OrderDetail> OrderDetails { get; set; }
        internal DbSet<Product> Products { get; set; }
        internal DbSet<ProductDetail> ProductDetails { get; set; }
        internal DbSet<Manufacturer> Manufacturers { get; set; }

        // Cấu hình chuỗi nối kết với SQL Server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        // Thiết lập quan hệ giữa các bảng

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Khóa hợp cho OrderDetail (OrderID, ProductID)
            modelBuilder.Entity<OrderDetail>().HasKey(od => new { od.OrderID, od.ProductID });
            modelBuilder.Entity<CartDetail>().HasKey(cd => new { cd.CartID, cd.ProductID });

            // Một User có một Cart
            modelBuilder.Entity<User>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<Cart>(c => c.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            // Một User có nhiều Orders
            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            // Một Manufacturer có nhiều Products
            modelBuilder.Entity<Manufacturer>()
                .HasMany(m => m.Products)
                .WithOne(p => p.Manufacturer)
                .HasForeignKey(p => p.ManufactureID)
                .OnDelete(DeleteBehavior.Cascade);

            // Một Product có nhiều ProductDetails
            modelBuilder.Entity<Product>()
                .HasMany(p => p.ProductDetails)
                .WithOne(pd => pd.Product)
                .HasForeignKey(pd => pd.ProductID)
                .OnDelete(DeleteBehavior.Cascade);

            // Một Order có nhiều OrderDetails
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderDetails)
                .WithOne(od => od.Order)
                .HasForeignKey(od => od.OrderID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>().HasData(
                new User { UserID = 1, UserName = "admin1", FullName = "Lê Phạm Bảo Uyên", Email = "uyenle@gmail.com", Password = "admin1", Role = 2, Status = true },
                new User { UserID = 2, UserName = "admin2", FullName = "Phạm Hữu Kiên", Email = "kienpham@gmail.com", Password = "admin2", Role = 2, Status = true },
                new User { UserID = 3, UserName = "admin3", FullName = "Nguyễn Hoàng Huynh", Email = "huynhnguyen@gmail.com", Password = "admin3", Role = 2, Status = true },
                new User { UserID = 4, UserName = "employee1", FullName = "Trần Diệp Anh Kiệt", Email = "kiettran@gmail.com", Password = "employee1", Role = 1, Status = true },
                new User { UserID = 5, UserName = "employee2", FullName = "Phùng Minh Vũ", Email = "vuphung@gmail.com", Password = "employee2", Role = 1, Status = true }
            );
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerID = 1, CustomerName = "Nguyễn Văn Trỗi", Gender = "Nam", Address = "267 Đường Nguyễn Huệ, Quận 1, TP.HCM", PhoneNumber = "0901234567", Email = "troinguyen@gmail.com" },
                new Customer { CustomerID = 2, CustomerName = "Trần Thị Tuyết Mai", Gender = "Nữ", Address = "41 Phạm Văn Hai, Tân Bình, TP.HCM", PhoneNumber = "0937654321", Email = "maitran@gmail.com" },
                new Customer { CustomerID = 3, CustomerName = "Lê Tấn Lộc", Gender = "Nam", Address = "68 Nơ Trang Long, Quận Bình Thạnh, TP.HCM", PhoneNumber = "0912345678", Email = "locle@gmail.com" },
                new Customer { CustomerID = 4, CustomerName = "Phạm Thanh Bình", Gender = "Nữ", Address = "620 Huỳnh Tấn Phát, Quận 7, TP.HCM", PhoneNumber = "0978123456", Email = "binhpham@gmail.com" },
                new Customer { CustomerID = 5, CustomerName = "Đặng Quang Huy", Gender = "Nam", Address = "186 Lê Văn Sỹ, Quận Tân Bình, TP.HCM", PhoneNumber = "0945678912", Email = "huydang@gmail.com" },
                new Customer { CustomerID = 6, CustomerName = "Bùi Phương Linh", Gender = "Nữ", Address = "40 Đường Tân Vĩnh, Quận 4, TP.HCM", PhoneNumber = "0998765432", Email = "linhbui@gmail.com" },
                new Customer { CustomerID = 7, CustomerName = "Hoàng Gia Bảo", Gender = "Nam", Address = "147 Đường Nguyễn Kiệm, Quận Phú Nhuận, TP.HCM", PhoneNumber = "0954321789", Email = "hoangbao@gmail.com" },
                new Customer { CustomerID = 8, CustomerName = "Vũ Minh Anh", Gender = "Nữ", Address = "258 Lê Đình Cẩn, Quận Bình Tân, TP.HCM", PhoneNumber = "0912348765", Email = "vuanh@gmail.com" },
                new Customer { CustomerID = 9, CustomerName = "Trịnh Minh Khoa", Gender = "Nam", Address = "369 Đường Trần Não, Quận 2, TP.HCM", PhoneNumber = "0987651234", Email = "trinhkhoa@gmail.com" },
                new Customer { CustomerID = 10, CustomerName = "Mai Tuyết Nhi", Gender = "Nữ", Address = "741 Đường Mạc Thiên Tích, Quận 5, TP.HCM", PhoneNumber = "0965432871", Email = "mainhi@gmail.com" }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeID = 1, EmployeeName = "Trần Diệp Anh Kiệt", Position = "Quản lý", Gender = "Nam", Salary = 20000000, HireDate = new DateTime(2024, 05, 12), PhoneNumber = "0901234567", EmailEmployee = "kiettran@gmail.com" },
                new Employee { EmployeeID = 2, EmployeeName = "Phùng Minh Vũ", Position = "Giám sát ca", Gender = "Nam", Salary = 18000000, HireDate = new DateTime(2024, 07, 20), PhoneNumber = "0937654321", EmailEmployee = "vuphung@gmail.com" },
                new Employee { EmployeeID = 3, EmployeeName = "Lê Nhật Minh", Position = "Nhân viên", Gender = "Nam", Salary = 15000000, HireDate = new DateTime(2024, 08, 15), PhoneNumber = "0912345678", EmailEmployee = "leminh@gmail.com" },
                new Employee { EmployeeID = 4, EmployeeName = "Phạm Mai Chi", Position = "Nhân viên", Gender = "Nữ", Salary = 15000000, HireDate = new DateTime(2024, 11, 10), PhoneNumber = "0978123456", EmailEmployee = "phamchi@gmail.com" },
                new Employee { EmployeeID = 5, EmployeeName = "Đặng Nhật Quang", Position = "Nhân viên", Gender = "Nam", Salary = 15000000, HireDate = new DateTime(2025, 01, 25), PhoneNumber = "0945678912", EmailEmployee = "dangnam@gmail.com" },
                new Employee { EmployeeID = 6, EmployeeName = "Bùi Thị Thùy Trang", Position = "Nhân viên", Gender = "Nữ", Salary = 15000000, HireDate = new DateTime(2025, 03, 18), PhoneNumber = "0998765432", EmailEmployee = "buitrang@gmail.com" }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Thuốc điều trị", Order = 1, Status = true },
                new Category { CategoryID = 2, Name = "Vitamin & Thực phẩm chức năng", Order = 2, Status = true },
                new Category { CategoryID = 3, Name = "Thiết bị y tế", Order = 3, Status = true },
                new Category { CategoryID = 4, Name = "Vật dụng cá nhân", Order = 4, Status = true },
                new Category { CategoryID = 5, Name = "Chăm sóc da & mỹ phẩm", Order = 5, Status = true }
            );
            modelBuilder.Entity<Product>().HasData(
                // CategoryID 1 - Thuốc điều trị (5 sản phẩm)
                new Product { ProductID = 1, CategoryID = 1, ProductName = "Paracetamol", Dosage = "500mg", Unit = "Hộp", Price = 150000, ManufactureID = 1, ProductImage = "paracetamol.jpg" },
                new Product { ProductID = 2, CategoryID = 1, ProductName = "Amoxicillin", Dosage = "500mg", Unit = "Hộp", Price = 120000, ManufactureID = 2, ProductImage = "amoxicillin.jpg" },
                new Product { ProductID = 3, CategoryID = 1, ProductName = "Ibuprofen", Dosage = "400mg", Unit = "Hộp", Price = 130000, ManufactureID = 3, ProductImage = "ibuprofen.jpg" },
                new Product { ProductID = 4, CategoryID = 1, ProductName = "Metformin", Dosage = "850mg", Unit = "Hộp", Price = 180000, ManufactureID = 4, ProductImage = "metformin.jpg" },
                new Product { ProductID = 5, CategoryID = 1, ProductName = "Ciprofloxacin", Dosage = "500mg", Unit = "Hộp", Price = 200000, ManufactureID = 5, ProductImage = "ciprofloxacin.jpg" },

                // CategoryID 2 - Vitamin & Thực phẩm chức năng (5 sản phẩm)
                new Product { ProductID = 6, CategoryID = 2, ProductName = "Vitamin C", Dosage = "250mg", Unit = "Chai", Price = 75000, ManufactureID = 6, ProductImage = "vitaminC.jpg" },
                new Product { ProductID = 7, CategoryID = 2, ProductName = "Omega-3 Dầu Cá", Dosage = "1000mg", Unit = "Lọ", Price = 200000, ManufactureID = 7, ProductImage = "omega3.jpg" },
                new Product { ProductID = 8, CategoryID = 2, ProductName = "Collagen Peptide", Dosage = "5000mg", Unit = "Hộp", Price = 250000, ManufactureID = 8, ProductImage = "collagen.jpg" },
                new Product { ProductID = 9, CategoryID = 2, ProductName = "Kẽm Gluconate", Dosage = "50mg", Unit = "Hộp", Price = 90000, ManufactureID = 9, ProductImage = "zinc.jpg" },
                new Product { ProductID = 10, CategoryID = 2, ProductName = "Magie B6", Dosage = "100mg", Unit = "Hộp", Price = 110000, ManufactureID = 10, ProductImage = "magieB6.jpg" },

                // CategoryID 3 - Thiết bị y tế (5 sản phẩm)
                new Product { ProductID = 11, CategoryID = 3, ProductName = "Máy đo huyết áp", Dosage = "Model XYZ", Unit = "Chiếc", Price = 500000, ManufactureID = 1, ProductImage = "maydo.jpg" },
                new Product { ProductID = 12, CategoryID = 3, ProductName = "Nhiệt kế điện tử", Dosage = "Model ABC", Unit = "Chiếc", Price = 120000, ManufactureID = 2, ProductImage = "nhietke.jpg" },
                new Product { ProductID = 13, CategoryID = 3, ProductName = "Máy đo đường huyết", Dosage = "Model DEF", Unit = "Chiếc", Price = 550000, ManufactureID = 3, ProductImage = "duonghuyet.jpg" },
                new Product { ProductID = 14, CategoryID = 3, ProductName = "Ống nghe y tế", Dosage = "Model KLM", Unit = "Chiếc", Price = 200000, ManufactureID = 4, ProductImage = "ongnghe.jpg" },
                new Product { ProductID = 15, CategoryID = 3, ProductName = "Băng gạc y tế", Dosage = "50 miếng", Unit = "Hộp", Price = 80000, ManufactureID = 5, ProductImage = "banggac.jpg" },

                // CategoryID 4 - Vật dụng cá nhân (5 sản phẩm)
                new Product { ProductID = 16, CategoryID = 4, ProductName = "Gel rửa tay kháng khuẩn", Dosage = "250ml", Unit = "Chai", Price = 65000, ManufactureID = 6, ProductImage = "gelruatay.jpg" },
                new Product { ProductID = 17, CategoryID = 4, ProductName = "Dầu gió xanh", Dosage = "30ml", Unit = "Chai", Price = 50000, ManufactureID = 7, ProductImage = "daugioxanh.jpg" },
                new Product { ProductID = 18, CategoryID = 4, ProductName = "Khẩu trang y tế", Dosage = "50 cái", Unit = "Hộp", Price = 100000, ManufactureID = 8, ProductImage = "khautrang.jpg" },
                new Product { ProductID = 19, CategoryID = 4, ProductName = "Bông tẩy trang", Dosage = "100 miếng", Unit = "Hộp", Price = 40000, ManufactureID = 9, ProductImage = "bongtaytrang.jpg" },
                new Product { ProductID = 20, CategoryID = 4, ProductName = "Nước súc miệng sát khuẩn", Dosage = "500ml", Unit = "Chai", Price = 90000, ManufactureID = 10, ProductImage = "nuocsucmieng.jpg" },

                // CategoryID 5 - Chăm sóc da & mỹ phẩm (5 sản phẩm)
                new Product { ProductID = 21, CategoryID = 5, ProductName = "Kem chống nắng SPF50+", Dosage = "50g", Unit = "Tuýp", Price = 180000, ManufactureID = 1, ProductImage = "kemchongnang.jpg" },
                new Product { ProductID = 22, CategoryID = 5, ProductName = "Sữa rửa mặt dịu nhẹ", Dosage = "150ml", Unit = "Chai", Price = 200000, ManufactureID = 2, ProductImage = "suaruamat.jpg" },
                new Product { ProductID = 23, CategoryID = 5, ProductName = "Mặt nạ dưỡng da", Dosage = "5 miếng", Unit = "Hộp", Price = 120000, ManufactureID = 3, ProductImage = "matna.jpg" },
                new Product { ProductID = 24, CategoryID = 5, ProductName = "Tinh chất dưỡng trắng", Dosage = "30ml", Unit = "Chai", Price = 350000, ManufactureID = 4, ProductImage = "tinhchatduongtrang.jpg" },
                new Product { ProductID = 25, CategoryID = 5, ProductName = "Serum chống lão hóa", Dosage = "50ml", Unit = "Chai", Price = 400000, ManufactureID = 5, ProductImage = "serum.jpg" }
            );
            modelBuilder.Entity<ProductDetail>().HasData(
                // CategoryID 1 - Thuốc điều trị (5 sản phẩm)
                new ProductDetail { ProductDetailID = 1, ProductID = 1, StockQuantity = 100, ExpirationDate = new DateTime(2026, 05, 20), Description = "Thuốc giảm đau, hạ sốt Paracetamol 500mg." },
                new ProductDetail { ProductDetailID = 2, ProductID = 2, StockQuantity = 80, ExpirationDate = new DateTime(2027, 08, 15), Description = "Kháng sinh Amoxicillin 500mg, dùng để điều trị nhiễm khuẩn." },
                new ProductDetail { ProductDetailID = 3, ProductID = 3, StockQuantity = 120, ExpirationDate = new DateTime(2025, 11, 30), Description = "Thuốc chống viêm, giảm đau Ibuprofen 400mg." },
                new ProductDetail { ProductDetailID = 4, ProductID = 4, StockQuantity = 90, ExpirationDate = new DateTime(2026, 02, 10), Description = "Thuốc trị tiểu đường Metformin 850mg." },
                new ProductDetail { ProductDetailID = 5, ProductID = 5, StockQuantity = 60, ExpirationDate = new DateTime(2027, 06, 25), Description = "Kháng sinh Ciprofloxacin 500mg điều trị nhiễm trùng đường tiết niệu." },

                // CategoryID 2 - Vitamin & Thực phẩm chức năng (5 sản phẩm)
                new ProductDetail { ProductDetailID = 6, ProductID = 6, StockQuantity = 150, ExpirationDate = new DateTime(2026, 04, 18), Description = "Viên uống Vitamin C giúp tăng cường hệ miễn dịch." },
                new ProductDetail { ProductDetailID = 7, ProductID = 7, StockQuantity = 70, ExpirationDate = new DateTime(2028, 01, 12), Description = "Viên uống dầu cá Omega-3 giúp hỗ trợ tim mạch." },
                new ProductDetail { ProductDetailID = 8, ProductID = 8, StockQuantity = 50, ExpirationDate = new DateTime(2026, 07, 30), Description = "Collagen Peptide giúp làm đẹp da và tăng độ đàn hồi." },
                new ProductDetail { ProductDetailID = 9, ProductID = 9, StockQuantity = 90, ExpirationDate = new DateTime(2027, 03, 20), Description = "Viên uống kẽm giúp tăng cường sức đề kháng và hỗ trợ da." },
                new ProductDetail { ProductDetailID = 10, ProductID = 10, StockQuantity = 100, ExpirationDate = new DateTime(2025, 12, 10), Description = "Magie B6 giúp hỗ trợ thần kinh và giảm căng thẳng." },

                // CategoryID 3 - Thiết bị y tế (5 sản phẩm)
                new ProductDetail { ProductDetailID = 11, ProductID = 11, StockQuantity = 50, ExpirationDate = new DateTime(2028, 10, 10), Description = "Máy đo huyết áp điện tử Model XYZ, tiện lợi và chính xác cao." },
                new ProductDetail { ProductDetailID = 12, ProductID = 12, StockQuantity = 100, ExpirationDate = new DateTime(2027, 09, 05), Description = "Nhiệt kế điện tử Model ABC, đo nhanh và chuẩn xác." },
                new ProductDetail { ProductDetailID = 13, ProductID = 13, StockQuantity = 40, ExpirationDate = new DateTime(2029, 03, 22), Description = "Máy đo đường huyết Model DEF dành cho người bị tiểu đường." },
                new ProductDetail { ProductDetailID = 14, ProductID = 14, StockQuantity = 75, ExpirationDate = new DateTime(2026, 12, 15), Description = "Ống nghe y tế Model KLM, giúp bác sĩ chuẩn đoán bệnh chính xác." },
                new ProductDetail { ProductDetailID = 15, ProductID = 15, StockQuantity = 200, ExpirationDate = new DateTime(2025, 07, 08), Description = "Băng gạc y tế 50 miếng, cần thiết trong sơ cứu và y tế." },

                // CategoryID 4 - Vật dụng cá nhân (5 sản phẩm)
                new ProductDetail { ProductDetailID = 16, ProductID = 16, StockQuantity = 300, ExpirationDate = new DateTime(2025, 11, 20), Description = "Gel rửa tay kháng khuẩn 250ml, giúp diệt khuẩn hiệu quả." },
                new ProductDetail { ProductDetailID = 17, ProductID = 17, StockQuantity = 150, ExpirationDate = new DateTime(2027, 06, 12), Description = "Dầu gió xanh 30ml, giảm đau và thư giãn cơ bắp." },
                new ProductDetail { ProductDetailID = 18, ProductID = 18, StockQuantity = 500, ExpirationDate = new DateTime(2026, 02, 08), Description = "Khẩu trang y tế 50 cái, bảo vệ sức khỏe mỗi ngày." },
                new ProductDetail { ProductDetailID = 19, ProductID = 19, StockQuantity = 250, ExpirationDate = new DateTime(2027, 04, 18), Description = "Bông tẩy trang 100 miếng, mềm mịn và an toàn cho da." },
                new ProductDetail { ProductDetailID = 20, ProductID = 20, StockQuantity = 100, ExpirationDate = new DateTime(2026, 10, 25), Description = "Nước súc miệng sát khuẩn 500ml, giúp bảo vệ răng miệng." },

                // CategoryID 5 - Chăm sóc da & mỹ phẩm (5 sản phẩm)
                new ProductDetail { ProductDetailID = 21, ProductID = 21, StockQuantity = 80, ExpirationDate = new DateTime(2027, 08, 10), Description = "Kem chống nắng SPF50+, bảo vệ da khỏi tia UV." },
                new ProductDetail { ProductDetailID = 22, ProductID = 22, StockQuantity = 120, ExpirationDate = new DateTime(2026, 09, 15), Description = "Sữa rửa mặt dịu nhẹ 150ml, giúp làm sạch sâu." },
                new ProductDetail { ProductDetailID = 23, ProductID = 23, StockQuantity = 200, ExpirationDate = new DateTime(2025, 12, 01), Description = "Mặt nạ dưỡng da 5 miếng, cấp ẩm và làm sáng da." },
                new ProductDetail { ProductDetailID = 24, ProductID = 24, StockQuantity = 60, ExpirationDate = new DateTime(2026, 05, 28), Description = "Tinh chất dưỡng trắng 30ml, giúp làm đều màu da." },
                new ProductDetail { ProductDetailID = 25, ProductID = 25, StockQuantity = 90, ExpirationDate = new DateTime(2028, 03, 05), Description = "Serum chống lão hóa 50ml, giúp giảm nếp nhăn và trẻ hóa da." }
            );
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer { ManufacturerID = 1, ManufacturerName = "Công ty Dược phẩm Việt Nam", Address = "123 Đường ABC, Quận 1, TP.HCM", PhoneNumber = "0901234567", Email = "contact@duocphamvn.com" },
                new Manufacturer { ManufacturerID = 2, ManufacturerName = "Nhà thuốc Đông Y Truyền Thống", Address = "456 Đường XYZ, Quận 3, TP.HCM", PhoneNumber = "0937654321", Email = "info@dongyvn.com" },
                new Manufacturer { ManufacturerID = 3, ManufacturerName = "Công ty Dược phẩm Quốc Tế", Address = "789 Đường MNO, Quận Bình Thạnh, TP.HCM", PhoneNumber = "0912345678", Email = "support@duocphaminternational.com" },
                new Manufacturer { ManufacturerID = 4, ManufacturerName = "Công ty Mỹ phẩm Thiên Nhiên", Address = "321 Đường PQR, Quận 7, TP.HCM", PhoneNumber = "0978123456", Email = "info@myphamthiennhien.com" },
                new Manufacturer { ManufacturerID = 5, ManufacturerName = "Nhà máy Sản xuất Thiết bị Y Tế", Address = "654 Đường STU, Quận Tân Bình, TP.HCM", PhoneNumber = "0945678912", Email = "contact@thietbiyte.com" },
                new Manufacturer { ManufacturerID = 6, ManufacturerName = "Công ty Sản xuất Vitamin & TPCN", Address = "987 Đường UVW, Quận 5, TP.HCM", PhoneNumber = "0987654321", Email = "support@vitaminTPCN.com" },
                new Manufacturer { ManufacturerID = 7, ManufacturerName = "Công ty TNHH Dược phẩm Đông Dương", Address = "741 Đường XYZ, Quận 10, TP.HCM", PhoneNumber = "0976543210", Email = "info@duocphamdongduong.com" },
                new Manufacturer { ManufacturerID = 8, ManufacturerName = "Tập đoàn Dược phẩm Quốc Gia", Address = "852 Đường RST, Quận Gò Vấp, TP.HCM", PhoneNumber = "0965432189", Email = "contact@duocphamquocgia.com" },
                new Manufacturer { ManufacturerID = 9, ManufacturerName = "Nhà máy Sản xuất Mỹ phẩm Cao Cấp", Address = "963 Đường LMN, Quận 2, TP.HCM", PhoneNumber = "0954321897", Email = "info@myphamcaocap.com" },
                new Manufacturer { ManufacturerID = 10, ManufacturerName = "Công ty TNHH Dược phẩm An Khang", Address = "159 Đường OPQ, Quận 9, TP.HCM", PhoneNumber = "0943216789", Email = "support@duocphamankhang.com" }
            );
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderID = 1, CustomerID = 1, UserID = 2, OrderDate = new DateTime(2025, 06, 01, 14, 30, 00), Amount = 500000, Status = "Đã thanh toán" },
                new Order { OrderID = 2, CustomerID = 3, UserID = 1, OrderDate = new DateTime(2025, 06, 02, 10, 15, 00), Amount = 750000, Status = "Chờ xử lý" },
                new Order { OrderID = 3, CustomerID = 2, UserID = 2, OrderDate = new DateTime(2025, 06, 03, 18, 45, 00), Amount = 300000, Status = "Đang giao" },
                new Order { OrderID = 4, CustomerID = 4, UserID = 3, OrderDate = new DateTime(2025, 06, 04, 12, 10, 00), Amount = 900000, Status = "Đã hủy" },
                new Order { OrderID = 5, CustomerID = 5, UserID = 1, OrderDate = new DateTime(2025, 06, 05, 09, 05, 00), Amount = 450000, Status = "Hoàn tất" }
            );
            modelBuilder.Entity<OrderDetail>().HasData(
                // OrderID 1 - Đã thanh toán
                new OrderDetail { OrderID = 1, ProductID = 1, QuantityOrder = 2, PaymentMethod = "Cash", UnitPrice = 150000},
                new OrderDetail { OrderID = 1, ProductID = 5, QuantityOrder = 1, PaymentMethod = "Cash", UnitPrice = 200000},

                // OrderID 2 - Chờ xử lý
                new OrderDetail { OrderID = 2, ProductID = 3, QuantityOrder = 3, PaymentMethod = "Credit Card", UnitPrice = 130000},
                new OrderDetail { OrderID = 2, ProductID = 7, QuantityOrder = 2, PaymentMethod = "Credit Card", UnitPrice = 200000},

                // OrderID 3 - Đang giao
                new OrderDetail { OrderID = 3, ProductID = 2, QuantityOrder = 1, PaymentMethod = "Bank Transfer", UnitPrice = 120000},
                new OrderDetail { OrderID = 3, ProductID = 9, QuantityOrder = 5, PaymentMethod = "Bank Transfer", UnitPrice = 90000},

                // OrderID 4 - Đã hủy
                new OrderDetail { OrderID = 4, ProductID = 4, QuantityOrder = 2, PaymentMethod = "Cash", UnitPrice = 180000},
                new OrderDetail { OrderID = 4, ProductID = 8, QuantityOrder = 1, PaymentMethod = "Cash", UnitPrice = 250000},

                // OrderID 5 - Hoàn tất
                new OrderDetail { OrderID = 5, ProductID = 6, QuantityOrder = 4, PaymentMethod = "Credit Card", UnitPrice = 75000},
                new OrderDetail { OrderID = 5, ProductID = 10, QuantityOrder = 3, PaymentMethod = "Credit Card", UnitPrice = 110000}
            );



        }
        public void UpdateCartTotal(int cartId)
        {
            var cart = Carts.Include(c => c.CartDetails).FirstOrDefault(c => c.CartID == cartId);
            if (cart != null) 
            {
                cart.TotalCartPrice = cart.CartDetails.Sum(cd => cd.Quantity * cd.UnitPrice);
                SaveChanges(); // Cập nhật vào DB
                //Them dòng này dbContext.UpdateCartTotal(1); nếu có thay đổi trong giỏ hàng
            }
        }


    }
}