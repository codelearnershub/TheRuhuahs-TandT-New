using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TheRuhuahs_TandTNew.Interfaces.Service;
using TheRuhuahs_TandTNew.Interfaces.ServiceInterface;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Controllers
{
    public class PackageController : Controller
    {
        private readonly IPackageService _packageService;
        private readonly ITripService _tripService;

        public PackageController(IPackageService packageService, ITripService tripService)
        {
            _packageService = packageService;
            _tripService = tripService;
        }
        
        public IActionResult Index()
        {
            var package = _packageService.GetPackage();
            return View(package);
        }
        [HttpGet]
        public IActionResult Create()
        {
            List<TripViewModel> trip = _tripService.GetTrip();

            List<SelectListItem> listTrip = new List<SelectListItem>();
            foreach (var t in trip)
            {
                SelectListItem item  = new SelectListItem(t.Name, t.Id.ToString());
                listTrip.Add(item);
            }
            ViewBag.Trip = listTrip;
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreatePackageViewModel model)
        {
            _packageService.AddPackage(model);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdatePackageViewModel model)
        {
            _packageService.UpdatePackage(model);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Find(int id)
        {
            _packageService.FindByPackageId(id);
            return RedirectToAction("Index");
        }
        public IActionResult Delete (int id)
        {
            _packageService.DeletePackage(id);
            return RedirectToAction("Index");
        }
    }
}