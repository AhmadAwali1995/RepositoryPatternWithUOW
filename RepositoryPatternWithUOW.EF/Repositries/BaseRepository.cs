using RepositoryPatternWithUOW.Core.Interfaces;
using RepositoryPatternWithUOW.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.EF.Repositries
{
    public class BaseRepository<Type> : IBaseRepository<Type> where Type : class
    {
        protected ApplicationDBContext _context;

        public BaseRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public Type GetById(int id)
        {
            return _context.Set<Type>().Find(id);
        }
    }
}
