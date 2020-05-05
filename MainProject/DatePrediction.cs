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
        public float arrivalDate;

        

        public DateTime ToDateTime()
        {
            long arrivalDateAfterConversion = Convert.ToInt64(arrivalDate);
            Console.WriteLine(arrivalDateAfterConversion);
            Console.ReadLine();
            var dateTime = DateTimeOffset.FromUnixTimeMilliseconds(arrivalDateAfterConversion).DateTime.ToLocalTime();
            return dateTime;
        }
    }

   
}
