using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class PriceDAO
    {
        BBP_CSharpContext _dbcontext =  new BBP_CSharpContext();
        public PriceDAO() { }
        public List<Price> getAllPrice()
        {
            return _dbcontext.Prices.Include(p => p.Slot).Include(p => p.TableType).ToList();
        }
        public List<Price> getPriceBySlotID(int slotID) 
        {
            return _dbcontext.Prices
                    .Where(price => price.SlotId == slotID)
                    .ToList();
        }
        public List<Price> getPriceByTableTypeID(int TableTypeID)
        {
            return _dbcontext.Prices
                     .Where(price => price.TableTypeId == TableTypeID)
                     .ToList();
        }
        public Price getPriceByTableTypeAndSlotID(int tableTypeID, int slotID)
        {
            return _dbcontext.Prices.SingleOrDefault(p => p.TableTypeId == tableTypeID && p.SlotId == slotID);
        }
        public void addPrice(Price price)
        {
            _dbcontext.Prices.Add(price);
            _dbcontext.SaveChanges();
        }
       
        public void updatePrice(Price price) 
        {
            _dbcontext.Prices.Update(price);
            _dbcontext.SaveChanges();
        }
    }
}
