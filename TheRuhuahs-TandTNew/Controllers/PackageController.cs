using Microsoft.AspNetCore.Mvc;
using TheRuhuahs_TandTNew.Interfaces.Service;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Controllers
{
    public class PackageController : Controller
    {
        private readonly IPackageService _packageService;

        public PackageController(IPackageService packageService)
        {
            _packageService = packageService;
        }
        
        public IActionResult Index()
        {
            var package = _packageService.GetPackage();
            return View(package);
        }
        [HttpGet]
        public IActionResult Create()
        {
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