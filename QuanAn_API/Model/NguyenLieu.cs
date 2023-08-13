using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanAn_API.Model
{
    [Table("NguyenLieu")]
    public class NguyenLieu
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public double HamLuong { get; set; }

    }
}
