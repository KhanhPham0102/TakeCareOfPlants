using System;
using System.Collections.Generic;
using System.Text;

namespace TakeCareOfPlants_DTO
{
    public class DonVi_DTO
    {
        public DonVi_DTO() {}

        public DonVi_DTO(string donVi) => (DonVi) = (donVi);

        public DonVi_DTO(string id, string donVi) => (Id, DonVi) = (id, donVi);

        public string Id { get; set; }
        public string DonVi { get; set; }
    }
}
