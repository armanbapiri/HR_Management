using AutoMapper;
using HR_Management.Application.DTOs.Leave;
using HR_Management.Application.DTOs.Leave.LeaveRequset;
using HR_Management.Domian.Entities.Leave;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Management.Application.Profiles
{
    public  class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveAllocation, LeaveAllocationDTO>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDTO>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDTO>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDTO>().ReverseMap();
        }
    }
}
