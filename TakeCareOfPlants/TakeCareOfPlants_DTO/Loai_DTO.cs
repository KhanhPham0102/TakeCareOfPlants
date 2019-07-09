namespace TakeCareOfPlants_DTO
{
    public class Loai_DTO
    {
        public Loai_DTO() {}

        public Loai_DTO(string loai) => (Loai) = (loai); 

        public Loai_DTO(string id, string loai) => (Id, Loai) = (id, loai);

        public string Id { get; set; }
        public string Loai { get; set; }
    }
}
