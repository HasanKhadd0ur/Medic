using ApplicationCore.DomainModel;
using ApplicationDomain.Entities;
using AutoMapper;
using WebPresentation.ViewModels;

namespace ApplicationCore.Mappere
{
    public class ViewModelObjectMapper : Profile
    {
        public ViewModelObjectMapper()
        {
            CreateMap<MedicineViewModel, MedicineModel>()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
            .ForMember(dest => dest.MedicineType, opt => opt.MapFrom(src => src.MedicineType))
            .ForMember(dest => dest.Ingredients, opt => opt.MapFrom(src => src.Ingredients))
            .ForMember(dest => dest.MedicineIngredients, opt => opt.MapFrom(src => src.MedicineIngredients));
            ;
            CreateMap<MedicineModel, MedicineViewModel>()
                .ForMember(de => de.Ingredients, o => o.MapFrom(s => s.Ingredients))
                .ForMember(de => de.MedicineIngredients, o => o.MapFrom(s => s.MedicineIngredients))
                .ForMember(de => de.MedicineType, o => o.MapFrom(s => s.MedicineType))
                .ForMember(de => de.Category, o => o.MapFrom(s => s.Category.Name))
                ;
            CreateMap<PatientModel, PatientViewModel>().ReverseMap();
            
            CreateMap<Ingredient, IngredientModel>().ReverseMap();
            
            CreateMap<MedicalStateViewModel, MedicalStateModel>().ReverseMap();
            
            CreateMap<DomainBase, BaseViewModel>().ReverseMap();

        }
    }
}
