using RealEstate_Dapper_Api.Dtos.CategoryDtos;

namespace RealEstate_Dapper_Api.Repositories.CategoryRepository
{

    //İnterface, bir sınıfın bir veya birden çok arayüzü uygulamasına olanak tanır.
    //Bir sınıf bir arayüzü uyguladığında, o arayüzde tanımlanan tüm yöntemleri (metodları) sınıf içinde implemente etmek zorundadır.
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategory(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto categoryDto);
    }
}
