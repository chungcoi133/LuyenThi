namespace LuyenThi.Models
{
    public class KhachHang
    {
        public Guid Id { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string DiaChi { get; set; }
        public IList<DonHang> DonHangs { get; set;}
    }
}
