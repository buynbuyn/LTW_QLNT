using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.models
{
    [PrimaryKey("CartID")]
    internal class Cart
    {
        [Key] // Giữ khóa chính nh2ưng không tự động tăng
        public int CartID { get; set; } // Khóa chính, giờ bạn sẽ tự gán giá trị

        [Required]
        [ForeignKey("Customer")]
        public int? CustomerID { get; set; } // Khóa ngoại từ bảng Customer

        [Required]
        [ForeignKey("User")]
        public int? UserID { get; set; } // Khóa ngoại từ bảng User (Nhân viên hỗ trợ)

        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalCartPrice { get; set; } = 0; // Tổng giá trị giỏ hàng

        public virtual Customer? Customer { get; set; }
        public virtual User? User { get; set; }

        public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();
    }
}