using System;

namespace TakeCareOfPlants_DTO
{
    public class CayCanh_DTO
    {
        public CayCanh_DTO(string s, string i) => (Id, TenCay) = (s, i);

        public CayCanh_DTO(string tenCay, Loai_DTO loai_DTO, TinhTrang_DTO tinhTrang_DTO, DateTime ngayTrong)
            => (TenCay, Loai_DTO, TinhTrang_DTO, NgayTrong) = (tenCay, loai_DTO, tinhTrang_DTO, ngayTrong);

        public CayCanh_DTO(string id, string tenCay, Loai_DTO loai_DTO, TinhTrang_DTO tinhTrang_DTO, DateTime ngayTrong)
            => (Id, TenCay, Loai_DTO, TinhTrang_DTO, NgayTrong) = (id, tenCay, loai_DTO, tinhTrang_DTO, ngayTrong);

        public string Id { get; set; }
        public string TenCay { get; set; }
        public TinhTrang_DTO TinhTrang_DTO { get; set; }
        public Loai_DTO Loai_DTO { get; set; }
        public DateTime NgayTrong { get; set; }
    }
}
