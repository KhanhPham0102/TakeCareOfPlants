namespace TakeCareOfPlants_DTO
{
    public class Login_DTO
    {
        public Login_DTO() {}

        public Login_DTO(string taiKhoan, string hash, string salt) 
            => (TaiKhoan, Hash, Salt) = (taiKhoan, hash, salt);

        public Login_DTO(string id, string taiKhoan, string hash, string salt) 
            => (Id, TaiKhoan, Hash, Salt) = (id, taiKhoan, hash, salt);

        public string Id { get; set; }
        public string TaiKhoan { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
    }
}
