namespace TakeCareOfPlants_DTO
{
    public class ViTri_DTO
    {
        public ViTri_DTO() {}

        public ViTri_DTO(string id, string tenViTri) => (Id, TenViTri) = (id, tenViTri);

        public ViTri_DTO(string id, string tenViTri, int soCayToiDa) 
            => (Id, TenViTri, SoCayToiDa) = (id, tenViTri, soCayToiDa);

        public ViTri_DTO(string id, string tenViTri, int soCayToiDa, int soCayCoSan) 
            => (Id, TenViTri, SoCayToiDa, SoCayCoSan) = (id, tenViTri, soCayToiDa, soCayCoSan);

        public string TenViTri { get; set; }
        public string Id { get; set; }
        public int SoCayToiDa { get; set; }
        public int SoCayCoSan { get; set; }
    }
}
