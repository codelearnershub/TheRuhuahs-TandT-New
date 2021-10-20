using System;
using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandTNew.Interfaces.Repositories;
using TheRuhuahs_TandTNew.Interfaces.Service;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;
using static TheRuhuahs_TandTNew.Models.ViewModel.CreateBookingViewModel;

namespace TheRuhuahs_TandTNew.Services
{
    public class BookingService : IBookingService
    
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        private string GenerateReference()
        {

            Random random = new Random();

            string numberInReg = random.Next(0, 1000000).ToString("000000");

            return $"{GenerateRandomCharacter()}{GenerateRandomCharacter()}{numberInReg}{GenerateRandomCharacter()}";
            
        }

        private static char GenerateRandomCharacter()
        {
            Random random = new Random();
            int randomCharNum = random.Next(65, 91);
            char letter = (char)randomCharNum;
            return letter;
        }

        private bool ReferenceExist(List<BookingViewModel> allBookings, string reference)
        {
            foreach(var b in allBookings)
            {
                if (b.Reference.Equals(reference))
                {
                    return true;
                }
            }
            return false; 
        }
        
            public Booking AddBooking(CreateBookingViewModel model)
        {
        
            List<BookingViewModel> allBookings = GetBooking();
            string reference = "";
            do
            {
                reference = GenerateReference();
            } 
            while (ReferenceExist(allBookings, reference));
            var booking = new Booking
            {
                UserId =  model.UserId,
                NumberOfTouristToBoard= model.NumberOfTouristToBoard,
                Reference = reference,
                CreatedAt = DateTime.Now,
                // Package = model.Package,

            };
            
            return _bookingRepository.AddBooking(booking);
        }
        public Booking FindByBookingId(int id)
        {
            return _bookingRepository.FindByBookingId(id);
        }

        public void DeleteBooking(int id)
        {
            _bookingRepository.DeleteBooking(id);
        }

        public Booking UpdateBooking(UpdateBookingViewModel model)
        {   List<BookingViewModel> allBookings = GetBooking();
            string reference = "";
            do
            {
                reference = GenerateReference();
            } 
            while (ReferenceExist(allBookings, reference));
                
             var booking = new Booking
            {
                Id = model.Id,
                NumberOfTouristToBoard = model.NumberOfTouristToBoard,
                Reference = reference,
                Amount = model.Amount,
                CreatedAt = DateTime.Now
               
            };
            return _bookingRepository.UpdateBooking(booking);


        }
        public List<BookingViewModel> GetBooking()
        {
            var booking = _bookingRepository.GetBooking().Select(c => new BookingViewModel
            {
                Id = c.Id,
                NumberOfTouristToBoard = c.NumberOfTouristToBoard,
                CreatedAt = c.CreatedAt,
                Reference = c.Reference,
                Package = c.Package,`
                
                Amount = c.Amount
               
            }).ToList();

            return booking;
        
        }
    }

}