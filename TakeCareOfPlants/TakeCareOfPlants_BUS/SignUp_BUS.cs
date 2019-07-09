using System;
using System.Collections.Generic;
using System.Text;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public class SignUp_BUS
    {
        SignUp_SQL signUpSQL = new SignUp_SQL();

        public bool InsertValueSignUp(string taiKhoan, string matKhau)
        {
            string salt = Function_BUS.CreateSalt(100);
            return signUpSQL.InsertDataSignUp(new Login_DTO(taiKhoan, Function_BUS.GenerateHash(matKhau, salt), salt));
        }
    }
}
