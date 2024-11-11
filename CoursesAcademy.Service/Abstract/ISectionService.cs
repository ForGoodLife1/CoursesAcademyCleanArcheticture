using CoursesAcademy.Data.Entities;
using CoursesAcademy.Data.Enums;

namespace CoursesAcademy.Service.Abstract
{
    public interface ISectionService
    {
        public Task<List<Section>> GetSectionsListAsync();
        public Task<Section> GetSectionByIDWithIncludeAsync(int id);
        public Task<Section> GetByIDAsync(int id);
        public Task<string> AddAsync(Section section);
        public Task<bool> IsNameArExist(string nameAr);
        public Task<bool> IsNameEnExist(string nameEn);
        public Task<bool> IsNameArExistExcludeSelf(string nameAr, int id);
        public Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id);
        public Task<string> EditAsync(Section section);
        public Task<string> DeleteAsync(Section section);
        public IQueryable<Section> GetSectionsQuerable();
        public IQueryable<Section> GetSectionsByDepartmentIDQuerable(int DID);
        public IQueryable<Section> FilterSectionPaginatedQuerable(SectionOrderingEnum orderingEnum, string search);
    }
}
