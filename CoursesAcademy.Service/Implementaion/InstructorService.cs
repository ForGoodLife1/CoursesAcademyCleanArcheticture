using CoursesAcademy.Service.Abstract;

namespace CoursesAcademy.Infrastructure.Abstract
{
    public class InstructorService : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository;

        public InstructorService(IInstructorRepository instructorRepository)
        {
            _instructorRepository=instructorRepository;
        }



    }
}
