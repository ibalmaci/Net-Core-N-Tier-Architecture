using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Std.Core
{
    public interface IAppService<TDto>
    {
        TDto GetById(int id);
        int Insert(TDto dto);
        void Update(TDto dto);
        void Delete(int id);
    }
}
