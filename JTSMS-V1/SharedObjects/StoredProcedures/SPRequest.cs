﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedures
{
    public class SPRequest
    {
       public static string Request_add = "call usp_Request_add (@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
       public static string RequestDetail_delete = "call usp_RequestDetail_delete (@p0,@p1,@p2,@p3)";
       public static string Request_submit = "call usp_Request_submit (@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)";
       public static string Request_approve = "call usp_Request_approve (@p0,@p1,@p2,@p3,@p4,@p5)";
       public static string Request_reject = "call usp_Request_reject (@p0,@p1,@p2,@p3,@p4,@p5)";
       public static string Request_close = "call usp_Request_close (@p0,@p1,@p2,@p3)";
       public static string Request_close_deviation = "call usp_Request_close_deviation (@p0,@p1,@p2,@p3,@p4)";


       public static string RequestDetail_get = "call usp_RequestDetail_get (@p0,@p1,@p2,@p3,@p4)";
       public static string RequestDetail_get_by_id = "call usp_RequestDetail_get_by_id (@p0)";
       //public static string RequestDetail_filehash_update = "call usp_RequestDetail_filehash_update (@p0,@p1)";


       public static string Approval_get = "call usp_Approval_get (@p0)";
       public static string Approval_get_current = "call usp_Approval_get_current (@p0)";
    }
}