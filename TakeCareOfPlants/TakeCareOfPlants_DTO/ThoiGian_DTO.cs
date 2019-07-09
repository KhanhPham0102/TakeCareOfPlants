using System;

namespace TakeCareOfPlants_DTO
{
    public class ThoiGian_DTO
    {
        public ThoiGian_DTO() { }

        public ThoiGian_DTO(TimeSpan thoiGian, string ghiChu)
            => (ThoiGian, GhiChu) = (thoiGian, ghiChu);

        public ThoiGian_DTO(string id, TimeSpan thoiGian, string ghiChu)
            => (Id, ThoiGian, GhiChu) = (id, thoiGian, ghiChu);

        public string Id { get; set; }
        public TimeSpan ThoiGian { get; set; }
        public string GhiChu { get; set; }
    }
}
