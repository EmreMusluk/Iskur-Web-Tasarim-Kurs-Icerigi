using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller        //homecontroller bir class, controllerdan miras alıyo 
    {
        public IActionResult Index()        //Default olarak index metotu yaratıyo 
                                            //Index üstüne sağtıklayıp en baştaki add view a tıklıyosun razor görünümünü okeyliyosun layout tikini kaldırıyosun 
        {
            return View();      // Viewi htmlden çekiyo

        }
        public IActionResult Contact()        //yeni metot oluşturmak için yukardaki bloğu koyaladık contact diye bir metot daha oluşturduk.
                                              //contact üstüne sağtıklayıp en baştaki add view a tıklıyosun razor görünümünü okeyliyosun layout tikini kaldırıyosun 
        {
            return View();
        }
        public IActionResult About()        
                                             
        {
            return View();
        }
    }
}
