using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using NbaProje.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NbaProje.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AccountController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var requesContent = new StringContent(JsonSerializer.Serialize(model),Encoding.UTF8,"application/json");
            var response = await client.PostAsync("https://localhost:44334/api/Auth/SignIn",requesContent);

            if (response.IsSuccessStatusCode)
            {
               var jsonData =  await response.Content.ReadAsStringAsync(); // json data desarileze..
                var tokenModel = JsonSerializer.Deserialize<JswResponseModel>(jsonData,new JsonSerializerOptions 
                {
                    PropertyNamingPolicy=JsonNamingPolicy.CamelCase
                });

                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                var token = handler.ReadJwtToken(tokenModel?.Token);

                if(token != null)
                {
                    //var roles =   token.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value);
                    //  if (roles.Contains("Admin"))
                    //  {

                    //  }
                    ClaimsIdentity identity = new ClaimsIdentity(token.Claims,JwtBearerDefaults.AuthenticationScheme);
                    var authProps = new AuthenticationProperties
                    {
                        ExpiresUtc = tokenModel?.ExpireDate, // token bitiş tarihi
                        IsPersistent = true,  // token bitmedi sürece hatırlasın.
                    };


                   await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(identity), authProps);
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ModelState.AddModelError("", "Wrong Username or Password");
                    return View(model);
                }

            }
                
            else
            {
                ModelState.AddModelError("", "Wrong Username or Password");
                return View(model);
            }


           
        }
    }
}
