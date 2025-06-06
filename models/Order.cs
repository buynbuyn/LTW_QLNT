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
    [PrimaryKey("OrderID")]
    internal class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; } // Khóa chính

        [Required]
        [ForeignKey("Customer")]
        public int CustomerID { get; set; } // Khóa ngoại từ bảng Customer

        [Required]
        [ForeignKey("User")]
        public int UserID { get; set; } // Khóa ngoại từ bảng User (Nhân viên xử lý đơn)

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; } = DateTime.Now; // Ngày đặt hàng

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; } = 0; // Tổng tiền đơn hàng

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Chờ xử lý"; // Trạng thái đơn hàng
        public virtual Customer Customer { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }


}
