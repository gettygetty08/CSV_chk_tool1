using CSV_chk_tool1.格納用クラス;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSV_chk_tool1.MAPクラス
{
    public class 異常CSVマッピング:ClassMap<異常CSV>
    {
        private 異常CSVマッピング()
        {
            Map(x => x.ファイル名).Index(0);
            Map(x => x.行数).Index(1);
        }
    }
}
