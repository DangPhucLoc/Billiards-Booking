using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BookingDAO
    {
        private BBP_CSharpContext _context;
        public Booking? Get(int bookId)
        {
            _context = new BBP_CSharpContext();
            return _context.Bookings.Find(bookId);
        }

        public List<Booking> GetAll()
        {
            _context = new BBP_CSharpContext();
            // Chỉ load được thông tin từ table Book
            // Làm sao load đc info của category, để sau này còn lấy tên category
            // Giống như câu select * from Book B, Category C Where B.CatId = C.CatId
            return _context.Bookings.ToList();

            //return _context.Books.Include(cat => cat.BookCategory).ToList();// inner join sang table BookCategory
                                                                            // qua đặc tính/ thuộc tính Category ở Book
        }
        public void Create(Booking booking)
        {
            _context = new BBP_CSharpContext();
            _context.Bookings.Add(booking);
            _context.SaveChanges();

        }
        public void Update(Booking booking)
        {
            _context = new BBP_CSharpContext();
            _context.Bookings.Update(booking);
            _context.SaveChanges();

        }
        public void Delete(int bookingId)
        {

            var tmp = _context.Bookings.FirstOrDefault(b => b.BookingId == bookingId);
            if (tmp != null)
            {

                _context.Remove(tmp);
                _context.SaveChanges();
            }

        }
    }
}
