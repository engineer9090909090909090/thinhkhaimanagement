using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ThinhKhaiManagement.Common
{
    public static class StaticMethods
    {
        const string constDateFormat = "Ngày {0}, Tháng {1}, Năm {2}";
        const string constTimeFormat = "{0} {1}";
        const string constconnectionName = "ThinhKhaiConnection";

        public static string ShowDate()
        {
            return string.Format(constDateFormat,
                DateTime.Today.Day.ToString(),
                DateTime.Today.Month.ToString(),
                DateTime.Today.Year.ToString());
        }

        public static string ShowTime()
        {
            return string.Format(constTimeFormat,
                DateTime.Now.ToString("hh:mm:ss"),
                DateTime.Now.ToString("tt"));
        }

        public static SqlConnection ShowSqlConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings[constconnectionName].ConnectionString);
        }
    }

    #region enums

    public enum CheckMethods
    { 
        nullOrEmpty = 0,
        isNull = 1,
        isEmpty = 2,
        lessThanZero
    }

    #endregion
}
