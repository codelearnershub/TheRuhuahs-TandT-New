using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TheRuhuahs_TandTNew.Interfaces.ServiceInterface;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Controllers
{
    public class TripController : Controller
    {
       private readonly ITripService _tripService;
       private readonly ITouristCenterService _touristCenterService;

        public TripController(ITripService tripService, ITouristCenterService touristCenterService)
        {
            _tripService = tripService;
            _touristCenterService = touristCenterService;
        }

        public IActionResult Index()
        {
            
            var trip = _tripService.GetTrip();
            return View(trip);
        }
        // [ValidateAntiForgeryToken]
        [HttpGet]
        public IActionResult Create()
        {
            List<TouristCenterViewModel> touristCenter = _touristCenterService.GetTouristCenter();

            List<SelectListItem> listTouristCenter = new List<SelectListItem>();
            foreach (var tourist in touristCenter)
            {
                SelectListItem item  = new SelectListItem(tourist.Name, tourist.Id.ToString());
                listTouristCenter.Add(item);
            }
            ViewBag.TouristCenter = listTouristCenter;
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateTripViewModel model)
        {
            _tripService.AddTrip(model);

            return RedirectToAction("Index");
        }
        // [ValidateAntiForgeryToken]
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