using AutoMapper;
using CoursesAcademy.Core.Feautres.IndividualCQRS.Queries.ResultHandlers;
using CoursesAcademy.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesAcademy.Core.Mapping.IndividualMapping
{
    public class IndividualProfile : Profile
    {
        public IndividualProfile()
        {
            CreateMap<Individual, GetIndividualResponse>();

        }
    }
}
