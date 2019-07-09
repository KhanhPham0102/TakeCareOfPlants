namespace TakeCareOfPlants_DTO
{
    public class QuyDinh_DTO
    {
        public QuyDinh_DTO() { }

        public QuyDinh_DTO(int soLoaiVatTu, long soTienToiDa) 
            => (SoLoaiVatTu, SoTienToiDa) = (soLoaiVatTu, soTienToiDa);

        public QuyDinh_DTO(string id, int soLoaiVatTu, long soTienToiDa) 
            => (Id, SoLoaiVatTu, SoTienToiDa) = (id, soLoaiVatTu, soTienToiDa);

        public string Id { get; set; }
        public int SoLoaiVatTu { get; set; }
        public long SoTienToiDa { get; set; }
    }
}
