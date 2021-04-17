
namespace DbReader.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.currentDb = new System.Windows.Forms.ComboBox();
            this.loadBut = new System.Windows.Forms.Button();
            this.findBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(12, 33);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(627, 256);
            this.dataTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текущая БД:";
            // 
            // currentDb
            // 
            this.currentDb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentDb.FormattingEnabled = true;
            this.currentDb.Items.AddRange(new object[] {
            "Access",
            "MSSQL"});
            this.currentDb.Location = new System.Drawing.Point(92, 6);
            this.currentDb.Name = "currentDb";
            this.currentDb.Size = new System.Drawing.Size(121, 21);
            this.currentDb.TabIndex = 2;
            this.currentDb.SelectedIndexChanged += new System.EventHandler(this.CurrentDb_SelectedIndexChanged);
            // 
            // loadBut
            // 
            this.loadBut.Location = new System.Drawing.Point(11, 295);
            this.loadBut.Name = "loadBut";
            this.loadBut.Size = new System.Drawing.Size(116, 23);
            this.loadBut.TabIndex = 3;
            this.loadBut.Text = "Загрузить данные";
            this.loadBut.UseVisualStyleBackColor = true;
            this.loadBut.Click += new System.EventHandler(this.LoadBut_Click);
            // 
            // findBut
            // 
            this.findBut.Location = new System.Drawing.Point(133, 295);
            this.findBut.Name = "findBut";
            this.findBut.Size = new System.Drawing.Size(122, 23);
            this.findBut.TabIndex = 7;
            this.findBut.Text = "Найти";
            this.findBut.UseVisualStyleBackColor = true;
            this.findBut.Click += new System.EventHandler(this.FindBut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(647, 328);
            this.Controls.Add(this.findBut);
            this.Controls.Add(this.loadBut);
            this.Controls.Add(this.currentDb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с БД с помощью технологии ADO.NET";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox currentDb;
        private System.Windows.Forms.Button loadBut;
        private System.Windows.Forms.Button findBut;
    }
}

