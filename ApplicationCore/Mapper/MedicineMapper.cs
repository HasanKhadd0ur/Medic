using ApplicationCore.ViewModel;
using ApplicationDomain.Entities;
using AutoMapper;



namespace ApplicationCore.Mapper
{
    public class MedicineMapper :Profile
    {
        public MedicineMapper() {
            CreateMap<Medicine, MedicineViewModel>(
                );
        
        }
    }
}
