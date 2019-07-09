using System;
using System.Collections.Generic;
using TakeCareOfPlants_DAL;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_BUS
{
    public class VatTu_BUS
    {
        private VatTu_SQL vatTuSQL = new VatTu_SQL();
        private DonVi_SQL donViSQL = new DonVi_SQL();

        public List<VatTu_DTO> GetValueVatTu() => vatTuSQL.GetDataVatTu();

        public List<DonVi_DTO> GetValueDonVi() => donViSQL.GetDataDonVi();

        public List<Tuple<VatTu_DTO, DonVi_DTO>> GetValueVatTuDonVi() => vatTuSQL.GetDataVatTuDonVi();
    }
}
