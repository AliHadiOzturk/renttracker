using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class Repository<T> where T : class
    {
        private readonly RentTrackerContext context;
        private readonly DbSet<T> _entity;
        private readonly UnitOfWork unitOfWork;
        public Repository()
        {
            unitOfWork = new UnitOfWork();
            context = new RentTrackerContext();
            _entity = context.Set<T>();
        }
        public List<T> getAll()
        {
            return _entity.ToList();
        }
        public T getById(int id)
        {
            return _entity.Find(id);
        }
        public T add(T entity)
        {
            return _entity.Add(entity);
        }
        public void delete(T entity)
        {

        }
    }
}
