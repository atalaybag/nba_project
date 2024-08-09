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
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            List<Teams> plist = new List<Teams>();
            using (var client = new HttpClient())
            {

                var responsetalk = client.GetAsync("https://localhost:44334/api/Teams");
                var result = responsetalk.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    var player = readTask.Result;
                    plist = JsonConvert.DeserializeObject<List<Teams>>(player);

                }
            }
            return View(plist);
        }
        public IActionResult East()
        {
            List<Teams> plist = new List<Teams>();
            using (var client = new HttpClient())
            {

                var responsetalk = client.GetAsync("https://localhost:44334/api/Teams");
                var result = responsetalk.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    var player = readTask.Result;
                    plist = JsonConvert.DeserializeObject<List<Teams>>(player);

                }
            }
            return View(plist);
        }
        public IActionResult West()
        {
            List<Teams> plist = new List<Teams>();
            using (var client = new HttpClient())
            {

                var responsetalk = client.GetAsync("https://localhost:44334/api/Teams");
                var result = responsetalk.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    var player = readTask.Result;
                    plist = JsonConvert.DeserializeObject<List<Teams>>(player);

                }
            }
            return View(plist);
        }
    }
}
