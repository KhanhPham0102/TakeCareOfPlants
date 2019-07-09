using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public class CayCanh_BUS
    {
        private readonly CayCanh_SQL cayCanhSQL = new CayCanh_SQL();
        private readonly ViTri_SQL viTriSQL = new ViTri_SQL();
        private readonly Loai_SQL loaiSQL = new Loai_SQL();
        private readonly TinhTrang_SQL tinhTrangSQL = new TinhTrang_SQL();

        public void InsertValueCayCanh(CayCanh_DTO cayCanh_DTO, string idViTri)
        {
            ViTri_DTO viTri_DTO = viTriSQL.GetAllDataViTri().Find(r => r.Id == idViTri);

            if ((viTri_DTO.SoCayCoSan + 1) <= viTri_DTO.SoCayToiDa) {
                try {
                    cayCanhSQL.InsertDataCayCanh(cayCanh_DTO, viTri_DTO.Id);
                } catch (Exception ex) {
                    throw new Exception(ex.Message);
                }   
            } else {
                throw new Exception("The Location Is Full");
            }
        }

        public string LastIDCayCanh() => cayCanhSQL.GetLastIDCayCanh();

        public DataTable GetAllValueCayCanh() => cayCanhSQL.GetAllDataCayCanh();

        public DataTable GetPlantStatus(int month) => cayCanhSQL.GetStatusReport(month);

        public Loai_DTO GetValueLoaiWithId(string id) => loaiSQL.GetDataLoaiWithId(id);

        public List<Loai_DTO> GetValueLoai() => loaiSQL.GetDataLoai();

        public TinhTrang_DTO GetValueTinhTrangWithId(string id) => tinhTrangSQL.GetDataTinhTrangWithId(id);

        public List<TinhTrang_DTO> GetValueTinhTrang() => tinhTrangSQL.GetDataTinhTrang();

        public List<Tuple<CayCanh_DTO, ViTri_DTO>> GetValueCayCanhViTri() => cayCanhSQL.GetDataCayCanhViTri();
    }
}
