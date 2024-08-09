using Microsoft.AspNetCore.Mvc;
using NbaProje.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NbaProje.Controllers.AdminController
{
    public class ProductController : Controller
    {
        public IActionResult Buy()
        {
            return View();
        }
        public IActionResult Store()
        {
            List<Products> plist = new List<Products>();
            using (var client = new HttpClient())
            {

                var responsetalk = client.GetAsync("https://localhost:44334/api/Products");
                var result = responsetalk.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    var player = readTask.Result;
                    plist = JsonConvert.DeserializeObject<List<Products>>(player);

                }
            }
            return View(plist);
        }
    }
}
