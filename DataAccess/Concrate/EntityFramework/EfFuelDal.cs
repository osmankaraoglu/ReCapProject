using DataAccess.Abstract;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfFuelDal : IFuelDal
    {
        public void Add(Fuel entity)
        {
            using (ReCapProjectDBContext context = new ReCapProjectDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Fuel entity)
        {
            using (ReCapProjectDBContext context = new ReCapProjectDBContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Fuel Get(Expression<Func<Fuel, bool>> filter)
        {
            using (ReCapProjectDBContext context = new ReCapProjectDBContext())
            {
                return context.Set<Fuel>().SingleOrDefault(filter);
            }
        }

        public List<Fuel> GetAll(Expression<Func<Fuel, bool>> filter = null)
        {
            using (ReCapProjectDBContext context = new ReCapProjectDBContext())
            {
                return filter == null ? context.Set<Fuel>().ToList() : context.Set<Fuel>().Where(filter).ToList();
            }

        }

        public void Update(Fuel entity)
        {
            using (ReCapProjectDBContext context = new ReCapProjectDBContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
