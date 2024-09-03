using BackAPI.Models;
using BackAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace BackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DBController : ControllerBase
    {
        private readonly DBService _databaseService;

        public DBController(DBService dbService)
        {
            _databaseService = dbService;
        }

        [HttpPost("connect")]
        public IActionResult Connect([FromBody] DBInfo dbInfo)
        {
            try
            {
                var connectionString = _databaseService.CreateConnectionString(dbInfo);

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    return Ok("Veritabanýna baþarýyla baðlanýldý.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Veritabaný baðlantýsý sýrasýnda bir hata oluþtu: {ex.Message}");
            }
        }

        [HttpPost("get-tables")]
        public IActionResult GetTables([FromBody] DBInfo dbInfo)
        {
            try
            {
                var connectionString = _databaseService.CreateConnectionString(dbInfo);
                var tables = _databaseService.GetTables(connectionString);

                return Ok(tables);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Tablolar alýnýrken bir hata oluþtu: {ex.Message}");
            }
        }

        [HttpPost("get-columns")]
        public IActionResult GetColumns([FromBody] DBInfo dbInfo, [FromQuery] string tableName)
        {
            try
            {
                var connectionString = _databaseService.CreateConnectionString(dbInfo);
                var columns = _databaseService.GetColumns(connectionString, tableName);

                return Ok(columns);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Kolonlar alýnýrken bir hata oluþtu: {ex.Message}");
            }
        }

        [HttpPost("get-data")]
        public IActionResult GetData([FromBody] DBQueryInfo queryInfo)
        {
            if (string.IsNullOrEmpty(queryInfo.DbType) ||
                string.IsNullOrEmpty(queryInfo.Password) ||
                string.IsNullOrEmpty(queryInfo.Username) ||
                string.IsNullOrEmpty(queryInfo.DatabaseName) ||
                string.IsNullOrEmpty(queryInfo.ServerAddress))
            {
                return BadRequest("All database connection fields are required.");
            }

            try
            {
                var connectionString = _databaseService.CreateConnectionString(queryInfo);
                var data = _databaseService.GetData(connectionString, queryInfo.SelectedTable, queryInfo.SelectedColumnX, queryInfo.SelectedColumnY);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Veri alýnýrken bir hata oluþtu: {ex.Message}");
            }
        }

    }
}
