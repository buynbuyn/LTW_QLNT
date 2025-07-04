﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace QLNT.models
{
    [PrimaryKey("EmployeeID")]
    internal class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public required string EmployeeName { get; set; } = null!;

        [Required]
        [StringLength(20)]
        [Column(TypeName = "nvarchar(20)")]
        public required string Gender { get; set; } = null!;

        [Required]
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public required string Position { get; set; } = null!; // Chức vụ

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; } // Lương

        [Required]
        public DateTime HireDate { get; set; } // Ngày làm việc 

        [Required]
        [StringLength(15)]
        [Column(TypeName = "nvarchar(50)")]
        public required string PhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public required string EmailEmployee { get; set; } = null!;
        public bool Status { get; set; } = true;

        // Quan hệ với bảng Orders (Nhân viên có thể xử lý nhiều đơn hàng)
    }
}
