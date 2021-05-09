using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public interface IBaseRepository <T, CreateDto>
    {
        public IList<T> GetAll();
        public T GetOne(int id);
        public T Create(T element);
        public void Update(T element, CreateDto dto);
        public void Delete(T element);
    }
}
