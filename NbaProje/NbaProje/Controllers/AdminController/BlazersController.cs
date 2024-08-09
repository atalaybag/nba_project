using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NbaProje.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NbaProje.Controllers
{
    public class BlazersController : Controller
    {
        public IActionResult Team()
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
        public IActionResult BlazersInfo()
        {
            return View();
        }
        public IActionResult Blazers()
        {
            List<Players> plist = new List<Players>();
            using (var client = new HttpClient())
            {

                var responsetalk = client.GetAsync("https://localhost:44334/api/Player");
                var result = responsetalk.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    var player = readTask.Result;
                    plist = JsonConvert.DeserializeObject<List<Players>>(player);

                }
            }
            return View(plist);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Guncelle(int id)
        {
            Players dc = new Players();
            var client = new HttpClient();
            var responsetask = client.GetAsync("https://localhost:44334/api/Player/" + id);
            var result = responsetask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readtask = result.Content.ReadAsStringAsync();
                var davetresult = readtask.Result;
                dc = JsonConvert.DeserializeObject<Players>(davetresult);
            }
            return View(dc);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Guncelle(Players players)
        {
            var client = new HttpClient();
            var jsonhotel = JsonConvert.SerializeObject(players);
            StringContent icerik = new StringContent(jsonhotel, Encoding.UTF8, "application/json");
            var response = client.PutAsync("https://localhost:44334/api/Player/", icerik);
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Blazers");
            }
            return View(players);
        }
        public IActionResult Detay(int id)
        {
            Players players = new Players();
            var client = new HttpClient();
            var responsetask = client.GetAsync("https://localhost:44334/api/Player/" + id);
            var result = responsetask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readtask = result.Content.ReadAsStringAsync();
                var hotelresult = readtask.Result;
                players = JsonConvert.DeserializeObject<Players>(hotelresult);

            }
            return View(players);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(Players players)
        {
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(players);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:44334/api/Player/", content);
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Blazers");
            }
            return View(players);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Sil(int id)
        {
            var client = new HttpClient();
            var response = client.DeleteAsync("https://localhost:44334/api/Player/" + id);
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Blazers");
            }
            return NotFound();
        }
    }
}
