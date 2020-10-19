using CSV_chk_tool1.MAPクラス;
using CSV_chk_tool1.モジュール;
using CSV_chk_tool1.格納用クラス;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_chk_tool1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InFolder_Select_btn.Click += SetFolderPath(InFolder_Path, "取込フォルダを選択してください。");
            OutFolder_Select_btn.Click += SetFolderPath(OutFolder_Path, "出力フォルダーを選択してください");


        }

        private void End_btn_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void Start_btn_Click(object sender, EventArgs e)
        {
            var cls1 = new main_module() 
            { 
                出力フォルダパス = OutFolder_Path.Text, 
                取込フォルダパス = InFolder_Path.Text,
            
            };
            cls1.input_date();
        }

        
        private EventHandler SetFolderPath(TextBox txtbox,string Title) 
            => (_, __)
            =>
        {
            using (selectFD)
            {
                selectFD.Title = Title;
                selectFD.InitialDirectory = txtbox.Text == string.Empty ? common_const.初期フォルダ : txtbox.Text;


                if (selectFD.ShowDialog() == DialogResult.OK) txtbox.Text = Path.GetDirectoryName(selectFD.FileName);

            }
        };


    }
}
