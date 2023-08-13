using QuanAn_API.Model;
using Microsoft.EntityFrameworkCore;
namespace QuanAn_API.Data
{
    public class QuanAnDBContext : DbContext
    {
        public QuanAnDBContext(DbContextOptions<QuanAnDBContext>opt) : base(opt)  
        {

        }
        public DbSet<MonAn> monAns { get; set; }  
        public DbSet<Loai> loais { get; set; }  
        public DbSet<NguyenLieu> nguyenLieus { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }

    }
}
