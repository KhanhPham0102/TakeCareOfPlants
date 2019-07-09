using System;
using System.Collections.Generic;
using System.Linq;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public class VatTu_BUS
    {
        private readonly VatTu_SQL vatTuSQL = new VatTu_SQL();
        private readonly DonVi_SQL donViSQL = new DonVi_SQL();
        private readonly MuaVatTu_SQL muaVatTuSQL = new MuaVatTu_SQL();

        public List<VatTu_DTO> GetValueVatTu() => vatTuSQL.GetDataVatTu();

        public List<DonVi_DTO> GetValueDonVi() => donViSQL.GetDataDonVi();

        public List<Tuple<VatTu_DTO, DonVi_DTO>> GetValueVatTuDonVi() => vatTuSQL.GetDataVatTuDonVi();

        public void InsertValuePhieuMuaVatTu(List<Tuple<string, string, MuaVatTu_DTO>> tuples)
        {
            long soTien = 0;
            List<string> vatTus = GetValueVatTu().Select(x => x.TenVatTu).ToList();
            List<string> tenVatTuMoi = new List<string>();
            List<string> donVis = GetValueDonVi().Select(x => x.DonVi).ToList();
            List<string> tenDonViMoi = new List<string>();

            foreach (Tuple<string, string, MuaVatTu_DTO> tuple in tuples) {
                soTien += tuple.Item3.SoTien;
                
                if (!vatTus.Contains(tuple.Item1)) {
                    tenVatTuMoi.Add(tuple.Item1);
                }
                
                if (!donVis.Contains(tuple.Item2)) {
                    tenDonViMoi.Add(tuple.Item2);
                }
            }

            if ((vatTus.Count + tenVatTuMoi.Count) <= GlobalVariable_DTO.QuyDinh_DTOs[1].SoLoaiVatTu) {
                if (soTien <= GlobalVariable_DTO.QuyDinh_DTOs[1].SoTienToiDa) {
                    muaVatTuSQL.InsertDataMuaVatTu(tuples, tenVatTuMoi, tenDonViMoi);
                } else {
                    throw new Exception("Money Is Maximum");
                }
            } else {
                throw new Exception("Material Is Maximum");
            }  
        }
    }
}
