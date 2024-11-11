using CoursesAcademy.Service.Abstract;

namespace CoursesAcademy.Infrastructure.Abstract
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }



    }
}
