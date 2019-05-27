using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaldenHospitalLenovo.Common
{
    class DateTimeConverter
    {
        public static DateTime Converter(DateTimeOffset dto, TimeSpan ts)
        {
            return new DateTime(dto.Year , dto.Month , dto.Day , ts.Hours , ts.Minutes, ts.Seconds);
        }
    }
}
