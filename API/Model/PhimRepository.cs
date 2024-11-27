using API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    public class PhimRepository : IPhimRepository
    {
        private readonly ApplicationDbContext _context; // Khai báo DbContext để truy cập cơ sở dữ liệu

        // Constructor nhận vào ApplicationDbContext thông qua Dependency Injection
        public PhimRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Phương thức lấy danh sách phim đang chiếu
        public async Task<IEnumerable<tbPhim>> GetPhimDangChieu()
        {
            return await _context.Phims
                .Where(p => p.TinhTrang == true) // Điều kiện lọc phim đang chiếu
                .ToListAsync(); // Thực hiện truy vấn và trả về danh sách phim
        }

        // Phương thức lấy thông tin chi tiết một phim theo mã phim
        public async Task<tbPhim> GetThongTinPhim(string maPhim)
        {
            return await _context.Phims
                .FirstOrDefaultAsync(p => p.MaPhim == maPhim); // Trả về phim đầu tiên (hoặc null nếu không tìm thấy)
        }

        // Phương thức lấy phim chưa chiếu theo mã phim
        public async Task<tbPhim> GetPhimChuaChieu(string maPhim)
        {
            return await _context.Phims
                .FirstOrDefaultAsync(p => p.MaPhim == maPhim && (p.TinhTrang == null || p.TinhTrang == false) && p.NgayKhoiChieu > DateTime.Now); // Điều kiện lọc phim chưa chiếu
        }

        Task<IEnumerable<tbPhim>> IPhimRepository.GetPhimChuaChieu(string maPhim)
        {
            throw new NotImplementedException();
        }
    }
}
