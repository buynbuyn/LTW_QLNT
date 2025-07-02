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
    [PrimaryKey("CustomerID")] 
    
    internal class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public required string CustomerName { get; set; } = null!;
        [Required]
        [StringLength(20)]
        [Column(TypeName = "nvarchar(50)")]
        public required string Gender { get; set; } = null!;

        [Required]
        [StringLength(255)]
        [Column(TypeName = "nvarchar(100)")]
        public required string Address { get; set; } = null!;

        [Required]
        [StringLength(15)]
        [Column(TypeName = "nvarchar(20)")]
        public required string PhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(50)")]
        public required string Email { get; set; }
        [Required]
        public bool Status { get; set; } = true; // Trạng thái khách hàng, mặc định là true


        // Liên kết với bảng Orders (1-N)
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
