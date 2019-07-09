using System;

namespace TakeCareOfPlants_DTO
{
    public class Lich_DTO
    {
        public Lich_DTO()
        {
        }

        public Lich_DTO(DateTime ngayLapLich)
        {
            (NgayLapLich) = (ngayLapLich);
        }

        public Lich_DTO(string id, DateTime ngayLapLich)
        {
            (Id, NgayLapLich) = (id, ngayLapLich);
        }

        public string Id { get; set; }
        public DateTime NgayLapLich { get; set; }
    }
}
