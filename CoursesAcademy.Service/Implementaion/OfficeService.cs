using CoursesAcademy.Service.Abstract;

namespace CoursesAcademy.Infrastructure.Abstract
{
    public class OfficeService : IOfficeService
    {
        private readonly IOfficeRepository _officeRepository;

        public OfficeService(IOfficeRepository officeRepository)
        {
            _officeRepository=officeRepository;
        }



    }
}
