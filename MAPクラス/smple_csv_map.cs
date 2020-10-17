using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSV_chk_tool1
{
    public class sample_csv_map : ClassMap<sample_csv>
    {
        private sample_csv_map()
        {
            Map(x => x.連番).Index(0);
            Map(x => x.ID).Index(1);
            Map(x => x.Q1).Index(2);
            Map(x => x.Q2).Index(3);
            Map(x => x.Q3).Index(4);
            Map(x => x.Q4).Index(5);
            Map(x => x.Q5).Index(6);
            Map(x => x.Q6).Index(7);
            Map(x => x.Q7).Index(8);
            Map(x => x.Q8).Index(9);
            Map(x => x.Q9).Index(10);

        }
        
    }
}
