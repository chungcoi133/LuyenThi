using System.ComponentModel.DataAnnotations;

namespace LuyenThi.Models
{
    public class DonHang
    {
        [Key]
        public string MaDonHang { get; set; }
        public string TenDonHang { get; set; }
        public DateTime NgayDatHang { get; set; }
        public KhachHang? KhachHangs { get; set;}
    }
}
