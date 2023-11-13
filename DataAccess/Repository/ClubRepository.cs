using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ClubRepository
    {
        private ClubDAO clubDAO = new ClubDAO();
        private ClubDAO _clubDAO = new ClubDAO();

        public List<Club> getAllClubs() => _clubDAO.GetAll();

        public void addClub(Club club) => _clubDAO.Create(club);

        public void deleteClub(int clubId) => _clubDAO.Delete(clubId);

        public void updateClub(Club club) => _clubDAO.Update(club);

        public Club? GetClub(int clubId) => _clubDAO.Get(clubId);
    }
}
