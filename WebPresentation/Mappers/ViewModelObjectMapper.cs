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
            CreateMap<MedicineViewModel, MedicineDTO>()
               .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.ImageName)) // Map ImageName from MedicineViewModel to Image in MedicineDTO
               .ForMember(dest => dest.Ingredients, opt => opt.MapFrom(src => src.Ingredients))
               .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
               .ForMember(dest => dest.Dosage, opt => opt.MapFrom(src => src.Dosage))
               .ForMember(dest => dest.MedicineType, opt => opt.MapFrom(src => src.MedicineType))
               .ForMember(dest => dest.MedicineIngredients, opt => opt.MapFrom(src => src.MedicineIngredients));

            CreateMap<MedicineDTO, MedicineViewModel>()
                .ForMember(dest => dest.ImageName, opt => opt.MapFrom(src => src.Image))
                .ForMember(dest => dest.Ingredients, opt => opt.MapFrom(src => src.Ingredients))
                .ForMember(dest => dest.MedicineIngredients, opt => opt.MapFrom(src => src.MedicineIngredients));


            CreateMap<PatientViewModel, PatientDTO>();
            CreateMap<PatientDTO, PatientViewModel>()
                .ForMember(dest => dest.ImageName, opt => opt.MapFrom(src => src.User.Avatar))
                .ForMember(dest => dest.ImageFile, opt => opt.Ignore());

            ;

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
