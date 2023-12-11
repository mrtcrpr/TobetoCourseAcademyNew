using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Course, CreateCourseRequest>().ReverseMap();
            CreateMap<Course, CreatedCourseResponse>().ReverseMap();
            CreateMap<Course, GetListedCourseResponse>().ReverseMap();
            CreateMap<Paginate<Course>, Paginate<GetListedCourseResponse>>().ReverseMap();

            CreateMap<Category, CreateCategoryRequest>().ReverseMap();
            CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
            CreateMap<Category, GetListedCategoryResponse>().ReverseMap();
            CreateMap<Paginate<Category>, Paginate<GetListedCategoryResponse>>().ReverseMap();

            CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
            CreateMap<Instructor, CreatedInstructorResponse>().ReverseMap();
            CreateMap<Instructor, GetListedInstructorResponse>().ReverseMap();
            CreateMap<Paginate<Instructor>, Paginate<GetListedInstructorResponse>>().ReverseMap();
        }
    }
}
