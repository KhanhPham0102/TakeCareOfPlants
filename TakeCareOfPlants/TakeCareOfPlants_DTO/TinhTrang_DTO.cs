namespace TakeCareOfPlants_DTO
{
    public class TinhTrang_DTO
    {
        public TinhTrang_DTO() {}

        public TinhTrang_DTO(string tinhTrang) => (TinhTrang) = (tinhTrang);

        public TinhTrang_DTO(string id, string tinhTrang) => (Id, TinhTrang) = (id, tinhTrang);

        public string Id { get; set; }
        public string TinhTrang { get; set; }
    }
}
