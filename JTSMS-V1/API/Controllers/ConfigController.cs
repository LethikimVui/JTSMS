using API.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SharedObjects.Commons;
using SharedObjects.StoredProcedures;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IConfiguration configuration;

        public ConfigController(ApplicationDbContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        [HttpGet("WatchDogConfig_get")]
        [Obsolete]
        public async Task<List<VConfig>> WatchDogConfig_get()
        {
            var results = await context.Query<VConfig>().AsNoTracking().FromSql(SPConfig.WatchDogConfig_get).ToListAsync();
            return results;
        }
        [HttpPost("WatchDogConfig_insert")]
        [Obsolete]
        public async Task<IActionResult> WatchDogConfig_insert(ConfigViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPConfig.WatchDogConfig_insert, model.CustId, model.ProcessStep, model.RouteStep, model.TesterName, model.TesterPcName, model.EquipmentId, model.PlatformId, model.TestTime, model.Trigger, model.CreatedBy, model.CreatedName, model.CreatedEmail);
                return Ok(new ResponseResult(200, "WatchDogConfig_insert Added Successfully"));
                //if (!context.AccessUserRole.Where(x => (x.Ntlogin == model.Ntlogin) && (x.CustId == model.CustId) && (x.IsActive == 1)).ToList().Any())
                //{
                //    await context.Database.ExecuteSqlCommandAsync(SPAdmin.Access_UserRole_insert, model.Ntlogin, model.UserName, model.UserEmail, model.RoleId, model.PlantId, model.CustId, model.CreatedBy, model.CreatedName, model.CreatedEmail);
                //    return Ok(new ResponseResult(200, "User Added Successfully"));
                //}
                //else
                //{
                //    return Conflict(new ResponseResult(400, "User already existing"));
                //}
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }

      
    }
}
