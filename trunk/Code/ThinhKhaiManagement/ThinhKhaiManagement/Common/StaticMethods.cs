using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Collections.ObjectModel;
using DatabaseAccesser;

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

        public static Dictionary<string,decimal> GiaVangHienTai()
        { 
            DataAccess dataaccess = new DataAccess();
            DataTable tb = (DataTable)dataaccess.Access(ShowSqlConnection(),
                StoreProcedureNames.constGiaVang_ShowLasted,
                new Collection<KeyValuePair<object, int>>(),
            (int)ExecuteType.Query);

            if(tb.Rows.Count > 0)
            {
                Dictionary<string, decimal> rs = new Dictionary<string, decimal> { 
                    {Constants.constNuTrang,(decimal)tb.Rows[0][7]},
                    {Constants.const75,(decimal)tb.Rows[0][9]},
                    {Constants.const70,(decimal)tb.Rows[0][11]}
                };
                return rs;
            }

            Dictionary<string, decimal> blankrs = new Dictionary<string, decimal> { 
                    {Constants.constNuTrang,0},
                    {Constants.const75,0},
                    {Constants.const70,0}
                };
            return blankrs;
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
