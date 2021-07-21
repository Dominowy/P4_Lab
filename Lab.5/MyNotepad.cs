using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab._5
{
    public partial class MyNotepad : Form
    {
        private string filePath;
        private bool hasChanges;

        public MyNotepad()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            hasChanges = true;
            Save.Font = new Font(Save.Font, FontStyle.Bold);
            ChangeTitle();
            AppTimer.Enabled = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                SaveAsF();
            }
            else
            {
                SaveF();
            }
            
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveAsF();
        }

        private void SaveF()
        {
            var text = TextBox.Text;
            File.WriteAllText(filePath, text);
            hasChanges = false;
            Save.Font = new Font(Save.Font, FontStyle.Regular);
            ChangeTitle();
            AppTimer.Stop();
        }

        private void SaveAsF()
        {
            var result = SaveFileD.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath = SaveFileD.FileName;
                SaveF();
            }
        }

        private void ChangeTitle()
        {

            if (string.IsNullOrWhiteSpace(filePath))
            {
                this.Text = Name;
            }
            else
            {
                var fileName = filePath.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries).Last();
                this.Text = Name + " - " + fileName;
            }

            if (hasChanges)
            {
                this.Text += "*";
            }
        }

        private void AppTimer_Tick(object sender, EventArgs e)
        {
            AppNotification.ShowBalloonTip(3000);
        }
    }
}
