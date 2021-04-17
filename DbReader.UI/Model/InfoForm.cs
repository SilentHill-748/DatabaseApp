using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace DbReader.UI.Model
{
    public partial class InfoForm : Form
    {
        private readonly List<DataRow> infoAboutCurrentUsers;

        private string currentName;
        private TextBox[] textBoxes;
        private int currentUserIndex;

        public InfoForm(List<DataRow> infoAboutCurrentUsers)
        {
            InitializeComponent();

            this.infoAboutCurrentUsers = infoAboutCurrentUsers;
            Init();
        }

        private void Ok_Click(object sender, EventArgs e) => Close();

        private void MoveBackBut_Click(object sender, EventArgs e)
        {
            if (currentUserIndex == 0) 
                return;
            else
                MoveBack();
        }

        private void MoveNextBut_Click(object sender, EventArgs e)
        {
            if (currentUserIndex == (infoAboutCurrentUsers.Count - 1)) 
                return;
            else 
                MoveNext();
        }

        private void Init()
        {
            currentUserIndex = 0;
            textBoxes = new TextBox[] { idText, nameText, phoneText, emailText };
            LoadTextBoxes(infoAboutCurrentUsers[0].ItemArray);
            LoadFaceImage();
            this.Text = $"Карточка пользователя \'{currentName}\'";
        }

        private void MoveNext()
        {
            currentUserIndex++;
            LoadTextBoxes(infoAboutCurrentUsers[currentUserIndex].ItemArray);
        }

        private void MoveBack()
        {
            currentUserIndex--;
            LoadTextBoxes(infoAboutCurrentUsers[currentUserIndex].ItemArray);
        }

        private void LoadTextBoxes(object[] data)
        {
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Text = data[i].ToString();
                // Если индекс поля равен индексу имени, то задать имя текущего пользователя в заголовок формы.
                if (textBoxes[i].Equals(nameText))
                    currentName = data[i].ToString();
            }
            LoadFaceImage();
        }

        private void LoadFaceImage()
        {
            object[] currentUser = infoAboutCurrentUsers[currentUserIndex].ItemArray;
            string pathToPhoto = currentUser[currentUser.Length - 1].ToString();

            if (!File.Exists(pathToPhoto))
                faceImage.Image = null;
            else
                faceImage.Image = new Bitmap(pathToPhoto);
        }
    }
}
