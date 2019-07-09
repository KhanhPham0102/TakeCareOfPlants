using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class Login_SQL
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;

        public Login_DTO GetDataLogin(string taiKhoan)
        {
            Login_DTO loginDTO = new Login_DTO();
            command = new MySqlCommand {
                CommandText = "SELECT * FROM login WHERE TaiKhoan = '" + taiKhoan + "'",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        loginDTO = new Login_DTO(reader.GetString("TaiKhoan"), reader.GetString("MatKhau_Hash"), reader.GetString("MatKhau_Salt"));
                    }
                }
                reader.Close();
                command.Dispose();
                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
            return loginDTO;
        }
    }
}
