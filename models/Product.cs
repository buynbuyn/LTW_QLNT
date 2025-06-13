using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QLNT.models
{
    [PrimaryKey("ProductID")]
    internal class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; } // Khóa chính
        [Required]
        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string ProductName { get; set; } = null!; // Tên sản phẩm

        [Required]
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Dosage { get; set; } = null!; // Hàm lượng

        [Required]
        [StringLength(20)]
        [Column(TypeName = "nvarchar(20)")]
        public string Unit { get; set; } = null!; // Đơn vị tính

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; } = 0; // Giá sản phẩm

        [Required]
        [ForeignKey("Manufacturer")]
        public int ManufactureID { get; set; } // Khóa ngoại liên kết với bảng Manufacturer

        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string? ProductImage { get; set; } // Tên file ảnh, có thể null

        public virtual Category Category { get; set; } = null!;

        // Liên kết với bảng Manufacturer
        public virtual Manufacturer Manufacturer { get; set; } = null!;

        // Một sản phẩm có nhiều chi tiết sản phẩm
        public virtual ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();
    }
}
