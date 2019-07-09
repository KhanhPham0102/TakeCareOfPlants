using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class Lich_SQL
    {
        private readonly DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;
        private MySqlDataAdapter dataAdapter;

        public string InsertAndGetLastIdDataLich()
        {
            string lastId = null;
            string timeNow = DateTime.Now.Date.ToString("yyyy-MM-dd");

            try {
                databaseConnection.OpenConnect();

                command = new MySqlCommand {
                    Connection = databaseConnection.Connection,
                    CommandText = "SELECT ID, NgayLapLich "
                                  + "FROM lich "
                                  + "WHERE NgayLapLich LIKE '" + timeNow + "';"
                };

                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        lastId = reader.GetString("ID");
                    }
                } else {
                    reader.Close();
                    command.Dispose();

                    command = new MySqlCommand {
                        Connection = databaseConnection.Connection,
                        CommandText = "INSERT INTO lich(NgayLapLich) VALUE ('" + timeNow + "');"
                    };
                    command.ExecuteNonQuery();
                    command.Dispose();

                    command = new MySqlCommand {
                        CommandText = "SELECT MAX(ID) FROM lich",
                        Connection = databaseConnection.Connection
                    };
                    reader = command.ExecuteReader();

                    if (reader.HasRows) {
                        while (reader.Read()) {
                            lastId = reader.GetString("MAX(ID)");
                        }
                    }

                    reader.Close();
                    command.Dispose();
                }
                reader.Close();
                command.Dispose();

                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
            return lastId;
        }

        public List<Lich_DTO> GetDataLich()
        {
            List<Lich_DTO> lich_DTOs = new List<Lich_DTO>();

            try {
                databaseConnection.OpenConnect();

                command = new MySqlCommand {
                    Connection = databaseConnection.Connection,
                    CommandText = "SELECT * FROM lich;"
                };

                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        lich_DTOs.Add(new Lich_DTO(id: reader.GetString("ID"),
                                                   ngayLapLich: reader.GetDateTime("NgayLapLich")));
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

            return lich_DTOs;
        }

        public DataTable GetAllDataLich(string idCayCanh, string idLich)
        {
            DataSet data = new DataSet();
            dataAdapter = new MySqlDataAdapter(
                "SELECT "
                + "ROW_NUMBER() OVER () AS 'STT', "
                + "tg.ThoiGian AS 'Thời_Gian', "
                + "vt.VatTu AS 'Vật_Tư', "
                + "dv.DonVi AS 'Đơn_Vị_Tính', "
                + "l_tg_vt.SoLuong AS 'Số_Lượng', "
                + "l_tg_vt.GhiChu AS 'Ghi_Chú' "
                + "FROM thoigian AS tg "
                + "INNER JOIN lich_thoigian_caycanh AS l_tg_cc "
                + "ON l_tg_cc.IDThoiGian = tg.ID "
                + "INNER JOIN lich_thoigian_vattu AS l_tg_vt "
                + "ON l_tg_vt.IDThoiGian = tg.ID "
                + "INNER JOIN vattu AS vt "
                + "ON l_tg_vt.IDVatTu = vt.ID "
                + "INNER JOIN donvi AS dv "
                + "ON vt.IDDonVi = dv.ID "
                + "WHERE l_tg_cc.IDLich = '"+ idLich + "' && l_tg_vt.IDLich = '" + idLich + "' && l_tg_cc.IDCayCanh = '" + idCayCanh + "';",
                databaseConnection.Connection);

            try {
                databaseConnection.OpenConnect();

                dataAdapter.Fill(dataSet: data);
                dataAdapter.Dispose();

                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
            return data.Tables[0];
        }

        public List<Tuple<Lich_DTO, TimeSpan, string, string, int, string>> GetDataLichThoiGianVatTu()
        {
            List<Tuple<Lich_DTO, TimeSpan, string, string, int, string>> tuples =
                new List<Tuple<Lich_DTO, TimeSpan, string, string, int, string>>();
            command = new MySqlCommand {
                CommandText = "SELECT a.ID, a.NgayLapLich, c.ThoiGian, d.VatTu, e.DonVi, b.SoLuong, b.GhiChu "
                              + "FROM lich AS a "
                              + "INNER JOIN lich_thoigian_vattu AS b "
                              + "ON b.IDLich = a.ID "
                              + "INNER JOIN thoigian AS c "
                              + "ON b.IDThoiGian = c.ID "
                              + "INNER JOIN vattu AS d "
                              + "ON b.IDVatTu = d.ID "
                              + "INNER JOIN donvi AS e "
                              + "ON d.IDDonVi = e.ID "
                              + "ORDER BY a.ID, c.ThoiGian;",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();

                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        tuples.Add(
                            new Tuple<Lich_DTO, TimeSpan, string, string, int, string>(
                                new Lich_DTO(id: reader.GetString("ID"),
                                             ngayLapLich: reader.GetDateTime("NgayLapLich")),
                                reader.GetTimeSpan("ThoiGian"),
                                reader.GetString("VatTu"),
                                reader.GetString("DonVi"),
                                reader.GetInt32("SoLuong"),
                                reader.GetString("GhiChu")));
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
            return tuples;
        }
    }
}
