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
        public static int UserRole { get; set; } = 0;

        public static int UserID { get; private set; }
        public static string ImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image");

        // Kiểm tra xem tập tin ảnh có tồn tại không
        public static bool ImageExists(string imageName)
        {
            string fullPath = Path.Combine(ImagePath, imageName);
            return File.Exists(fullPath);
        }

        // Lấy đường dẫn đầy đủ của ảnh nếu có, nếu không trả về null
        public static string GetImagePath(string imageName)
        {
            string fullPath = Path.Combine(ImagePath, imageName);
            return File.Exists(fullPath) ? fullPath : null;
        }


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