using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TableDAO
    {
        private static TableDAO instance = null;
        public static readonly object instanceLock = new object();
        private TableDAO() { }
        public static TableDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TableDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Table> GetAll()
        {
            using var db = new BBP_CSharpContext();
            return db.Tables.Include(t => t.TableType).ToList();
        }

        public Table? GetById(int id)
        {
            return GetAll().FirstOrDefault(t => t.TableId == id);
        }

        public void AddTable(Table table)
        {
            using var db = new BBP_CSharpContext();
            db.Tables.Add(table);
            db.SaveChanges();
        }

        public void UpdateTable(Table table)
        {
            using var db = new BBP_CSharpContext();
            db.Tables.Update(table);
            db.SaveChanges();
        }

        public void DeleteTable(Table table)
        {
            using var db = new BBP_CSharpContext();
            db.Tables.Remove(table);
            db.SaveChanges();
        }
    }
}
