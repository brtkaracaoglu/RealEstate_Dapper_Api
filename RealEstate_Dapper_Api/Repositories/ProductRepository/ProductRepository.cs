using Dapper;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
using RealEstate_Dapper_Api.Dtos.ProductDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async void CreateProduct(CreateProductDto createProductDto)
        {
            string query = "insert into Product (Title,Price,CoverImage,City,District,Address,Description,Type,ProductCategory,EmployeeID) values (@title,@price,@coverImage,@city,@district,@address,@description,@type,@productCategory,@employeeID)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createProductDto.Title);
            parameters.Add("@price", createProductDto.Price);
            parameters.Add("@coverImage", createProductDto.Coverimage);
            parameters.Add("@city", createProductDto.City);
            parameters.Add("@district", createProductDto.District);
            parameters.Add("@address", createProductDto.Address);
            parameters.Add("@description", createProductDto.Description);
            parameters.Add("@type", createProductDto.Type);
            parameters.Add("@productCategory", createProductDto.ProductCategory);
            parameters.Add("@employeeID", createProductDto.EmployeeID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteProduct(int id)
        {
            string query = "Delete From Product Where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query,parameters);
            }
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * From Product";
            using (var connection = _context.CreateConnection())
            {
                //dapper kullanılan yer
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "SELECT ProductID, Title, Price, City, District, CategoryName,CoverImage,Type,Address,DealOfTheDay FROM Product INNER JOIN Category ON Product.ProductCategory = Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                //dapper kullanılan yer
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDProductDto> GetProduct(int id)
        {
            string query = "Select * From Product Where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID",id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDProductDto>(query,parameters);
                return values;
            }
        }

        public async void UpdateProduct(UpdateProductDto updateProductDto)
        {
            string query = "Update Product Set Title=@title,Price=@price,CoverImage=@coverImage,City=@city,District=@district,Address=@address,Description=@description,Type=@type,ProductCategory=@productCategory,EmployeeID=@employeeID Where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updateProductDto.Title);
            parameters.Add("@price", updateProductDto.Price);
            parameters.Add("@coverImage", updateProductDto.Coverimage);
            parameters.Add("@city", updateProductDto.City);
            parameters.Add("@district", updateProductDto.District);
            parameters.Add("@address", updateProductDto.Address);
            parameters.Add("@description", updateProductDto.Description);
            parameters.Add("@type", updateProductDto.Type);
            parameters.Add("@productCategory", updateProductDto.ProductCategory);
            parameters.Add("@employeeID", updateProductDto.EmployeeID);
            parameters.Add("@productID", updateProductDto.ProductID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
