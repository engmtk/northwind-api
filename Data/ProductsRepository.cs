using Dapper;
using Microsoft.Data.SqlClient;
using NorthwindApi.Models;

namespace NorthwindApi.Data
{
    public class ProductsRepository
    {
        private readonly string _connectionString;

        public ProductsRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Northwind")
                ?? throw new InvalidOperationException("Connection string 'Northwind' não encontrada.");
        }

        public async Task<IEnumerable<Product>> GetPagedAsync(int page, int pageSize)
        {
            if (page <= 0) page = 1;
            if (pageSize <= 0) pageSize = 10;
            if (pageSize > 200) pageSize = 200;

            await using var conexao = new SqlConnection(_connectionString);

            var sql = @"
                SELECT ProductID, ProductName, UnitPrice, UnitsInStock
                FROM Products
                ORDER BY ProductID
                OFFSET @Offset ROWS
                FETCH NEXT @PageSize ROWS ONLY;
            ";

            var parametros = new
            {
                Offset = (page - 1) * pageSize,
                PageSize = pageSize
            };

            return await conexao.QueryAsync<Product>(sql, parametros);
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            await using var conexao = new SqlConnection(_connectionString);

            var sql = @"
                SELECT ProductID, ProductName, UnitPrice, UnitsInStock
                FROM Products
                WHERE ProductID = @Id;
            ";

            return await conexao.QueryFirstOrDefaultAsync<Product>(sql, new { Id = id });
        }
    }
}
