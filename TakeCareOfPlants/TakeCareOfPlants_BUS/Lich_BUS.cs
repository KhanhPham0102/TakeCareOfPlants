using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public class Lich_BUS
    {
        private readonly Lich_SQL lich_SQL = new Lich_SQL();
        private readonly ThoiGian_SQL thoiGianSQL = new ThoiGian_SQL();
        private readonly VatTu_SQL vatTuSQL = new VatTu_SQL();

        public string InsertAndGetLastIdValueLich() => lich_SQL.InsertAndGetLastIdDataLich();

        public void InsertValueThoiGian(string idLich,
                                        string thoiGian,
                                        List<string> listCayCanh,
                                        List<Tuple<string, int>> tuples,
                                        string ghiChu)
        {
            thoiGianSQL.InsertDataThoiGian(idLich: idLich,
                                           thoiGian: thoiGian,
                                           cayCanhs: listCayCanh,
                                           vatTus: tuples,
                                           ghiChu: ghiChu);
        }

        public DataTable GetAllValuaLich(string idCay, string idLich) => lich_SQL.GetAllDataLich(idCayCanh: idCay,
                                                                                                 idLich: idLich);

        public DataTable GetCostCare(int month) => vatTuSQL.GetCostReport(month: month);

        public List<Lich_DTO> GetListLich() => lich_SQL.GetDataLich();

        public List<Tuple<Lich_DTO, TimeSpan, string, string, int, string>> GetValueLich() => lich_SQL.GetDataLichThoiGianVatTu();
    }
}
