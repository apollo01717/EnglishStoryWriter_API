using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public abstract class BaseRepository<T, Dto> : IBaseRepository<T, Dto> where T : class
    {
        protected readonly EnglishDbContext _englishDbContext;
        public BaseRepository(EnglishDbContext englishDbContext)
        {
            _englishDbContext = englishDbContext;
        }

        public T Create(T element)
        {
            _englishDbContext.Set<T>().Add(element);
            _englishDbContext.SaveChanges();
            return element;
        }

        public void Delete(T element)
        {
            _englishDbContext.Set<T>().Remove(element);
        }

        public IList<T> GetAll()
        {
            return _englishDbContext.Set<T>().ToList();
        }

        public T GetOne(int id)
        {
            return _englishDbContext.Set<T>().Find(id);
        }

        //public void Update(TEntity element, Dto dto)
        //{
        //    element.Name = dto.Name;
        //    _englishDbContext.SaveChanges();

        //}
        public void Update(T element, Dto dto)
        {
            throw new NotImplementedException();
        }
    }
}
