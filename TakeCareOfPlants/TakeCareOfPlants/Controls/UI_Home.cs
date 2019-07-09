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
    public partial class UI_Home : UserControl
    {
        private static UI_Home uiHome;

        public UI_Home()
        {
            InitializeComponent();
        }

        public static UI_Home Instance
        {
            get {
                if (uiHome == null) {
                    uiHome = new UI_Home();
                }
                return uiHome;
            }
        }
    }
}
