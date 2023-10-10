using FirstEF.Data;
using FirstEF.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace FirstEF.Controllers
{
    //BaseController 
    public class BaseController : Controller
    {
        public SalesContext db;
        public BaseController(SalesContext db)
        {
            this.db = db;
        }
    }
}
