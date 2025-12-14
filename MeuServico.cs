using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using MeuProjeto.Models;

namespace MeuProjeto.Servicos
{
    public class MeuServico
    {
        private readonly string _connectionString;

        public MeuServico(string connectionString) => _connectionString = connectionString;

        public async Task<IEnumerable<Product>> ObterProdutosPaginadosAsync(int pagina, int tamanhoPagina)
        {
            using var conexao = new SqlConnection(_connectionString);

            var sql = @"
                SELECT ProductID, ProductName, UnitPrice, UnitsInStock
                FROM Products
                ORDER BY ProductID
                OFFSET @Offset ROWS
                FETCH NEXT @TamanhoPagina ROWS ONLY;
            ";

            var parametros = new
            {
                Offset = (pagina - 1) * tamanhoPagina,
                TamanhoPagina = tamanhoPagina
            };

            return await conexao.QueryAsync<Product>(sql, parametros);
        }
    }
}
