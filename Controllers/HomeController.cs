using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Index()
      {
      return View();
      }

      [Route("/parcel")]
      public ActionResult Parcels()
      {
        ParcelVariable myParcelVariable = new ParcelVariable();
        myParcelVariable.SetHeight(int.Parse(Request.Query["height"]));
        myParcelVariable.SetWidth(int.Parse(Request.Query["width"]));
        myParcelVariable.SetLength(int.Parse(Request.Query["length"]));
        myParcelVariable.SetWeight(int.Parse(Request.Query["weight"]));
        myParcelVariable.SetDistance(int.Parse(Request.Query["distance"]));


        return View(myParcelVariable);
      }

    }
}
