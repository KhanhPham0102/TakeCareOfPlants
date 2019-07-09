using System;
using System.Security.Cryptography;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public class Login_BUS
    {
        private Login_SQL loginSQL = new Login_SQL();

        public bool LogInSuccess(string userName, string password)
        {
            Login_DTO loginDTO = loginSQL.GetDataLogin(userName);
            return Function_BUS.GenerateHash(password, loginDTO.Salt) == loginDTO.Hash;
        }
    }
}
