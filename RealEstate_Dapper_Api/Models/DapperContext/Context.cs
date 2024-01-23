using Microsoft.Data.SqlClient;
using System.Data;

namespace RealEstate_Dapper_Api.Models.DapperContext
{
    public class Context
    {
        //Bağlantı Konfigürasyonu
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public Context(IConfiguration configuration)// Constructor
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("connection"); //Baglantı adresi almak
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);  // Sqllin ormsini Microsotf data sql client ile calısılacak



        
    }
}
