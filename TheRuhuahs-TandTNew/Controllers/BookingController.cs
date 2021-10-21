using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using TheRuhuahs_TandTNew.Interfaces.Service;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;
using static TheRuhuahs_TandTNew.Models.ViewModel.CreateBookingViewModel;

namespace TheRuhuahs_TandTNew.Controllers
{
    public class BookingController : Controller
    {
        public readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        public IActionResult Index()
        {
            var booking = _bookingService.GetBooking(); 
            return View(booking);
        }
        // [Authorize]
        [HttpGet]
       
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateBookingViewModel model)
        {
             int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value); 

           Booking booking = new Booking()
           {
              UserId = userId,
              NumberOfTouristToBoard = model.NumberOfTouristToBoard,
              Package = model.Package,
              Amount = model.Amount

           };
            _bookingService.AddBooking(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update()
        {   
            return View();
        }
        
        [HttpPost]
        public IActionResult Update(UpdateBookingViewModel model)
        {
            Booking booking = new Booking()
           {
              NumberOfTouristToBoard = model.NumberOfTouristToBoard,
              Package = model.Package,
              Amount = model.Amount

           };
            _bookingService.UpdateBooking(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Find()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Find(int id)
        {
            _bookingService.FindByBookingId(id);
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
        
            var booking = _bookingService.FindByBookingId(id);
            if (booking == null)
            {
                return NotFound();
            }
            _bookingService.DeleteBooking(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Details(int id)
        {
            var booking = _bookingService.FindByBookingId(id);
            if (booking == null)
            {
                return NotFound();
            }
            return View("Details");
        }
    }
    // public Booking UpdateBooking(UpdateBookingViewModel model)
        // {
        //     var booking = _bookingRepository.FindByBookingId(model.Id);
        //     if (booking == null)
        //     {
        //         return null;
        //     }

        //     booking.Id = model.Id;
        //     booking.NumberOfTouristToBoard = model.NumberOfTouristToBoard;
        //     booking.Amount = model.Amount;
        //     booking.Package = model.Package;
        //     booking.CreatedAt = DateTime.Now;

        //     return _bookingRepository.UpdateBooking(booking);
        // }
}