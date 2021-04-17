
namespace DbReader.UI.Model
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.faceImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.okBut = new System.Windows.Forms.Button();
            this.moveBackBut = new System.Windows.Forms.Button();
            this.moveNextBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.faceImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // faceImage
            // 
            this.faceImage.BackColor = System.Drawing.SystemColors.Control;
            this.faceImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.faceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.faceImage.Location = new System.Drawing.Point(350, 12);
            this.faceImage.Name = "faceImage";
            this.faceImage.Size = new System.Drawing.Size(177, 153);
            this.faceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.faceImage.TabIndex = 0;
            this.faceImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Почта: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(71, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emailText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.phoneText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.idText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 153);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инфо";
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailText.Location = new System.Drawing.Point(111, 110);
            this.emailText.Name = "emailText";
            this.emailText.ReadOnly = true;
            this.emailText.Size = new System.Drawing.Size(205, 26);
            this.emailText.TabIndex = 8;
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneText.Location = new System.Drawing.Point(111, 81);
            this.phoneText.Name = "phoneText";
            this.phoneText.ReadOnly = true;
            this.phoneText.Size = new System.Drawing.Size(205, 26);
            this.phoneText.TabIndex = 7;
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameText.Location = new System.Drawing.Point(111, 52);
            this.nameText.Name = "nameText";
            this.nameText.ReadOnly = true;
            this.nameText.Size = new System.Drawing.Size(205, 26);
            this.nameText.TabIndex = 6;
            // 
            // idText
            // 
            this.idText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idText.Location = new System.Drawing.Point(111, 23);
            this.idText.Name = "idText";
            this.idText.ReadOnly = true;
            this.idText.Size = new System.Drawing.Size(205, 26);
            this.idText.TabIndex = 5;
            // 
            // okBut
            // 
            this.okBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okBut.Location = new System.Drawing.Point(384, 171);
            this.okBut.Name = "okBut";
            this.okBut.Size = new System.Drawing.Size(112, 30);
            this.okBut.TabIndex = 6;
            this.okBut.Text = "Ok";
            this.okBut.UseVisualStyleBackColor = true;
            this.okBut.Click += new System.EventHandler(this.Ok_Click);
            // 
            // moveBackBut
            // 
            this.moveBackBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveBackBut.Location = new System.Drawing.Point(56, 171);
            this.moveBackBut.Name = "moveBackBut";
            this.moveBackBut.Size = new System.Drawing.Size(69, 30);
            this.moveBackBut.TabIndex = 7;
            this.moveBackBut.Text = "<<";
            this.moveBackBut.UseVisualStyleBackColor = true;
            this.moveBackBut.Click += new System.EventHandler(this.MoveBackBut_Click);
            // 
            // moveNextBut
            // 
            this.moveNextBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveNextBut.Location = new System.Drawing.Point(259, 171);
            this.moveNextBut.Name = "moveNextBut";
            this.moveNextBut.Size = new System.Drawing.Size(69, 30);
            this.moveNextBut.TabIndex = 8;
            this.moveNextBut.Text = ">>";
            this.moveNextBut.UseVisualStyleBackColor = true;
            this.moveNextBut.Click += new System.EventHandler(this.MoveNextBut_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(539, 211);
            this.Controls.Add(this.moveNextBut);
            this.Controls.Add(this.moveBackBut);
            this.Controls.Add(this.okBut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.faceImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.faceImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox faceImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Button okBut;
        private System.Windows.Forms.Button moveBackBut;
        private System.Windows.Forms.Button moveNextBut;
    }
}