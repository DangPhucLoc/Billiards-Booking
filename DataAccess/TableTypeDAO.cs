using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TableTypeDAO
    {
        private static TableTypeDAO instance = null;
        public static readonly object instanceLock = new object();
        private TableTypeDAO() { }
        public static TableTypeDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TableTypeDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TableType> GetAll()
        {
            using var db = new BBP_CSharpContext();
            return db.TableTypes.ToList();
        }

        public void AddTableType(TableType tableType)
        {
            using var db = new BBP_CSharpContext();
            db.TableTypes.Add(tableType);
            db.SaveChanges();
        }

        public void UpdateTableType(TableType tableType)
        {
            using var db = new BBP_CSharpContext();
            db.TableTypes.Update(tableType);
            db.SaveChanges();
        }

        public void DeleteTableType(TableType tableType)
        {
            using var db = new BBP_CSharpContext();
            db.TableTypes.Remove(tableType);
            db.SaveChanges();
        }
    }
}
