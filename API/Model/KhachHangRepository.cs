using API.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Model
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private readonly ApplicationDbContext _context; // Khai báo DbContext để truy cập cơ sở dữ liệu

        // Constructor nhận vào ApplicationDbContext thông qua Dependency Injection
        public KhachHangRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<tbKhachHang>> GetDanhSachKhachHang()
        {
            return await _context.KhachHangs.ToListAsync();
        }
    }
}
