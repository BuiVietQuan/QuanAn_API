using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanAn_API.Model
{
    [Table("loai")]
    public class Loai
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
