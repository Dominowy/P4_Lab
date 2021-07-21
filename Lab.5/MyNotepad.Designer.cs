
namespace Lab._5
{
    partial class MyNotepad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyNotepad));
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SaveAs = new System.Windows.Forms.Button();
            this.SaveFileD = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AppNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.AppTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(13, 13);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(700, 425);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(3, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Zapisz";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(3, 32);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(75, 23);
            this.SaveAs.TabIndex = 2;
            this.SaveAs.Text = "Zapisz Jako";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // SaveFileD
            // 
            this.SaveFileD.DefaultExt = "txt";
            this.SaveFileD.RestoreDirectory = true;
            this.SaveFileD.ShowHelp = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Save);
            this.flowLayoutPanel1.Controls.Add(this.SaveAs);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(719, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(82, 425);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // AppNotification
            // 
            this.AppNotification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.AppNotification.BalloonTipText = "\r\nOd dłuższego czasu nie zapisałeś pracy.";
            this.AppNotification.BalloonTipTitle = "Zapisz Pracę";
            this.AppNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("AppNotification.Icon")));
            this.AppNotification.Text = "Notification";
            this.AppNotification.Visible = true;
            // 
            // AppTimer
            // 
            this.AppTimer.Interval = 900000;
            this.AppTimer.Tick += new System.EventHandler(this.AppTimer_Tick);
            // 
            // MyNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyNotepad";
            this.Text = "MyNotepad";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button SaveAs;
        private System.Windows.Forms.SaveFileDialog SaveFileD;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NotifyIcon AppNotification;
        private System.Windows.Forms.Timer AppTimer;
    }
}

