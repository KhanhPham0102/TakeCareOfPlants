using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class VatTu_SQL
    {
        private readonly DatabaseConnection databaseConnection = new DatabaseConnection();
        private MySqlCommand command;
        private MySqlDataReader reader;
        private MySqlDataAdapter dataAdapter;

        public List<VatTu_DTO> GetDataVatTu()
        {
            List<VatTu_DTO> vatTu_DTOs = new List<VatTu_DTO>();
            command = new MySqlCommand {
                CommandText = "SELECT * FROM vattu",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        vatTu_DTOs.Add(
                            new VatTu_DTO(
                                reader.GetString("ID"),
                                reader.GetString("VatTu")));
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
            return vatTu_DTOs;
        }

        public List<Tuple<VatTu_DTO, DonVi_DTO>> GetDataVatTuDonVi()
        {
            List<Tuple<VatTu_DTO, DonVi_DTO>> tuples = new List<Tuple<VatTu_DTO, DonVi_DTO>>();
            command = new MySqlCommand {
                CommandText = "SELECT a.ID, a.VatTu, b.DonVi FROM vattu AS a " +
                "INNER JOIN donvi AS b " +
                "ON a.IDDonVi = b.ID;",
                Connection = databaseConnection.Connection
            };
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        tuples.Add(
                            new Tuple<VatTu_DTO, DonVi_DTO>(
                                new VatTu_DTO(
                                    reader.GetString("ID"), 
                                    reader.GetString("VatTu")),
                                new DonVi_DTO(reader.GetString("DonVi"))));
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

        public DataTable GetCostReport(int month)
        {
            DataSet data = new DataSet();
            dataAdapter = new MySqlDataAdapter(
                "SELECT "
                    + "ROW_NUMBER() OVER() AS 'STT', "
                    + "sd.tenVatTu AS 'Vật_Tư', "
                    + "tc._count AS 'Số_Lượng', "
                    + "tc._cost AS 'Tổng_Giá_Trị', "
                    + "(sd._number / tc._number) * 100 AS 'Tỉ_Lệ' "
                + "FROM( "
                    + "SELECT "
                        + "vt.VatTu AS tenVatTu, "
                        + "vt.ID AS id, "
                        + "SUM(l_tg_vt.SoLuong) AS _number "
                    + "FROM vattu AS vt "
                    + "INNER JOIN lich_thoigian_vattu AS l_tg_vt "
                    + "ON l_tg_vt.IDVatTu = vt.ID "
                    + "INNER JOIN lich AS l "
                    + "ON l_tg_vt.IDLich = l.ID "
                    + "WHERE MONTH(l.NgayLapLich) = '" + month + "' "
                    + "GROUP BY vt.ID "
                + ") sd "
                + "JOIN( "
                    + "SELECT "
                        + "vt.ID AS id, "
                        + "vt.VatTu AS tenVatTu, "
                        + "COUNT(vt_mvt.IDVatTu) AS _count, "
                        + "SUM(vt_mvt.SoTien) AS _cost, "
                        + "SUM(vt_mvt.SoLuong) AS _number "
                    + "FROM vattu AS vt "
                    + "INNER JOIN vattu_muavattu AS vt_mvt "
                    + "ON vt_mvt.IDVatTu = vt.ID "
                    + "INNER JOIN muavattu AS mvt "
                    + "ON vt_mvt.IDMuaVatTu = mvt.ID "
                    + "GROUP BY vt.ID "
                + ") tc ON sd.id = tc.id;",
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
    }
}
