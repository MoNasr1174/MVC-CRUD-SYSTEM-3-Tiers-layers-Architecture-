using AutoMapper;
using MVC.DAL.Models;
using MVC_.PL.ViewModels;

namespace MVC_.PL.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<EmployeeViewModel, Employee>().ReverseMap();
        }
    }
}
