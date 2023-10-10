using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace PersonelProje.Controllers
{
    public class BaseController : Controller
    {
        public IConfiguration _config;
        public BaseController(IConfiguration config)
        {
            _config = config;
        }

        public SqlConnection Connect()
        {
            return new SqlConnection(_config.GetConnectionString("DbConnect"));
        }
    }
}
