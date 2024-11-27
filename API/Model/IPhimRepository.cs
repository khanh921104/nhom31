using API.Data;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Model
{
    public interface IPhimRepository
    {
        Task<IEnumerable<tbPhim>> GetPhimDangChieu();
        Task<tbPhim> GetThongTinPhim(string maPhim);
        Task<IEnumerable<tbPhim>> GetPhimChuaChieu(string maPhim); 

    }
}
