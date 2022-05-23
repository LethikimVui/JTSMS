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

    public class ConfigController : Controller
    {
        private readonly IConfigService configService;
        private readonly ICommonService commonService;
        private readonly IConfiguration configuration;

        public ConfigController(IConfigService configService, ICommonService commonService, IConfiguration configuration)
        {
            this.configService = configService;
            this.commonService = commonService;
            this.configuration = configuration;
        }
        public async Task<IActionResult> Search()
        {
            ViewData["Customer"] = await commonService.Customer_Get();
            ViewData["Station"] = await commonService.Station_get();
            return View();
        }

        public async Task<IActionResult> Insert()
        {
            ViewData["Customer"] = await commonService.Customer_Get();
            // ViewData["Station"] = await commonService.Station_get();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] ConfigViewModel model)
        {
            var result = await configService.WatchDogConfig_insert(model);
            return Json(new { results = result });
        }

    }
}
