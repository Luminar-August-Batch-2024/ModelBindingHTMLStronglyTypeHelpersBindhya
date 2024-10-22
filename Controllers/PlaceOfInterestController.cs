using Microsoft.AspNetCore.Mvc;
using ModelBindingHTMLStronglyTypeHelpersBindhya.Repository;

namespace ModelBindingHTMLStronglyTypeHelpersBindhya.Controllers
{
    public class PlaceOfInterestController : Controller
    {
        MockPlaceOfInterestRepository placeOfInterestRepository=new MockPlaceOfInterestRepository();
        public IActionResult Index()
        {
            return View(placeOfInterestRepository.GetPlaces());
        }
    }
}
