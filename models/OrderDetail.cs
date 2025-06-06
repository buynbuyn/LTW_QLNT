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
    [PrimaryKey("OrderID","ProductID")]
    internal class OrderDetail
    {
       
        [ForeignKey("Order")]
        public int OrderID { get; set; } // Khóa ngoại từ bảng Order

        
        [ForeignKey("Product")]
        public int ProductID { get; set; } // Khóa ngoại từ bảng Product

        [Required]
        public int QuantityOrder { get; set; } = 1; // Số lượng sản phẩm trong đơn hàng

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal UnitPrice { get; set; } // Giá sản phẩm khi đặt hàng

        [Required]
        [StringLength(50)]
        public string PaymentMethod { get; set; } = "Cash"; // Phương thức thanh toán

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;


    }

}
