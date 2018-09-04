using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Std.Core
{
    public abstract class BaseAppService<TDto, TEntity> : IAppService<TDto>
        where TDto : BaseDto, IEntityDto<int>
        where TEntity : BaseEntity, IEntity<int>
    {
        public readonly IRepository<TEntity, int> _repository;

        protected BaseAppService(IRepository<TEntity, int> repository)
        {
            _repository = repository;
        }


        public TDto GetById(int id)
        {
            try
            {
                var entity = _repository.GetById(id);
                return entity.MapTo<TDto>();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Insert(TDto dto)
        {
            var entity = dto.MapTo<TEntity>();
            var result = _repository.Add(entity);
            return result;
        }


        public void Update(TDto dto)
        {
            var entity = dto.MapTo<TEntity>();
            _repository.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = GetById(id).MapTo<TEntity>();
            _repository.Delete(entity);
        }

    }
}
