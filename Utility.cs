using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QLNT.Data;

namespace QLNT
{
    internal static class Utility
    {
        // Biến lưu trạng thái đăng nhập
        public static string LoggedInUser { get; private set; }
        public static int UserRole { get; private set; }

        public static int UserID { get; private set; }

        // Hàm kiểm tra đăng nhập & lưu thông tin người dùng
        public static bool CheckLogin(string username, string password)
        {
            try
            {
                using (var context = new EFDbContext()) // Dùng DbContext để truy vấn
                {
                    var user = context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);

                    if (user != null)
                    {
                        SetSession(user.UserName, user.Role, user.UserID); // Lưu thông tin đăng nhập vào `Utility`
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi đăng nhập: {ex.Message}");
            }

            return false;
        }

        // Hàm lưu thông tin đăng nhập vào Session
        public static void SetSession(string username, int role, int userId)
        {
            LoggedInUser = username;
            UserRole = role;
            UserID = userId;
        }

        // Hàm xóa Session khi đăng xuất
        public static void ClearSession()
        {
            LoggedInUser = string.Empty;  // Xóa tên đăng nhập
            UserRole = 0;      // Xóa quyền đăng nhập
                      
        }

    }
}