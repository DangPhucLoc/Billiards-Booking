using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BookingDetailRepository
    {
        private BookingDetailDAO _bookingDetailDAO = new BookingDetailDAO();

        public List<BookingDetail> getAllBookingDetails() => _bookingDetailDAO.GetAll();
        public List<BookingDetail> GetBookingDetailsByBookingId(int bookingID) => _bookingDetailDAO.getDbByBookingId(bookingID);

        public void addBB(BookingDetail bd) => _bookingDetailDAO.Create(bd);

        public void deleteBD(int bdId) => _bookingDetailDAO.Delete(bdId);

        public void updateBD(BookingDetail bd) => _bookingDetailDAO.Update(bd);

        public BookingDetail? GetBD(int bdId) => _bookingDetailDAO.Get(bdId);
    }
}
