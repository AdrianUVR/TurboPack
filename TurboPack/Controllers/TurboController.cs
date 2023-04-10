using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace TurboPack.Controllers
{
    public class TurboController : Controller
    {
        //public ActionResult TurboGet()
        //{
        //    Models.Turbo turbo = new Models.Turbo();
        //    using (var client = new HttpClient())
        //    {


        //        var resdponsetask = client.GetAsync("https://randomuser.me/api/");
        //        resdponsetask.Wait();
        //        var result = resdponsetask.Result;

        //        if (result.IsSuccessStatusCode)
        //        {
        //            var readTask = result.Content.ReadAsStringAsync();
        //            dynamic resultJSON = JObject.Parse(readTask.Result.ToString());
        //            readTask.Wait();
        //            turbo.Turbos = new List<object>();
        //            foreach (var resultitem in resultJSON.results)
        //            {
        //                Models.Turbo turboItems = new Models.Turbo();

        //                turboItems.sexo = resultitem.gender;
        //                turboItems.Nombre = resultitem.first;
        //                turboItems.Imagen = resultitem.medium;
        //                turboItems.Correo = resultitem.email;
        //                turboItems.Ciudad = resultitem.city;
        //                turbo.Turbos.Add(turboItems);
        //            }

        //        }

        //    }
        //    return View(turbo);
        //}

        [HttpGet]
        public ActionResult GetAll()
        {
            return View();

        }
    }
}
