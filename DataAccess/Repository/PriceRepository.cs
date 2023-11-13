using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    internal class PriceRepository
    {
        PriceDAO _priceDAO = new PriceDAO();
        public List<Price> GetAllPrices() => _priceDAO.getAllPrice();
        public Price GetPriceByTableTypeIDAndSlotID(int tableTypeID, int slotID) => _priceDAO.getPriceByTableTypeAndSlotID(tableTypeID, slotID);
        public List<Price> GetPricesByTableTypeID(int tableTypeID) => _priceDAO.getPriceByTableTypeID(tableTypeID);
        public List<Price> GetPricesBySlotID(int slotID) => _priceDAO.getPriceBySlotID(slotID);
        public void AddNewPrice(Price p) => _priceDAO.addPrice(p);
        
        public void UpdatePrice(Price p) => _priceDAO.updatePrice(p);
    }
}
