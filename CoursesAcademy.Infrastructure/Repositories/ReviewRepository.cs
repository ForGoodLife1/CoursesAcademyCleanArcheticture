using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;
using CoursesAcademy.Infrastructure.Abstract;
using CoursesAcademy.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace CoursesAcademy.Infrastructure.Repositories
{
    public class ReviewRepository : GenericRepositoryAsync<Review>, IReviewRepository
    {
        private readonly AplicationDbContext _dbContext;

        public ReviewRepository(AplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext=dbContext;
        }
        public async Task<List<Review>> GetReviewsAsync()
        {
            return await _dbContext.Reviews.ToListAsync();
        }


    }
}
