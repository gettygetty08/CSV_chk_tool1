using CSV_chk_tool1.格納用クラス;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSV_chk_tool1.MAPクラス
{
    public class IDクラスマッピング:ClassMap<IDクラス>
    {
        private IDクラスマッピング()
        {
            Map(x => x.顧客番号).Index(0);
            Map(x => x.ID).Index(1);
        }
    }
}
