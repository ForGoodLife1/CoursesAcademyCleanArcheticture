using AutoMapper;
using CoursesAcademy.Core.Feautres.IndividualCQRS.Queries.ModelsQueries;
using CoursesAcademy.Core.Feautres.IndividualCQRS.Queries.ResultHandlers;
using CoursesAcademy.Service.Abstract;
using MediatR;

namespace CoursesAcademy.Core.Feautres.IndividualCQRS.Queries.ResponseQueries
{
    public class IndividualQueryHandlers : IRequestHandler<GetIndividualListQuery, List<GetIndividualResponse>>
    {
        private readonly IIndividualService _individualService;
        private readonly IMapper _mapper;

        public IndividualQueryHandlers(IIndividualService IndividualService, IMapper mapper)
        {
            _individualService=IndividualService;
            _mapper=mapper;
        }
        public async Task<List<GetIndividualResponse>> Handle(GetIndividualListQuery request, CancellationToken cancellationToken)
        {
            var individualList = await _individualService.GetIndividualsAsync();
            var individualListMapper = _mapper.Map<List<GetIndividualResponse>>(individualList);
            return individualListMapper;
        }
    }
}
