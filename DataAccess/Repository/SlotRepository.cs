using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    internal class SlotRepository
    {   
        SlotDAO _slotDAO = new SlotDAO();
        public List<Slot> GetAllSlots() => _slotDAO.getAllSlots();
        public Slot GetSlotByID(int slotID) => _slotDAO.getSlotByID(slotID);
        public Slot GetSlotByStartTime(int time) => _slotDAO.getSlotByStartTime(time);
        
        public Slot GetSlotByEndTime(int time) => _slotDAO.getSlotByEndTime(time);
        
        public void AddSlot(Slot slot) => _slotDAO.addSlot(slot);
        
        public void RemoveSlot(int slotID) => _slotDAO.removeSlot(slotID);
        
        public void UpdateSlot(Slot slot) => _slotDAO.updateSlot(slot);
        
    }
}
