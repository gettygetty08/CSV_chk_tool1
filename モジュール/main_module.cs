using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSV_chk_tool1.モジュール
{
    public class main_module : base_module
    {

        private DirectoryInfo 取込フォルダ;
        private DirectoryInfo 出力フォルダ;

        public void input_date()
        {
            try
            {

                パラメータセット();


            }

            catch
            {

            }




        }

        private void パラメータセット()
        {
            try
            {
                string Errmsg = "パスが存在しません。\n正しいパスを選択してください。";
                //ディレクトリパスの存在チェック
                if (!Directory.Exists(取込フォルダパス)) throw new Exception("取込フォルダ"+Errmsg);
                if (!Directory.Exists(出力フォルダパス)) throw new Exception("出力フォルダ" + Errmsg);

                取込フォルダ = new DirectoryInfo(取込フォルダパス);
                出力フォルダ = new DirectoryInfo(出力フォルダパス);

                string Errmsg2 = "取込フォルダ内にCSVファイルがありません。\n取込フォルダを選択しなおしてください。";
                //取込フォルダにcsvファイルが存在しているかチェック
                if (取込フォルダ.GetFiles("*.csv").Count() < 1) throw new Exception(Errmsg2);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
