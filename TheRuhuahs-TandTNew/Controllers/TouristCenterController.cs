using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using TheRuhuahs_TandTNew.Interfaces.ServiceInterface;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Controllers
{
    public class TouristCenterController : Controller
    {
       private readonly ITouristCenterService _touristCenterService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TouristCenterController(ITouristCenterService touristCenterService,IWebHostEnvironment webHostEnvironment)
        {
            _touristCenterService = touristCenterService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var touristCenter = _touristCenterService.GetTouristCenter();
            return View(touristCenter);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateTouristCenterViewModel model)
        {
            var files = HttpContext.Request.Form.Files;
            string webRootPath = _webHostEnvironment.WebRootPath;

            if (model.Id == 0)
            {
                //creating
                string upload = webRootPath + WC.ImagePath;
                string fileName = Guid.NewGuid().ToString();
                string extension = Path.GetExtension(files[0].FileName);
                string filePath = fileName + extension;

                using ( var fileStream = new FileStream(Path.Combine(upload,filePath ),FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                model.Image = fileName + extension;

                _touristCenterService.AddTouristCenter(model);
            }
          

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateTouristCenterViewModel model)
        {
            _touristCenterService.UpdateTouristCenter(model);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Find(int id)
        {
            _touristCenterService.FindByTouristCenterId(id);
            return RedirectToAction("Index");
        }
        public IActionResult Delete (int id)
        {
            _touristCenterService.DeleteTouristCenter(id);
            return RedirectToAction("Index");
        } 
    }
}