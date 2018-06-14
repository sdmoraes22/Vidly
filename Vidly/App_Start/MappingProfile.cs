using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDTO>();
            Mapper.CreateMap<CustomerDTO, Customer>();

            Mapper.CreateMap<Movie, MovieDTO>();
            Mapper.CreateMap<MovieDTO, Movie>();

            Mapper.CreateMap<CustomerDTO, Customer>().ForMember(c => c.Customerid, opt => opt.Ignore());
            Mapper.CreateMap<MovieDTO, Movie>().ForMember(m => m.Movieid, opt => opt.Ignore());

        }
    }
}