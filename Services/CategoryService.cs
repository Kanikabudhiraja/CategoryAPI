using CategoryAPI.Models;
using CategoryAPI.Repositories;

namespace CategoryAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Category> CreateAsync(Category category)
        {
            category.CreatedDate = DateTime.UtcNow;
            return await _repository.CreateAsync(category);
        }

        public async Task<Category?> UpdateAsync(int id, Category category)
        {
            var existing = await _repository.GetByIdAsync(id);

            if (existing == null)
                return null;

            existing.Name = category.Name;
            existing.Description = category.Description;
            existing.IsActive = category.IsActive;

            existing.CreatedDate = DateTime.SpecifyKind(
                existing.CreatedDate,
                DateTimeKind.Utc);

            existing.UpdatedDate = DateTime.UtcNow;

            return await _repository.UpdateAsync(existing);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}