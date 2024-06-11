using ApplicationCore.DomainModel;
using ApplicationDomain.Entities;
using AutoMapper;



namespace ApplicationCore.Mapper
{
    public class ObjectMapper :Profile
    {
        public ObjectMapper() {

            CreateMap<Medicine, MedicineModel>()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
            .ForMember(dest => dest.MedicineType, opt => opt.MapFrom(src => src.MedicineType))
            .ForMember(dest => dest.Ingredients, opt => opt.MapFrom(src => src.Ingredients))
            .ForMember(dest => dest.MedicineIngredients, opt => opt.MapFrom(src => src.MedicineIngredients));
            ;
            CreateMap<MedicineModel, Medicine>()
                .ForMember(de => de.Ingredients, o => o.MapFrom(s => s.Ingredients))
                .ForMember(de => de.MedicineIngredients, o => o.MapFrom(s => s.MedicineIngredients))
                .ForMember(de => de.MedicineType, o => o.MapFrom(s => s.MedicineType))
                .ForMember(de => de.Category, o => o.MapFrom(s => s.Category))
                .ForMember(dest => dest.MedicalStates, opt => opt.Ignore())
                .ForMember(dest => dest.MedicalStateMedicines, opt => opt.Ignore())
                ;
            CreateMap<PatientModel, Patient>().ReverseMap();
            CreateMap<Patient, PatientModel>().ReverseMap();
            CreateMap<Ingredient, IngredientModel>().ReverseMap();
            CreateMap<MedicalState, MedicalStateModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Patient, opt => opt.MapFrom(src => src.Patient))
                .ForMember(dest => dest.Medicines, opt => opt.MapFrom(src => src.Medicines));
            ;

            CreateMap<MedicalStateModel, MedicalState>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Patient, opt => opt.MapFrom(src => src.Patient))
                .ForMember(dest => dest.Medicines, opt => opt.MapFrom(src => src.Medicines))
                .ForMember(s=>s.MedicalStateMedicines , op=>op.Ignore());
          
            CreateMap<Category, CategoryModel>();
            CreateMap<CategoryModel, Category>()
                .ForMember(dest => dest.Medicines, opt => opt.Ignore())
                ;
            CreateMap<MedicineType, MedicineTypeModel>().ReverseMap();

            CreateMap<MedicalStateMedicine, MedicalStateMedicineModel>().ReverseMap();
            CreateMap<DomainBase, EntityBase>().ReverseMap();

        }
    }
}
