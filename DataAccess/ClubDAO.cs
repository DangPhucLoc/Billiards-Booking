using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class ClubDAO
    {
        private BBP_CSharpContext _context;
        public Club? Get(int clubId)
        {
            _context = new BBP_CSharpContext();
            return _context.Clubs.Find(clubId);
        }

        public List<Club> GetAll()
        {
            _context = new BBP_CSharpContext();
            // Chỉ load được thông tin từ table Book
            // Làm sao load đc info của category, để sau này còn lấy tên category
            // Giống như câu select * from Book B, Category C Where B.CatId = C.CatId
            return _context.Clubs.ToList();

            //return _context.Books.Include(cat => cat.BookCategory).ToList();// inner join sang table BookCategory
                                                                            // qua đặc tính/ thuộc tính Category ở Book
        }
        public void Create(Club club)
        {
            _context = new BBP_CSharpContext();
            _context.Clubs.Add(club);
            _context.SaveChanges();

        }
        public void Update(Club club)
        {
            _context = new BBP_CSharpContext();
            _context.Clubs.Update(club);
            _context.SaveChanges();

        }
        public void Delete(int clubId)
        {

            var tmp = _context.Clubs.FirstOrDefault(b => b.ClubId == clubId);
            if (tmp != null)
            {

                _context.Remove(tmp);
                _context.SaveChanges();
            }

        }
    }
}
