using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TakeCareOfPlants_BUS;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants
{
    public class Generic_GUI<T, U>
        where T : class
        where U : new()
    {
        public void AutoCompleteCell(TextBox textBox, AutoCompleteStringCollection auto)
        {
            try {
                if (textBox != null) {
                    textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                    if (typeof(T).Equals(typeof(VatTu_DTO))) {
                        Generic_GUI<VatTu_DTO, U> generic = new Generic_GUI<VatTu_DTO, U>();
                        foreach (VatTu_DTO value in (new U() as VatTu_BUS).GetValueVatTu()) {
                            auto.Add(value.TenVatTu);
                        };
                    }

                    if (typeof(T).Equals(typeof(DonVi_DTO))) {
                        Generic_GUI<DonVi_DTO, U> generic = new Generic_GUI<DonVi_DTO, U>();
                        foreach (DonVi_DTO value in (new U() as VatTu_BUS).GetValueDonVi()) {
                            auto.Add(value.DonVi);
                        }
                    }

                    textBox.AutoCompleteCustomSource = auto;
                }
            } catch (Exception ex) {
                Function_GUI.ShowErrorDialog(ex.Message);
            }
        }
    }
}
