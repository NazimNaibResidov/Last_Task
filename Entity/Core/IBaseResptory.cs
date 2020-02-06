using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Test.WebUI.Entity.Core
{
    public interface IBaseResptory<T> where T:class
    {
       IQueryable<T> GetList();
        Task<bool> Add(T entity);
        Task<bool> Delete(T entity);
        Task<bool> Update(T entity);
        Task<T> GetById(T entity);
    }
}
