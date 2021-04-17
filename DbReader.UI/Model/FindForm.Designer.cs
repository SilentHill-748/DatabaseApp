
namespace DbReader.UI.Model
{
    partial class FindForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.okBut = new System.Windows.Forms.Button();
            this.inputNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Напишите имя, которое нужно найти и нажмите <Enter> или кнопку \"Ok\".";
            // 
            // okBut
            // 
            this.okBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okBut.Location = new System.Drawing.Point(328, 43);
            this.okBut.Name = "okBut";
            this.okBut.Size = new System.Drawing.Size(90, 32);
            this.okBut.TabIndex = 1;
            this.okBut.Text = "Ok";
            this.okBut.UseVisualStyleBackColor = true;
            this.okBut.Click += new System.EventHandler(this.OkBut_Click);
            // 
            // inputNameText
            // 
            this.inputNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNameText.Location = new System.Drawing.Point(172, 46);
            this.inputNameText.Name = "inputNameText";
            this.inputNameText.Size = new System.Drawing.Size(141, 26);
            this.inputNameText.TabIndex = 2;
            this.inputNameText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputNameText_KeyUp);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 91);
            this.Controls.Add(this.inputNameText);
            this.Controls.Add(this.okBut);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okBut;
        private System.Windows.Forms.TextBox inputNameText;
    }
}