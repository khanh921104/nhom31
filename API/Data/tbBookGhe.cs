using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class tbBookGhe
    {
        [Key, Column(Order = 0)]  // Đánh dấu maGhe là một phần của khóa chính
        [StringLength(20)]
        public string MaGhe { get; set; }

        [Key, Column(Order = 1)]  // Đánh dấu maBook là một phần của khóa chính
        [StringLength(20)]
        public string MaBook { get; set; }

        // Khóa ngoại - Mối quan hệ với Ghe
        [ForeignKey("MaGhe")]
        public virtual tbGhe Ghe { get; set; }

        // Khóa ngoại - Mối quan hệ với BookVe
        [ForeignKey("MaBook")]
        public virtual tbBookVe BookVe { get; set; }
    }
}
