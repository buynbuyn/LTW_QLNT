using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNT.models
{
    [PrimaryKey("CartID", "ProductID")]
    internal class CartDetail
    {
       
        [ForeignKey("CartID")]
        public int CartID { get; set; } // Khóa ngoại từ bảng Cart

       
        [ForeignKey("ProductID")]
        public int ProductID { get; set; } // Khóa ngoại từ bảng Product

        [Required]
        public int Quantity { get; set; } = 1; // Số lượng sản phẩm trong giỏ hàng

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal UnitPrice { get; set; } // Giá sản phẩm tại thời điểm thêm vào giỏ

        [NotMapped] // Không lưu vào DB, chỉ tính khi cần

        public virtual Cart Cart { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
 }