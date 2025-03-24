

using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {

        protected ProjetoModeloContext Db = new ProjetoModeloContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Dispose()
        {
            if (Db != null)
            {
                Db.Dispose();
            }
            GC.SuppressFinalize(this); // Para evitar que o coletor de lixo finalize a instância depois que já foi descartada.
        }
    }
}
