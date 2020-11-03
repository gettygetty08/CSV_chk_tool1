using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CSV_chk_tool1.モジュール
{
    public static class const_module
    {

        public static bool ブランクチェック(string チェック値)
        {
            return !string.IsNullOrEmpty(チェック値);

        }

        public static bool 制限文字チェック(string チェック値,string 禁止文字)
        {
            foreach(var item in 禁止文字.Split(','))
            {
                if (チェック値.Contains(item) == true) return false;
            }

            return true;
        }

        public static bool 数字複数回使用チェック(string チェック値, string 複数回禁止文字)
        {
            foreach (var item in 複数回禁止文字)
            {
                if (CountChar(チェック値, item) > 1) return false;
            }

            return true;
        }

        public static int CountChar(string s, char c)
        {
            return s.Length - s.Replace(c.ToString(), "").Length;
        }

        public static bool 桁数チェック(string チェック値,int 桁数)
        {
            return チェック値.Length <= 桁数;
        }

    }
}
