using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class ThoiGian_SQL
    {
        private readonly DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;


        public void InsertDataThoiGian(string idLich,
                                       string thoiGian,
                                       List<string> cayCanhs,
                                       List<Tuple<string, int>> vatTus,
                                       string ghiChu)
        {
            string lastId = null;
            try {
                databaseConnection.OpenConnect();

                command = new MySqlCommand {
                    Connection = databaseConnection.Connection,
                    CommandText = "SELECT ID, ThoiGian "
                                 + "FROM thoigian "
                                 + "WHERE ThoiGian LIKE '" + thoiGian + "';"
                };

                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        lastId = reader.GetString(column: "ID");
                    }
                } else {
                    reader.Close();
                    command.Dispose();

                    command = new MySqlCommand {
                        Connection = databaseConnection.Connection,
                        CommandText = "INSERT INTO thoigian(ThoiGian) VALUE ('" + thoiGian + "')"
                    };
                    command.ExecuteNonQuery();
                    lastId = command.LastInsertedId.ToString();
                    command.Dispose();
                }
                reader.Close();
                command.Dispose();

                foreach (string IdCayCanh in cayCanhs) {
                    command = new MySqlCommand {
                        Connection = databaseConnection.Connection,
                        CommandText = "INSERT INTO lich_thoigian_caycanh(IDLich, IDCayCanh, IDThoiGian) "
                                      + "VALUE (@idl, @idcc, @idtg)"
                    };
                    command.Parameters.AddWithValue("@idl", value: idLich);
                    command.Parameters.AddWithValue("@idcc", value: IdCayCanh);
                    command.Parameters.AddWithValue("@idtg", value: lastId);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }

                foreach (Tuple<string, int> VatTu in vatTus) {
                    command = new MySqlCommand {
                        Connection = databaseConnection.Connection,
                        CommandText = "INSERT INTO lich_thoigian_vattu(IDLich, IDThoiGian, IDVatTu, SoLuong, GhiChu) "
                                      + "VALUE (@idl, @idtg, @idvt, @sl, @gc)"
                    };
                    command.Parameters.AddWithValue("@idl", value: idLich);
                    command.Parameters.AddWithValue("@idtg", value: lastId);
                    command.Parameters.AddWithValue("@idvt", value: VatTu.Item1);
                    command.Parameters.AddWithValue("@sl", value: VatTu.Item2);
                    command.Parameters.AddWithValue("@gc", value: ghiChu);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }

                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
        }
    }
}
