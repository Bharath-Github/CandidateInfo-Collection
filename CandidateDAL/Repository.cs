using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using CandidateDAL;

namespace CandidateDAL
{
    public class Repository<T>:IRepository<T> where T : class
    {
        private CandidateInfoEntities db = null;
        
        private DbSet<T> table = null;
     
        public Repository()
        {
            this.db = new CandidateInfoEntities();
            table = db.Set<T>();
        }

        public Repository(CandidateInfoEntities db)
        {
            this.db = db;
            table = db.Set<T>();
        }
     
        public IEnumerable<T> SelectAll()
        {
            return table.ToList();
        }
     
        public T SelectByID(object id)
        {
            return table.Find(id);
        }
     
        public void Insert(T obj)
        {
            table.Add(obj);
        }
     
        public void Update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }
     
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
     
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
