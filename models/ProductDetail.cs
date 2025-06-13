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
    [PrimaryKey("ProductDetailID")]
    internal class ProductDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductDetailID { get; set; } // Khóa chính tự tăng

        [Required]
        [ForeignKey("Product")]
        public int ProductID { get; set; } // Khóa ngoại từ bảng Product

        [Required] 
        public int StockQuantity { get; set; } = 0; // Số lượng tồn kho

        [Required]
        [Column(TypeName = "datetime")] 
        public DateTime ExpirationDate { get; set; } // Ngày hết hạn

        [Required]
        [Column(TypeName = "text")] 
        public string Description { get; set; } = null!; // Mô tả sản phẩm

        // Liên kết với bảng Product
        public virtual Product Product { get; set; } = null!;
    }


}
