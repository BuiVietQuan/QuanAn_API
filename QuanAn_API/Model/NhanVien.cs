using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanAn_API.Model
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public string Gender { get; set; }

    }
}
