using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanAn_API.Model
{
    [Table("MonAn")]
    public class MonAn
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Prace { get; set; }

    }
}
