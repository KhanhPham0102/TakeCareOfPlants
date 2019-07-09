namespace TakeCareOfPlants_DTO
{
    public class VatTu_DTO
    {
        public VatTu_DTO() {}

        public VatTu_DTO(string tenVatTu) => (TenVatTu) = (tenVatTu);

        public VatTu_DTO(string id, string tenVatTu) => (Id, TenVatTu) = (id, tenVatTu);

        public string Id { get; set; }
        public string TenVatTu { get; set; }
    }
}
