using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedures
{
    public class SPCommon
    {
        public static string Customer_get = "call usp_Customer_get";
        public static string Station_get = "call usp_Station_get";
        public static string Type_get = "call usp_Type_get";
        public static string Access_UserRole_Get_By_ScriptId = "call usp_Access_UserRole_Get_By_ScriptId (@p0)";
    }
}
