using CSV_chk_tool1.格納用クラス;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSV_chk_tool1.モジュール
{
    public class base_module
    {
        public string 取込フォルダパス { get; set; }
        public string 出力フォルダパス { get; set; }
        protected List<FileInfo> ファイル名 { get; set; }

        protected List<sample_csv> 取込CSV = new List<sample_csv>();
        protected List<sample_csv> 出力CSV = new List<sample_csv>();
        protected List<IDクラス> MKID出力CSV = new List<IDクラス>();
        protected List<異常CSV> 異常CSV = new List<異常CSV>();

    }
}
