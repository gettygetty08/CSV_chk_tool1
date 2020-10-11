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
        }

        private void End_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InFolder_Select_btn_Click(object sender, EventArgs e)
        {
            using (selectFD) 
            {
                selectFD.Title = "取込フォルダを選択してください。";
                selectFD.InitialDirectory = InFolder_Path.Text == string.Empty ? common_const.初期フォルダ : InFolder_Path.Text;

                if (selectFD.ShowDialog() == DialogResult.OK) InFolder_Path.Text = Path.GetDirectoryName(selectFD.FileName);

            }


        }

        private void OutFolder_Select_btn_Click(object sender, EventArgs e)
        {
            using(selectFD)
            {
                selectFD.Title = "出力フォルダーを選択してください";
                selectFD.InitialDirectory = OutFolder_Path.Text == string.Empty ? common_const.初期フォルダ : OutFolder_Path.Text;


                if (selectFD.ShowDialog() == DialogResult.OK) OutFolder_Path.Text = Path.GetDirectoryName(selectFD.FileName);

            }
        }
    }
}
