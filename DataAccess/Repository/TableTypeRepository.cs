using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class TableTypeRepository
    {
        public List<TableType> GetAll() => TableTypeDAO.Instance.GetAll();

        public void AddTableType(TableType tableType) => TableTypeDAO.Instance.AddTableType(tableType);

        public void UpdateTableType(TableType tableType) => TableTypeDAO.Instance.UpdateTableType(tableType);

        public void DeleteTableType(TableType tableType) => TableTypeDAO.Instance.DeleteTableType(tableType);
    }
}
