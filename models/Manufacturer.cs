using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.models
{
  [PrimaryKey("ManufacturerID")]

    internal class Manufacturer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ManufacturerID { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public required string ManufacturerName { get; set; } = null!;

        [Required]
        [StringLength(255)]
        [Column(TypeName = "nvarchar(255)")]
        public required string Address { get; set; } = null!;

        [Required]
        [StringLength(15)]
        public required string PhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public required string Email { get; set; } = null!;

        // Quan hệ với bảng Product (Một nhà sản xuất có nhiều sản phẩm)
        public virtual ICollection<Product>? Products { get; set; }
    }
}
