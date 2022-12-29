using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Repository Design Pattern
    // generic constraint class: reference tip
    //IEntity :yalnızca IEntity ya da onu implemente eden bir class olabilir
    //new() : newlenebilir olmalı
    public interface IEntityRepository<T> where T : class , IEntity ,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
