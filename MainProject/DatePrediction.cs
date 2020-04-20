using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    class DatePrediction
    {
        [ColumnName("Score")]
        public float arrival_date;
        public DateTime ToDateTime()
        {
            var dateTime = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(arrival_date)).DateTime.ToLocalTime();
            return dateTime;
    }
    }

   
}
