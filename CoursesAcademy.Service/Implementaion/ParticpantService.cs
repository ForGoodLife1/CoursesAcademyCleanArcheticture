using CoursesAcademy.Service.Abstract;

namespace CoursesAcademy.Infrastructure.Abstract
{
    public class ParticpantService : IParticpantService
    {
        private readonly IParticpantRepository _particpantRepository;

        public ParticpantService(IParticpantRepository particpantRepository)
        {
            _particpantRepository = particpantRepository;
        }



    }
}
