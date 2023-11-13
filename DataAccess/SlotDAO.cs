using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class SlotDAO
    {
        BBP_CSharpContext _dbcontext = new BBP_CSharpContext();
        public SlotDAO() { }

        public List<Slot> getAllSlots()
        {
            return _dbcontext.Slots.ToList();
        }
        public Slot getSlotByID(int slotID)
        {
            return _dbcontext.Slots.Find(slotID);
        }
        public Slot getSlotByStartTime(int time) {
            return _dbcontext.Slots.Find(time);
        }
        public Slot getSlotByEndTime(int time)
        { 
            return _dbcontext.Slots.Find(time);
        }
        public void addSlot(Slot slot)
        {
            _dbcontext.Slots.Add(slot);
            _dbcontext.SaveChanges();
        }
        public void removeSlot(int slotID)
        {
            _dbcontext.Remove(slotID);
            _dbcontext.SaveChanges();
        }
        public void updateSlot(Slot slot)
        {
            _dbcontext.Slots.Update(slot);
            _dbcontext.SaveChanges();    
        }
    }
}
