using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeCareOfPlants
{
    public partial class UI_Reports : UserControl
    {
        private static UI_Reports uiReports;

        public UI_Reports()
        {
            InitializeComponent();
        }

        public static UI_Reports Instance
        {
            get {
                if (uiReports == null) {
                    uiReports = new UI_Reports();
                }
                return uiReports;
            }
        }
    }
}
