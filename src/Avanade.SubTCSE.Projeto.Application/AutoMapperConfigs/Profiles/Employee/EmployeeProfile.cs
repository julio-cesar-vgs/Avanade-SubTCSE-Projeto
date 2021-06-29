using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.Employee
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Dtos.Employee.EmployeeDto, Avanade_SubTCSE_Projeto.Domain.Aggregates.Employee.Entities.Employee>()
                .ForCtorParam("new", opt => opt.MapFrom(src => src.PrimeiroNome))
                .ForCtorParam("new", opt => opt.MapFrom(src => src.SobreNome))
                .ForCtorParam("new", opt => opt.MapFrom(src => src.Aniversario))
                .ForCtorParam("new", opt => opt.MapFrom(src => src.Salario))
                .ForCtorParam("new", opt => opt.MapFrom(src => src.Ativo))
                .ForCtorParam("new", opt => opt.MapFrom(src => src.EmployeeRoleDto))
                .ForAllOtherMembers(i => i.Ignore());
                ;

            CreateMap<Avanade_SubTCSE_Projeto.Domain.Aggregates.Employee.Entities.Employee, Dtos.Employee.EmployeeDto>()
                .ForMember(dest => dest.Identificador, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PrimeiroNome, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.SobreNome, opt => opt.MapFrom(src => src.SurName))
                .ForMember(dest => dest.Aniversario, opt => opt.MapFrom(src => src.Birthday))
                .ForMember(dest => dest.Ativo, opt => opt.MapFrom(src => src.Active))
                .ForMember(dest => dest.Salario, opt => opt.MapFrom(src => src.Salary))
                .ForMember(dest => dest.EmployeeRoleDto.Cargo, opt => opt.MapFrom(src => src.EmployeeRole))
                .ForAllOtherMembers(i => i.Ignore());
        }
    }
}
