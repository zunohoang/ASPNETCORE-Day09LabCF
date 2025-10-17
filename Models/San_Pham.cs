using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Day09LabCF.Models
{
    [Table("San_Pham")]
    public class San_Pham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Display(Name ="M? s?n ph?m")]
        [Required]
        [StringLength(10)]
        public string MaSanPham { get; set; }

        [Display(Name ="Tên s?n ph?m")]
        public string TenSanPham { get; set; }

        [Display(Name="H?nh ?nh")]
        public string HinhAnh { get; set; }

        [Display(Name="S? lý?ng")]
        public int SoLuong { get; set; }

        [Display(Name = "Ðõn giá")]
        public decimal DonGia { get; set; }

        
        public long LoaiSanPhamId { get; set; }

        public Loai_San_Pham Loai_San_Pham { get; set; }

    }
}
