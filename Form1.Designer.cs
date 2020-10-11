namespace CSV_chk_tool1
{
    partial class Form1
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
            this.InFolder_Path = new System.Windows.Forms.TextBox();
            this.InFolder_Select_btn = new System.Windows.Forms.Button();
            this.OutFolder_Path = new System.Windows.Forms.TextBox();
            this.OutFolder_Select_btn = new System.Windows.Forms.Button();
            this.Start_btn = new System.Windows.Forms.Button();
            this.End_btn = new System.Windows.Forms.Button();
            this.selectFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // InFolder_Path
            // 
            this.InFolder_Path.Location = new System.Drawing.Point(42, 62);
            this.InFolder_Path.Name = "InFolder_Path";
            this.InFolder_Path.Size = new System.Drawing.Size(403, 23);
            this.InFolder_Path.TabIndex = 0;
            this.InFolder_Path.Tag = "";
            this.InFolder_Path.Text = "C:\\Users\\getty\\Desktop\\サンプルファイル";
            // 
            // InFolder_Select_btn
            // 
            this.InFolder_Select_btn.Location = new System.Drawing.Point(519, 50);
            this.InFolder_Select_btn.Name = "InFolder_Select_btn";
            this.InFolder_Select_btn.Size = new System.Drawing.Size(127, 45);
            this.InFolder_Select_btn.TabIndex = 1;
            this.InFolder_Select_btn.Text = "取込フォルダ選択";
            this.InFolder_Select_btn.UseVisualStyleBackColor = true;
            this.InFolder_Select_btn.Click += new System.EventHandler(this.InFolder_Select_btn_Click);
            // 
            // OutFolder_Path
            // 
            this.OutFolder_Path.Location = new System.Drawing.Point(42, 159);
            this.OutFolder_Path.Name = "OutFolder_Path";
            this.OutFolder_Path.Size = new System.Drawing.Size(403, 23);
            this.OutFolder_Path.TabIndex = 0;
            this.OutFolder_Path.Tag = "";
            this.OutFolder_Path.Text = "C:\\temp\\csv_check_tool";
            // 
            // OutFolder_Select_btn
            // 
            this.OutFolder_Select_btn.Location = new System.Drawing.Point(519, 147);
            this.OutFolder_Select_btn.Name = "OutFolder_Select_btn";
            this.OutFolder_Select_btn.Size = new System.Drawing.Size(127, 45);
            this.OutFolder_Select_btn.TabIndex = 1;
            this.OutFolder_Select_btn.Text = "出力フォルダ選択";
            this.OutFolder_Select_btn.UseVisualStyleBackColor = true;
            this.OutFolder_Select_btn.Click += new System.EventHandler(this.OutFolder_Select_btn_Click);
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(505, 249);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(173, 53);
            this.Start_btn.TabIndex = 1;
            this.Start_btn.Text = "処理開始";
            this.Start_btn.UseVisualStyleBackColor = true;
            // 
            // End_btn
            // 
            this.End_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.End_btn.Location = new System.Drawing.Point(42, 360);
            this.End_btn.Name = "End_btn";
            this.End_btn.Size = new System.Drawing.Size(121, 51);
            this.End_btn.TabIndex = 1;
            this.End_btn.Text = "終了";
            this.End_btn.UseVisualStyleBackColor = false;
            this.End_btn.Click += new System.EventHandler(this.End_btn_Click);
            // 
            // selectFD
            // 
            this.selectFD.CheckFileExists = false;
            this.selectFD.FileName = "SelectFolder";
            this.selectFD.Filter = "Folder |.";
            this.selectFD.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.End_btn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.OutFolder_Select_btn);
            this.Controls.Add(this.InFolder_Select_btn);
            this.Controls.Add(this.OutFolder_Path);
            this.Controls.Add(this.InFolder_Path);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "InFolder_path";
            this.Text = "CSV_chk_tool1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InFolder_Path;
        private System.Windows.Forms.Button InFolder_Select_btn;
        private System.Windows.Forms.TextBox OutFolder_Path;
        private System.Windows.Forms.Button OutFolder_Select_btn;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button End_btn;
        private System.Windows.Forms.OpenFileDialog selectFD;
    }
}

