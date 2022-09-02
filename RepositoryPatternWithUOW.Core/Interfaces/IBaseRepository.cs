using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.Core.Interfaces
{
    public interface IBaseRepository<Type> where Type : class
    {
        Type GetById(int id);

    }
}
