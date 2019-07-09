using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace TakeCareOfPlants_DAL
{
    internal class DatabaseConnection
    {
        public DatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBQLCC"].ConnectionString;
            Connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection Connection { get; set; }

        public bool OpenConnect()
        {
            try {
                if (Connection.State.ToString().Equals("Closed")) {
                    Connection.Open();
                }
            } catch (Exception ex) {
                MessageBox.Show("Loi: " + ex.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CloseConnect()
        {
            try {
                if (Connection.State.ToString().Equals("Open")) {
                    Connection.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show("Loi: " + ex.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
