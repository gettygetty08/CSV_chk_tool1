using CSV_chk_tool1.MAPクラス;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CSV_chk_tool1.モジュール
{
    public static class CSV出力クラス
    {
        public static void CSV出力<CMAP,T>(string f_Path,IEnumerable<T> 出力リスト)
            where CMAP : ClassMap
            where T: class
        {
            using (var csv = new CsvWriter(new StreamWriter(f_Path), CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord = false;
                csv.Configuration.RegisterClassMap<CMAP>();
                csv.WriteRecords(出力リスト);
            }
        }


    }
}
