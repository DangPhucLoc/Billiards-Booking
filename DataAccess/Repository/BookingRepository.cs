using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BookingRepository
    {
        private BookingDAO _bookingDAO = new BookingDAO();
        
        public List<Booking> getAllBookings() => _bookingDAO.GetAll();

        public void addBooking(Booking booking) => _bookingDAO.Create(booking);

        public void deleteBooking(int bookingId) => _bookingDAO.Delete(bookingId);

        public void updateBooking(Booking booking) => _bookingDAO.Update(booking);

        public Booking? GetBooking(int bookingId) => _bookingDAO.Get(bookingId);
    }
}
