using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DTO;

namespace DAL
{
    public class LogDAO: PostContext
    {
        public static void AddLog(int ProcessType, string TableName, int ProcessID)
        {
            LOGTABLE log = new LOGTABLE();
            log.UserID = UserStatic.UserID;
            log.ProcessType = ProcessType;
            log.ProcessID = ProcessID;
            log.ProcessCategoryType = TableName;
            log.ProcessDate = DateTime.Now;
            log.IPAddress = HttpContext.Current.Request.UserHostAddress;
            db.LOGTABLEs.Add(log);
            db.SaveChanges();

        }
    }
}
