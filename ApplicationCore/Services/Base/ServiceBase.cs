using ApplicationCore.DomainModel;
using ApplicationCore.Interfaces;
using ApplicationDomain.Abstraction;
using ApplicationDomain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceBase<T,TModel> : IService<TModel> where  T : EntityBase  where TModel : DomainBase 
    {
        protected readonly IMapper _mapper;
        protected readonly IUnitOfWork<T> _unitOfWork;

        protected ISpecification<T> _specification;


        public ServiceBase(
            IUnitOfWork<T> unitOfWork,
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

            var ing = _unitOfWork.Entity.Insert(_mapper.Map<T>(model));
            _unitOfWork.Save();
            return _mapper.Map<TModel>(ing);
        }

        public TModel Update(TModel model)
        {

            var r = _unitOfWork.Entity.Update(_mapper.Map<T>(model));
            _unitOfWork.Save();
            return _mapper.Map<TModel>(r);
        }

        public async Task<TModel> GetDetails(int id)
        {

            return _mapper.Map<TModel>(await _unitOfWork.Entity.GetById(id,
                _specification));

        }

        public void Delete(int id)
        {
            _unitOfWork.Entity.Delete(id);
            _unitOfWork.Save();
        }


    }
}
