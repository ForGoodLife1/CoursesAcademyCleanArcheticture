using CoursesAcademy.Core.Feautres.IndividualCQRS.Queries.ResultHandlers;
using CoursesAcademy.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesAcademy.Core.Feautres.IndividualCQRS.Queries.ModelsQueries
{
    public class GetIndividualListQuery:IRequest<List<GetIndividualResponse>>
    {
    }
}
