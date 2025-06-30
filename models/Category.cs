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
    [PrimaryKey("CategoryID")]
    internal class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; } // Mã loại tự tăng

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; } = null!; // Tên loại bắt buộc

        [Required]
        public int Order { get; set; } = 0; // Thứ tự mặc định là 0

        [Required]
        public bool Status { get; set; } = true; // Trạng thái mặc định là `true`

        // Quan hệ với bảng Product (Một loại có nhiều sản phẩm)
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }

}
