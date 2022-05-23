using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Services.Interfaces;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace JTSMS.Controllers
{
    [Authorize]

    public class RequestController : Controller
    {
        private readonly IRequestService requestService;
        private readonly ICommonService commonService;
        private readonly IConfiguration configuration;

        public RequestController(IRequestService requestService, ICommonService commonService, IConfiguration configuration)
        {
            this.requestService = requestService;
            this.commonService = commonService;
            this.configuration = configuration;
        }
        public async Task<IActionResult> Search()
        {
            ViewData["Customer"] = await commonService.Customer_Get();
            ViewData["Station"] = await commonService.Station_get();
            return View();
        }

        public async Task<IActionResult> Request_Add([FromBody] RequestViewModel model)
        {
            var result = await requestService.Request_add(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> RequestDetail_delete([FromBody] RequestViewModel model)
        {
            var result = await requestService.RequestDetail_delete(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> Request_submit([FromBody] RequestViewModel model)
        {
            var result = await requestService.Request_submit(model);
            if (result.StatusCode == 200)
            {
                SentEmail(model);
            }
            return Json(new { results = result });
        }
        //public async Task<IActionResult> Request_approve([FromBody] RequestViewModel model)
        //{
        //    var result = await requestService.Request_approve(model);
        //    return Json(new { results = result });
        //}
        //public async Task<IActionResult> Request_reject([FromBody] RequestViewModel model)
        //{
        //    var result = await requestService.Request_reject(model);
        //    //SentEmail_UpdateStatus(model);
        //    return Json(new { results = result });
        //}
        public async Task<IActionResult> Request_update([FromBody] RequestViewModel model)
        {
            var result = await requestService.Request_approve(model);
            if (result.StatusCode == 200)
            {
                SentEmail_UpdateStatus(model);
            }
            return Json(new { results = result });
        }

        public async Task<IActionResult> Request_close_deviation([FromBody] RequestViewModel model)
        {
            var result = await requestService.Request_close_deviation(model);
            SentEmail_Closure(model);
            return Json(new { results = result });
        }
        public async Task<IActionResult> RequestDetail_get([FromBody] RequestViewModel model)
        {
            ViewData["Customer"] = await commonService.Customer_Get();
            ViewData["Station"] = await commonService.Station_get();
            ViewData["Type"] = await commonService.Type_get();
            var results = await requestService.RequestDetail_get(model);
            return PartialView(results);
        }

        public async Task<IActionResult> RequestDetail_get_by_id(int reqId)
        {
            var results = await requestService.RequestDetail_get_by_id(reqId);
            var Approval_get = await requestService.Approval_get(reqId);
            var Approval_get_current = await requestService.Approval_get_current(reqId);

            ViewData["Approval_get"] = Approval_get;
            ViewData["Approval_get_current"] = Approval_get_current;
            return View(results);
        }

        static string ComputeFileHash(string filename)
        {
            byte[] result;
            SHA1 sha = new SHA1CryptoServiceProvider();
            using (StreamReader sr = new StreamReader(filename))
            {
                result = sha.ComputeHash(sr.BaseStream);
            }
            string retString = "";
            foreach (byte b in result)
            {
                retString += b.ToString("X2"); // Added the "2" to ensure that leading zeros are added to the string. RC 5/9/2013
            }
            return retString;
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file, string filename)
        {
            string uploadFolder = @"\\" + configuration["Server"] + @"\JTSMS\Attachment";

            var fullFilePath = Path.Combine(uploadFolder, filename);
            try
            {
                using (var stream = new FileStream(fullFilePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return Ok(0);
        }

        public async Task<IActionResult> DownloadFile(string fileName)
        {
            //var path = $"{webHostEnvironment.WebRootPath}/media/attachment/" + fileName;
            string path = @"\\" + configuration["Server"] + @"\JTSMS\Attachment\" + fileName;

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
        }
        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }
        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".jts", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformatsofficedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }

        #region Sent Email
        public async void SentEmail(RequestViewModel model)
        {
            string body = string.Empty;

            body += "<div style='border - top:3px solid #22BCE5'>Hi,</div>";
            body += "There is a new request pending at your step";

            body += "<p>You may access <a href='http://vnhcmm0teapp05/jtsms/Request/RequestDetail_get_by_id?reqid=" + model.ReqId + "'>here</a> to get detail</p>";
            body += " <p>This is automatic email, please do not reply</p>    Thanks";
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient("corimc04.corp.JABIL.ORG");
            message.From = new MailAddress("JTSMS@Jabil.com");

            var Approval_get_current = await requestService.Approval_get_current(model.ReqId);
            foreach (var email in Approval_get_current)
            {
                if (email != null)
                {
                    message.To.Add(new MailAddress(email.Email));
                }
            }

            message.CC.Add(new MailAddress(model.UpdatedEmail));
            var configureEmail = configuration["Email:Cc"].Split(';');
            foreach (var email in configureEmail)
            {
                if (email != "")
                {
                    message.CC.Add(new MailAddress(email));
                }
            }
            message.Subject = "New Request Is Pending For Your Approval";
            message.Body = body;
            message.IsBodyHtml = true;
            smtp.Send(message);
        }
        #endregion
        #region SentEmail_UpdateStatus
        public async void SentEmail_UpdateStatus(RequestViewModel model)
        {
            string body = string.Empty;
            body += "<div style='border - top:3px solid #22BCE5'>Hi,</div>";
            //body += "There is a new change request by " + model.CreatedEmail + " as below:";

            body += "<p>You may access <a href='http://vnhcmm0teapp05/jtsms/Request/RequestDetail_get_by_id?reqid=" + model.ReqId + "'>here</a> to get detail</p>";
            body += "<p>This is automatic email, please do not reply</p>    Thanks";
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient("corimc04.corp.JABIL.ORG");
            message.From = new MailAddress("JTSMS@Jabil.com");



            var results = await requestService.RequestDetail_get_by_id(model.ReqId);
            var statusId = results.StatusId;

            switch (statusId)
            {
                case 2: // pending approval
                    var Approval_get_current = await requestService.Approval_get_current(model.ReqId);
                    if (Approval_get_current.Any())
                    {
                        foreach (var email in Approval_get_current)
                        {
                            if (email != null)
                            {
                                message.To.Add(new MailAddress(email.Email));
                            }
                        }
                        message.Subject = "[Pending Approval] New Request Is Pending Approval";
                    }
                    break;
                case 3: //rejected
                    var request_detail = await requestService.RequestDetail_get_by_id(model.ReqId);
                    message.To.Add(new MailAddress(request_detail.CreatedEmail));
                    message.Subject = "[Rejected] Ticket is rejected";

                    break;
                case 4: // approved
                    var UserRole_Get_By_ScriptId = await requestService.Access_UserRole_Get_By_ScriptId(model);
                    if (UserRole_Get_By_ScriptId.Any())
                    {
                        foreach (var email in UserRole_Get_By_ScriptId)
                        {
                            if (email != null)
                            {
                                message.To.Add(new MailAddress(email.UserEmail));
                            }
                        }
                        message.Subject = "[Closed] Ticket is approved and closed";
                    }
                    break;
                default:
                    break;
            }

            message.CC.Add(new MailAddress(model.UpdatedEmail));
            var configureEmail = configuration["Email:Cc"].Split(';');
            foreach (var email in configureEmail)
            {
                if (email != "")
                {
                    message.CC.Add(new MailAddress(email));
                }
            }
            //message.Subject = "[" + model.Action + "]";
            message.Body = body;
            message.IsBodyHtml = true;
            smtp.Send(message);
        }
        #endregion


        #region SentEmail_Closure
        public async void SentEmail_Closure(RequestViewModel model)
        {
            string body = string.Empty;

            body += "<div style='border - top:3px solid #22BCE5'>Hi,</div>";
            body += "Deviation Closed";

            body += "<p>You may access <a href='http://localhost:33714/Request/RequestDetail_get_by_id?reqid=" + model.ReqId + "'>here</a> to get detail</p>";
            body += " <p>This is automatic email, please do not reply</p>    Thanks";
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient("corimc04.corp.JABIL.ORG");
            message.From = new MailAddress("JTSMS@Jabil.com");

            var UserRole_Get_By_ScriptId = await requestService.Access_UserRole_Get_By_ScriptId(model);
            if (UserRole_Get_By_ScriptId.Any())
            {
                foreach (var email in UserRole_Get_By_ScriptId)
                {
                    if (email != null)
                    {
                        message.To.Add(new MailAddress(email.UserEmail));
                    }
                }
                message.Subject = "[Deviation Closed]";
            }
            message.CC.Add(new MailAddress(model.UpdatedEmail));
            var configureEmail = configuration["Email:Cc"].Split(';');
            foreach (var email in configureEmail)
            {
                if (email != "")
                {
                    message.CC.Add(new MailAddress(email));
                }
            }
            message.Body = body;
            message.IsBodyHtml = true;
            smtp.Send(message);
        }
        #endregion
    }
}
