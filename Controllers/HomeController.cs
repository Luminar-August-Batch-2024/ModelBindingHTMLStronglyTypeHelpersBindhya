using Microsoft.AspNetCore.Mvc;
using ModelBindingHTMLStronglyTypeHelpersBindhya.Models;
using ModelBindingHTMLStronglyTypeHelpersBindhya.Repository;
using System.Diagnostics;

namespace ModelBindingHTMLStronglyTypeHelpersBindhya.Controllers
{
    public class HomeController : Controller
    {
        MockPlaceOfInterestRepository mockPlaceOfInterestRepository= new MockPlaceOfInterestRepository();   

        public IActionResult Index()
        {
            List<PlaceOfInterest> placeOfInterests = mockPlaceOfInterestRepository.GetPlaces();
            return View(placeOfInterests);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
