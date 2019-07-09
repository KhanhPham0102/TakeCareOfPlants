using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class CayCanh_SQL
    {
        private readonly DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataAdapter dataAdapter;
        private MySqlDataReader reader;

        public string GetLastIDCayCanh()
        {
            string lastId = null;
            command = new MySqlCommand {
                CommandText = "SELECT MAX(ID) FROM caycanh",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();

                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        lastId = reader.GetString("MAX(ID)");
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
            return lastId;
        }

        public DataTable GetAllDataCayCanh()
        {
            DataSet data = new DataSet();
            dataAdapter = new MySqlDataAdapter(
                "SELECT "
                + "ROW_NUMBER() OVER () AS 'STT', "
                + "cc.TenCay AS 'Cây_Cảnh', "
                + "lcc.Loai AS 'Loại', "
                + "vt.TenViTri AS 'Vị_Trí', "
                + "tt.TinhTrang AS 'Tình_Trạng'"
                + "FROM caycanh AS cc "
                + "INNER JOIN caycanh_vitri AS cc_vt "
                + "ON cc.ID = cc_vt.IDCayCanh "
                + "INNER JOIN vitri AS vt "
                + "ON vt.ID = cc_vt.IDViTri "
                + "INNER JOIN loaicaycanh AS lcc "
                + "ON lcc.ID = cc.IDLoai "
                + "INNER JOIN tinhtrang AS tt "
                + "ON tt.ID = cc.IDTinhTrang;",
                databaseConnection.Connection);

            try {
                databaseConnection.OpenConnect();

                dataAdapter.Fill(data);
                dataAdapter.Dispose();

                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
            return data.Tables[0];
        }

        public List<Tuple<CayCanh_DTO, ViTri_DTO>> GetDataCayCanhViTri()
        {
            List<Tuple<CayCanh_DTO, ViTri_DTO>> tuples = new List<Tuple<CayCanh_DTO, ViTri_DTO>>();
            command = new MySqlCommand {
                CommandText = "SELECT a.ID, a.TenCay, c.ID AS 'IDViTri', c.TenViTri "
                              + "FROM caycanh AS a "
                              + "INNER JOIN caycanh_vitri AS b "
                              + "ON a.ID = b.IDCayCanh "
                              + "INNER JOIN vitri AS c "
                              + "ON b.IDViTri = c.ID;",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();

                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        tuples.Add(
                            new Tuple<CayCanh_DTO, ViTri_DTO>(
                                new CayCanh_DTO(s: reader.GetString("ID"),
                                                i: reader.GetString("TenCay")),
                                new ViTri_DTO(id: reader.GetString("IDViTri"),
                                              tenViTri: reader.GetString("TenViTri"))));
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

        public DataTable GetStatusReport(int month)
        {
            DataSet data = new DataSet();
            dataAdapter = new MySqlDataAdapter(
                "SELECT "
                + "ROW_NUMBER() OVER () AS 'STT', "
                + "cc.TenCay AS 'Cây_Cảnh', "
                + "lcc.Loai AS 'Loại_Cây', "
                + "cc.NgayTrong AS 'Ngày_Trồng', "
                + "tt.TinhTrang AS 'Tình_Trạng' "
                + "FROM caycanh as cc "
                + "INNER JOIN loaicaycanh as lcc "
                + "ON cc.IDLoai = lcc.ID "
                + "INNER JOIN tinhtrang as tt "
                + "ON cc.IDTinhTrang = tt.ID "
                + "WHERE MONTH(cc.NgayTrong) = '" + month + "';",
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

        public void InsertDataCayCanh(CayCanh_DTO cayCanh_DTO, string idViTri)
        {
            command = new MySqlCommand {
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();

                command.CommandText = "INSERT INTO caycanh(TenCay, IDLoai, IDTinhTrang, NgayTrong) VALUE (@tc, @idlc, @idtt, @nt)";
                command.Parameters.AddWithValue("@tc", value: cayCanh_DTO.TenCay);
                command.Parameters.AddWithValue("@idlc", value: cayCanh_DTO.Loai_DTO.Id);
                command.Parameters.AddWithValue("@idtt", value: cayCanh_DTO.TinhTrang_DTO.Id);
                command.Parameters.AddWithValue("@nt", value: cayCanh_DTO.NgayTrong);
                command.ExecuteNonQuery();
                command.Dispose();

                command.CommandText = "INSERT INTO caycanh_vitri(IDCayCanh, IDViTri) VALUE ((SELECT MAX(ID) from caycanh), @idvt)";
                command.Parameters.AddWithValue("@idvt", value: idViTri);
                command.ExecuteNonQuery();
                command.Dispose();

                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
        }

        public void UpdateDataCayCanh(string idCay,
                                      string name,
                                      string idViTri,
                                      string idLoai,
                                      string idTinhTrang,
                                      DateTime dateTime)
        {
            try {
                databaseConnection.OpenConnect();

                command = new MySqlCommand {
                    Connection = databaseConnection.Connection,
                    CommandText = "UPDATE caycanh "
                    + "SET TenCay = @tc, IDLoai = @idl, IDTinhTrang = @idtt, NgayTrong = @nt "
                    + "WHERE ID = @id;"
                };
                command.Parameters.AddWithValue("@id", idCay);
                command.Parameters.AddWithValue("@tc", name);
                command.Parameters.AddWithValue("@idl", idLoai);
                command.Parameters.AddWithValue("@idtt", idTinhTrang);
                command.Parameters.AddWithValue("@nt", dateTime.ToString("yyyy-MM-dd"));
                command.ExecuteNonQuery();
                command.Dispose();

                command = new MySqlCommand {
                    Connection = databaseConnection.Connection,
                    CommandText = "UPDATE caycanh_vitri " +
                    "SET IDViTri = @idvt WHERE IDCayCanh = @idcc;"
                };
                command.Parameters.AddWithValue("@idvt", idViTri);
                command.Parameters.AddWithValue("@idcc", idCay);
                command.ExecuteNonQuery();
                command.Dispose();

                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
        }

        public void DeleteDataCayCanh(string idCay)
        {
            try {
                databaseConnection.OpenConnect();

                command = new MySqlCommand {
                    Connection = databaseConnection.Connection,
                    CommandText = "DELETE FROM caycanh_vitri WHERE IDCayCanh = @idcc;"
                };
                command.Parameters.AddWithValue("@idcc", idCay);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new MySqlCommand {
                    Connection = databaseConnection.Connection,
                    CommandText = "DELETE FROM caycanh WHERE ID = @id;"
                };
                command.Parameters.AddWithValue("@id", idCay);
                command.ExecuteNonQuery();
                command.Dispose();

                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                command.Dispose();
                databaseConnection.CloseConnect();
                throw ex;
            }
        }
    }
}
