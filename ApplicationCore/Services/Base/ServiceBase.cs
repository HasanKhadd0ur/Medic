using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using ApplicationDomain.Abstraction;
using ApplicationDomain.Exceptions;
using ApplicationDomain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceBase<TEntity,TDto> : IService<TDto> where  TEntity : EntityBase  where TDto : DTOBase 
    {
        protected  IMapper _mapper;
        protected readonly IUnitOfWork<TEntity> _unitOfWork;

        protected ISpecification<TEntity> _specification;


        public ServiceBase(
            IUnitOfWork<TEntity> unitOfWork,
            IMapper mapper
            )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        
        }
        public async Task<IEnumerable<TDto>> GetAll()
        {
                var r = await _unitOfWork.Entity.GetAll(
                _specification
                 );
            return _mapper.Map<IEnumerable<TDto>>(r);
        }
        public TDto Create(TDto model )
        {

            TEntity entity = _unitOfWork.Entity.Insert(_mapper.Map<TEntity>(model));
            _unitOfWork.Commit();
            return _mapper.Map<TDto>(entity);
        }

        public TDto Update(TDto model)
        {

            TEntity entity = _unitOfWork.Entity.Update(_mapper.Map<TEntity>(model));
            _unitOfWork.Commit();
            return _mapper.Map<TDto>(entity);
        }

        public async Task<TDto> GetDetails(int id)
        {

            var model = await _unitOfWork.Entity.GetById(id,
                _specification);
            if (model is null) {
                throw new NotFoundException();
            }
            return _mapper.Map<TDto>(model);

        }

        public void Delete(int id)
        {
            _unitOfWork.Entity.Delete(id);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<TDto>> GetByCriteria(Func<TDto, bool> Cretira)
        {
            Func<TEntity, bool> t = MapFunc(Cretira);
            var ol = _specification.Criteria;

            _specification.Criteria = expr =>t.Invoke(expr);

            var result =await _unitOfWork.Entity.GetAll(_specification);
            _specification.Criteria = ol;


            return _mapper.Map<IEnumerable<TDto>>(result);
        }
        public Func<EntityBase, bool> MapFunc(Func<TDto, bool> dtoFunc)
        {
            return entity =>
            {
                // Map the EntityBase instance to a DTO instance
                var dto = _mapper.Map<TDto>(entity);
                // Invoke the original function on the mapped DTO
                return dtoFunc(dto);
            };
        }
    }
}
