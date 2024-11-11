
using CoursesAcademy.Data.Entities;


namespace CoursesAcademy.Infrastructure.Abstract
{
    public interface IReviewRepository : IGenericRepositoryAsync<Review>
    {
        public Task<List<Review>> GetReviewsAsync();
    }
}
