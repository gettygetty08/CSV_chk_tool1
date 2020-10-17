using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSV_chk_tool1.モジュール
{
    public static class Readcsv
    {
        public static List<sample_csv> Read_sample_Csvs(string f_path)
        {
            List<sample_csv> list1 = new List<sample_csv>();

            using(var csv = new CsvReader(new StreamReader(f_path), CultureInfo.InvariantCulture))
            {
                var config = csv.Configuration;
                config.HasHeaderRecord = true;
                config.RegisterClassMap<sample_csv_map>();
                list1 =  csv.GetRecords<sample_csv>().ToList();
                
            }

            return list1;

        }

    }
}
