using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BookingDetailDAO
    {
        private BBP_CSharpContext _context;
        public BookingDetail? Get(int bookingDetailId)
        {
            _context = new BBP_CSharpContext();
            return _context.BookingDetails.Find(bookingDetailId);
        }
        public List<BookingDetail> GetAll()
        {
            _context = new BBP_CSharpContext();
            // Chỉ load được thông tin từ table Book
            // Làm sao load đc info của category, để sau này còn lấy tên category
            // Giống như câu select * from Book B, Category C Where B.CatId = C.CatId
            return _context.BookingDetails.ToList();

            //return _context.BookingDetails.Include(cat => cat.BookCategory).ToList();// inner join sang table BookCategory
                                                                            // qua đặc tính/ thuộc tính Category ở Book
        }
        public void Create(BookingDetail bd)
        {
            _context = new BBP_CSharpContext();
            _context.BookingDetails.Add(bd);
            _context.SaveChanges();

        }
        public void Update(BookingDetail bd)
        {
            _context = new BBP_CSharpContext();
            _context.BookingDetails.Update(bd);
            _context.SaveChanges();

        }
        public void Delete(int bdId)
        {

            var tmp = _context.BookingDetails.FirstOrDefault(b => b.BookingDetailId == bdId);
            if (tmp != null)
            {

                _context.Remove(tmp);
                _context.SaveChanges();
            }

        }
    }
}
