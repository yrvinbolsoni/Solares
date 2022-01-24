using Data.DBConfiguration.EFcore;
using Domain.Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SolaresContext _context;

        public RepositoryBase(SolaresContext Context)
        {
            _context = Context;
        }


        public virtual IEnumerable<TEntity> GetAllPag(int skip = 0, int take = 25)
        {
            return _context.Set<TEntity>()
                .Skip(skip)
                .Take(take)
                .ToList();
        }

        public virtual void Add(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public virtual TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>()
                .ToList();
        }



        public virtual void Update(TEntity obj)
        {

            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public virtual void Remove(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public virtual void Dispose()
        {
            _context.Dispose();
        }


    }
}
