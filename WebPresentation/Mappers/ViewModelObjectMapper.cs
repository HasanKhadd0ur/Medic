using ApplicationCore.DTOs;
using ApplicationDomain.Entities;
using AutoMapper;
using WebPresentation.ViewModels;

namespace ApplicationCore.Mappere
{
    public class ViewModelObjectMapper : Profile
    {
        public ViewModelObjectMapper()
        {
            CreateMap<MedicineViewModel, MedicineDTO>().ReverseMap();
            CreateMap<PatientDTO, PatientViewModel>().ReverseMap();
            
            CreateMap<IngredientViewModel, IngredientDTO>().ReverseMap();
            CreateMap<MedicineIngredientDTO, MedicineIngredientViewModel>().ReverseMap();

            CreateMap<MedicalStateViewModel, MedicalStateDTO>().ReverseMap();
            
            CreateMap<DTOBase, BaseViewModel>().ReverseMap();
           
            CreateMap<CategoryDTO, CategoryViewModel>().ReverseMap();
            CreateMap<MedicineTypeDTO, MedicineTypeViewModel>().ReverseMap();

            CreateMap<MedicalStateMedicineDTO, MedicalStateMedicineVModel>().ReverseMap();

        }
    }
}
