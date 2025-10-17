using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Day09LabCF.Models
{
    [Table("Loai_San_Pham")]
    [Index(nameof(MaLoai), IsUnique = true)]
    public class Loai_San_Pham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Display(Name ="M? lo?i")]
        [StringLength(10)]
        public string MaLoai { get; set; }

        [Display(Name ="Tên lo?i")]
        [StringLength (50)]
        public string TenLoai { get; set; }

        [Display(Name = "Tr?ng thái")]
        public bool TrangThai { get; set; }

        public ICollection<San_Pham> San_Phams { get; set; } = new HashSet<San_Pham>();
    }
}
