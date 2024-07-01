using ApplicationCore.DTOs;
using ApplicationDomain.Entities;
using AutoMapper;
using System;
using System.Linq.Expressions;

namespace ApplicationCore.Mapper
{
    public class ObjectMapper :Profile
    {
        public ObjectMapper() {

            CreateMap<Medicine, MedicineDTO>()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
            .ForMember(dest => dest.MedicineType, opt => opt.MapFrom(src => src.MedicineType))
            .ForMember(dest => dest.Ingredients, opt => opt.MapFrom(src => src.Ingredients))
            .ForMember(dest => dest.MedicineIngredients, opt => opt.MapFrom(src => src.MedicineIngredients));
            ;
            CreateMap<MedicineDTO, Medicine>()
                .ForMember(de => de.Ingredients, o => o.MapFrom(s => s.Ingredients))
                .ForMember(de => de.MedicineIngredients, o => o.MapFrom(s => s.MedicineIngredients))
                .ForMember(de => de.MedicineType, o => o.MapFrom(s => s.MedicineType))
                .ForMember(de => de.Category, o => o.MapFrom(s => s.Category))
                .ForMember(dest => dest.MedicalStates, opt => opt.Ignore())
                .ForMember(dest => dest.MedicalStateMedicines, opt => opt.Ignore())
                ;
            CreateMap<PatientDTO, Patient>().ReverseMap();
            CreateMap<Patient, PatientDTO>().ReverseMap();
            CreateMap<Ingredient, IngredientDTO>().ReverseMap();
            CreateMap<MedicalState, MedicalStateDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
              //  .ForMember(dest => dest.Patient, opt => opt.MapFrom(src => src.Patient))
                .ForMember(dest => dest.Medicines, opt => opt.MapFrom(src => src.Medicines));
            ;

            CreateMap<MedicalStateDTO, MedicalState>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
              //  .ForMember(dest => dest.Patient, opt => opt.MapFrom(src => src.Patient))
                .ForMember(dest => dest.Medicines, opt => opt.MapFrom(src => src.Medicines))
                .ForMember(s=>s.MedicalStateMedicines , op=>op.Ignore())
                .ForMember(s => s.Patient, op => op.Ignore());

            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>()
                .ForMember(dest => dest.Medicines, opt => opt.Ignore())
                ;
            CreateMap<MedicineType, MedicineTypeDTO>().ReverseMap();

            CreateMap<MedicalStateMedicine, MedicalStateMedicineDTO>().ReverseMap();
           
        }
    }
}
