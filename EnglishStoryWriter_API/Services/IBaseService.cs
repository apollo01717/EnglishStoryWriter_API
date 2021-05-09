using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Services
{
    public interface IBaseService <T, Dto, CreateDto>
    {
        public IEnumerable<Dto> GetAll();
        public Dto GetOne(int id);
        public T Create(CreateDto createDto);
        public void Update(CreateDto createDto, int id);
        public void Delete(int id);
    }
}
