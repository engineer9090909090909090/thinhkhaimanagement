using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace ThinhKhaiManagement.Common
{
    public static class StaticMethods
    {
        const string constDateFormat = "Ngày {0}, Tháng {1}, Năm {2}";
        const string constconnectionName = "ThinhKhaiConnection";

        public static string ShowDate()
        {
            return string.Format(constDateFormat,
                DateTime.Today.Day.ToString(),
                DateTime.Today.Month.ToString(),
                DateTime.Today.Year.ToString());
        }

        public static SqlConnection ShowSqlConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings[constconnectionName].ConnectionString);
        }

    }
}
