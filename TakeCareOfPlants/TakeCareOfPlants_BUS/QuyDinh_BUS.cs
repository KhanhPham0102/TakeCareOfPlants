using System;
using System.Collections.Generic;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public static class QuyDinh_BUS
    {
        private static readonly QuyDinh_SQL quyDinhSQL = new QuyDinh_SQL();
        private static readonly ViTri_SQL viTriSQL = new ViTri_SQL();
        private static readonly VatTu_SQL vatTuSQL = new VatTu_SQL();

        public static List<QuyDinh_DTO> GetValueQuyDinh() => quyDinhSQL.GetDataQuyDinh();

        public static List<ViTri_DTO> GetValueViTri() => viTriSQL.GetDataViTri();

        public static List<ViTri_DTO> GetAvailableViTri() => viTriSQL.GetAllDataViTri();

        public static void UpdateValueQuyDinh(List<ViTri_DTO> viTri_DTOs)
        {
            List<VatTu_DTO> vatTu_DTOs = vatTuSQL.GetDataVatTu();

            if (vatTu_DTOs.Count <= GlobalVariable_DTO.QuyDinh_DTOs[1].SoLoaiVatTu) {
                quyDinhSQL.UpdateDataQuyDinh(viTri_DTOs, GlobalVariable_DTO.QuyDinh_DTOs[1]);
            } else {
                throw new Exception("The Maximum Material Must More Than The Material Avaiable");
            }
        }
    }
}
