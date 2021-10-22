using Microsoft.AspNetCore.Mvc;
using TheRuhuahs_TandTNew.Interfaces.ServiceInterface;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Controllers
{
    public class TripController : Controller
    {
       private readonly ITripService _tripService;

        public TripController(ITripService tripService)
        {
            _tripService = tripService;
        }

        public IActionResult Index()
        {
            var trip = _tripService.GetTrip();
            return View(trip);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTrip(CreateTripViewModel model)
        {
            _tripService.AddTrip(model);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateTripViewModel model)
        {
            _tripService.UpdateTrip(model);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Find(int id)
        {
            _tripService.FindByTripId(id);
            return RedirectToAction("Index");
        }
        public IActionResult Delete (int id)
        {
            _tripService.DeleteTrip(id);
            return RedirectToAction("Index");
        } 
    }
}