using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class SignUp_SQL
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;

        public bool InsertDataSignUp(Login_DTO login_DTO)
        {
            command = new MySqlCommand {
                CommandText = "SELECT * FROM login WHERE TaiKhoan ='" + login_DTO.TaiKhoan + "'",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (!reader.HasRows) {
                    reader.Close();
                    command.Dispose();
                    command = new MySqlCommand {
                        CommandText = "INSERT INTO login(TaiKhoan, MatKhau_Hash, MatKhau_Salt) VALUE (@tk, @h, @s)",
                        Connection = databaseConnection.Connection
                    };
                    command.Parameters.AddWithValue("@tk", login_DTO.TaiKhoan);
                    command.Parameters.AddWithValue("@h", login_DTO.Hash);
                    command.Parameters.AddWithValue("@s", login_DTO.Salt);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    databaseConnection.CloseConnect();
                    return true;
                }
                reader.Close();
                command.Dispose();
                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
            return false;
        }
    }
}
