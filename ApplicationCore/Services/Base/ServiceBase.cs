using ApplicationCore.DomainModel;
using ApplicationCore.Interfaces;
using ApplicationDomain.Abstraction;
using ApplicationDomain.Exceptions;
using ApplicationDomain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceBase<TEntity,TModel> : IService<TModel> where  TEntity : EntityBase  where TModel : DomainBase 
    {
        protected readonly IMapper _mapper;
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
        public async Task<IEnumerable<TModel>> GetAll()
        {
                var r = await _unitOfWork.Entity.GetAll(
                _specification
                 );
            return _mapper.Map<IEnumerable<TModel>>(r);
        }
        public TModel Create(TModel model )
        {

            TEntity entity = _unitOfWork.Entity.Insert(_mapper.Map<TEntity>(model));
            _unitOfWork.Commit();
            return _mapper.Map<TModel>(entity);
        }

        public TModel Update(TModel model)
        {

            TEntity entity = _unitOfWork.Entity.Update(_mapper.Map<TEntity>(model));
            _unitOfWork.Commit();
            return _mapper.Map<TModel>(entity);
        }

        public async Task<TModel> GetDetails(int id)
        {

            var model = await _unitOfWork.Entity.GetById(id,
                _specification);
            if (model is null) {
                throw new NotFoundException();
            }
            return _mapper.Map<TModel>(model);

        }

        public void Delete(int id)
        {
            _unitOfWork.Entity.Delete(id);
            _unitOfWork.Commit();
        }


    }
}
