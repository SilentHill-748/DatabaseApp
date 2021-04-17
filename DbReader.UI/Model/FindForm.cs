using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DbReader.UI.Model
{
    public partial class FindForm : Form
    {
        private readonly IDatabaseServer server;

        public List<DataRow> infoAboutFoundedUsers;

        public FindForm(IDatabaseServer server)
        {
            InitializeComponent();
            this.server = server;
            infoAboutFoundedUsers = new List<DataRow>();
        }

        private void OkBut_Click(object sender, EventArgs e)
        {
            LoadDataByName();
            Close();
        }

        private void InputNameText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDataByName();
                Close();
            }
        }

        private void LoadDataByName()
        {
            server.Command = $"SELECT * FROM clients WHERE name = \'{inputNameText.Text}\';";
            server.LoadData();
            GetRecord(server.DataSet.Tables[0]);
        }

        private void GetRecord(DataTable table)
        {
            if (table.Rows.Count == 0)
                throw new Exception("Такого имени нет или таблица пуста!");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                infoAboutFoundedUsers.Add(table.Rows[i]);
            }
        }
    }
}
