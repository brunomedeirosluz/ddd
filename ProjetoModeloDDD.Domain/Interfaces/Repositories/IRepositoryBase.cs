﻿using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{

    // RepositoryBase faz CRUD padrão
    public interface IRepositoryBase<TEntity> where TEntity : class
    {

        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();

    }
}

