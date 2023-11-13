using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class TableRepository
    {
        public List<Table> GetAll() => TableDAO.Instance.GetAll();

        public Table? GetTableById(int id) => TableDAO.Instance.GetById(id);

        public void AddTable(Table table) => TableDAO.Instance.AddTable(table);

        public void UpdateTable(Table table) => TableDAO.Instance.UpdateTable(table);

        public void DeleteTable(Table table) => TableDAO.Instance.DeleteTable(table);
    }
}
