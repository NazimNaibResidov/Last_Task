using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Test.WebUI.Entity.Core
{
    public class Baseresptory<T> : IBaseResptory<T> where T : class
    {
        private readonly DbContext context;
        public Baseresptory(DbContext Context)
        {
            context = Context;
        }

        public Task<bool> Add(T entity)
        {
           context.Set<T>().AddAsync(entity);
           return   Save(context);
        }

        public Task<bool> Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            return Save(context);
        }

        public Task<T> GetById(T entity)
        {
           return  context.Set<T>().FirstAsync<T>();
           
        }

        public IQueryable<T> GetList()
        {
           return context.Set<T>().AsQueryable();
        }

        public Task<bool> Update(T entity)
        {
            context.Set<T>().Update(entity);
            return    Save(context);
        }

        private async Task<bool> Save(DbContext context)
        {
            try
            {
               return await context.SaveChangesAsync()>0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
