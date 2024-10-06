using CoursesAcademy.Data.Entities.Identity;
using CoursesAcademy.Infarastructure.InfrastructureBases;

namespace CoursesAcademy.Infrustructure.Abstracts
{
    public interface IRefreshTokenRepository : IGenericRepositoryAsync<UserRefreshToken>
    {

    }
}
