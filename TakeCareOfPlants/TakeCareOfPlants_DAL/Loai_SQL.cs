﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TakeCareOfPlants_DTO;

namespace TakeCareOfPlants_DAL
{
    public class Loai_SQL
    {
        DatabaseConnection databaseConnection = new DatabaseConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataReader reader;

        public List<Loai_DTO> GetDataLoai()
        {
            List<Loai_DTO> loai_DTOs = new List<Loai_DTO>();
            command.CommandText = "SELECT * FROM loaicaycanh";
            command.Connection = databaseConnection.Connection;
            try {
                databaseConnection.OpenConnect();
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        loai_DTOs.Add(new Loai_DTO(reader.GetString("ID"), reader.GetString("loai")));
                    }
                }
                reader.Close();
                command.Dispose();
                databaseConnection.CloseConnect();
            } catch (Exception ex) {
                MessageBox.Show("Loi: " + ex.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Dispose();
                databaseConnection.CloseConnect();
            }
            return loai_DTOs;
        }
    }
}