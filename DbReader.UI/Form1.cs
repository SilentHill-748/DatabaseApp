using System;
using System.Data;
using System.Windows.Forms;
using DbReader.UI.Model;

namespace DbReader.UI
{
    public partial class MainForm : Form
    {
        private DataSet currentData;
        private ServerType currentServerType;
        private IDatabaseServer server;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        #region Events
        private void CurrentDb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentDb.SelectedIndex == -1) return;

            try
            {
                string serverType = currentDb.SelectedItem.ToString();
                currentServerType = (ServerType)Enum.Parse(typeof(ServerType), serverType);
                InitializeServer(currentServerType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBut_Click(object sender, EventArgs e)
        {
            if (server is null) return;
            FillData();
            SettingsDataTable();
        }

        private void FindBut_Click(object sender, EventArgs e)
        {
            try
            {
                FindForm find = new FindForm(server);
                find.ShowDialog();
                InfoForm info = new InfoForm(find.infoAboutFoundedUsers);
                info.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Private methods
        private void Init()
        {
            currentServerType = ServerType.None;
            currentData = new DataSet();
        }

        private void FillData()
        {
            server.Command = "SELECT * FROM Clients;";
            server.LoadData();
            currentData = server.DataSet.Copy();
            dataTable.DataSource = currentData.Tables[0];
        }

        private void InitializeServer(ServerType serverType)
        {
            switch (serverType)
            {
                case ServerType.Access: 
                    server = new AccessServer(); 
                    break;
                case ServerType.MSSQL: 
                    server = new SqlServer(); 
                    break;
                default:
                    throw new Exception("Не указан тип сервера!");
            }
        }

        private void SettingsDataTable()
        {
            var columns = dataTable.Columns;
            for (int i = 0; i < columns.Count; i++)
            {
                columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        #endregion
    }
}
