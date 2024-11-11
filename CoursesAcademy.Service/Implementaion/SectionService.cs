using CoursesAcademy.Data.Entities;
using CoursesAcademy.Data.Enums;
using CoursesAcademy.Service.Abstract;
using Serilog;

namespace CoursesAcademy.Infrastructure.Abstract
{
    public class SectionService : ISectionService
    {
        private readonly ISectionService _sectionService;

        public SectionService(ISectionService sectionService)
        {
            _sectionService=sectionService;
        }

        public async Task<string> AddAsync(Section section)
        {
            await _sectionService.AddAsync(section);
            return "Success";
        }

        public async Task<string> DeleteAsync(Section section)
        {
            var trans = _sectionService.BeginTransaction();
            try
            {
                await _sectionService.DeleteAsync(section);
                await trans.CommitAsync();
                return "Success";
            }
            catch (Exception ex)
            {
                await trans.RollbackAsync();
                Log.Error(ex.Message);
                return "Falied";
            }
        }

        public async Task<string> EditAsync(Section section)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Section> FilterSectionPaginatedQuerable(SectionOrderingEnum orderingEnum, string search)
        {
            throw new NotImplementedException();
        }

        public async Task<Section> GetByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Section> GetSectionByIDWithIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Section> GetSectionsByDepartmentIDQuerable(int DID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Section>> GetSectionsListAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Section> GetSectionsQuerable()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsNameArExist(string nameAr)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsNameArExistExcludeSelf(string nameAr, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsNameEnExist(string nameEn)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id)
        {
            throw new NotImplementedException();
        }
    }
}
