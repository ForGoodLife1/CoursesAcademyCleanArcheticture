using CoursesAcademy.Service.Abstract;

namespace CoursesAcademy.Infrastructure.Abstract
{
    public class CoporateService : ICoporateService
    {
        private readonly ICoporateRepository _coporateRepository;

        public CoporateService(ICoporateRepository coporateRepository)
        {
            _coporateRepository=coporateRepository;
        }



    }
}
