using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebDemo.Interface;
using WebDemo.Models;
using WebDemo.Service;

namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {

        private readonly IData Datas;
        public HomeController()
        {
            Datas = new DataService();
        }

        public IActionResult Index()
        {
           
            return View();
        }
        [HttpGet]
        public JsonResult GetData()
        {
            List<DataModel>? datas = Datas?.GetDatas()?.Result;
            return Json(datas);
        }
    }
}