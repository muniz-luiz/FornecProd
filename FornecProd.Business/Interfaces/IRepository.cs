﻿using FornecProd.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FornecProd.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task Adicionar(TEntity obj);
        Task<TEntity> ObterPorId(Guid Id);
        Task<List<TEntity>> ObterTodos();
        Task Atualizar(TEntity obj);
        Task Remover(Guid Id);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();


    }
}
