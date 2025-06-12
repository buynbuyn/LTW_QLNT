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
    [PrimaryKey("UserID")]
    internal class User
    {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int UserID { get; set; } // Khóa chính tự tăng

            [Required]
            [StringLength(50)]
            [Column(TypeName = "nvarchar(50)")]
            public string UserName { get; set; } = null!; // Tên đăng nhập

            [Required]
            [StringLength(100)]
            [Column(TypeName = "nvarchar(100)")]
            public string FullName { get; set; } = null!; // Họ tên đầy đủ

            [Required]
            [StringLength(100)]
            [Column(TypeName = "nvarchar(100)")]
            public string Email { get; set; } = null!; // Địa chỉ email

            [Required]
            [StringLength(255)]
            [Column(TypeName = "nvarchar(255)")]
            public string Password { get; set; } = null!; // Mật khẩu mã hóa

            [Required]
            [StringLength(20)]
            [Column(TypeName = "nvarchar(20)")]
            public int Role { get; set; }// Vai trò (Admin, User, Manager, ...)

            [Required]
            public bool Status { get; set; } = true; // Trạng thái mặc định là `true`

            public virtual Cart? Cart { get; set; }

        // Quan hệ với bảng khác (Nếu cần)
        public virtual ICollection<Order>? Orders { get; set; } = new List<Order>();
        }
}
