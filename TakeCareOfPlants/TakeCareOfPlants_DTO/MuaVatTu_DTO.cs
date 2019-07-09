using System;

namespace TakeCareOfPlants_DTO
{
    public class MuaVatTu_DTO
    {
        public MuaVatTu_DTO() {}

        public MuaVatTu_DTO(string diaChi, DateTime ngayMua, int soLuong, long soTien) 
            => (DiaChi, NgayMua, SoLuong, SoTien) = (diaChi, ngayMua, soLuong, soTien);

        public MuaVatTu_DTO(string id, string diaChi, DateTime ngayMua, int soLuong, long soTien) 
            => (Id, DiaChi, NgayMua, SoLuong, SoTien) = (id, diaChi, ngayMua, soLuong, soTien);

        public string Id { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayMua { get; set; }
        public int SoLuong { get; set; }
        public long SoTien { get; set; }
    }
}
